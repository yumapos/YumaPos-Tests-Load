using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using YumaPos.Shared.Exceptions;
using YumaPos.Tests.Load.Client.Data.Interfaces;
using YumaPos.Tests.Load.Client.Data.Models;
using YumaPos.Tests.Load.Client.Forms;
using YumaPos.Tests.Load.Client.Interfaces;
using YumaPos.Tests.Load.Client.Logic;
using YumaPos.Tests.Load.Infrastructure.Dto;

namespace YumaPos.Tests.Load.Client
{
    public class App
    {
        private bool _run = true;
        private readonly IConfig _config;
        private readonly ITestApi _testApi;
        private readonly ITaskRepository _taskRepository;
        private readonly List<TestEngine> _runningInstances = new List<TestEngine>();
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public App(IConfig config, ITestApi testApi, ITaskRepository taskRepository)
        {
            _config = config;
            _testApi = testApi;
            _taskRepository = taskRepository;
        }

        public MainWindowModel WindowModel { get; set; }

        public async Task Stop()
        {
            _run = false;
            foreach (var testEngine in _runningInstances)
            {
                testEngine.Stop();
            }
            await _testApi.CancelMyTasks(_config.ClientToken);
        }

        public async void Start()
        {
            try
            {
                if (!_config.ClientIsRegistered)
                {
                    var token = await _testApi.RegisterClient(_config.ClientId, System.Environment.MachineName);
                    _config.ClientToken = token;
                    _config.ClientIsRegistered = true;
                }
                try
                {
                    await _taskRepository.Clear();
                    await _testApi.CancelMyTasks(_config.ClientToken);
                    WindowModel.Status = "Waiting for test tasks";
                }
                catch (FaultException e)
                {
                    WindowModel.Status = e.Message;
                    _run = false;
                }
                while (_run)
                {
                    await CheckNewTask();
                    await CheckTaskForExecute();
                    await Task.Delay(TimeSpan.FromSeconds(0.2));
                }
            }
            catch (Exception exception)
            {
                _logger.Error(exception);
                if (exception is AggregateException) exception = ((AggregateException)exception).Flatten();
                MessageBox.Show(exception.Message);
                Application.Exit();
            }
            finally
            {
                _run = false;
            }
        }

        private async Task CheckNewTask()
        {
            TestTaskDto[] tasks;
            tasks = await _testApi.GetTasks(_config.ClientToken, _config.MaxInstanceCount);
            if (tasks != null && tasks.Length > 0)
            {
                await _taskRepository.AddRange(tasks.Select(p => p.MapFromDto()));
            }
        }

        private async Task CheckTaskForExecute()
        {
            var tasks = (await _taskRepository.GetReadyTasks()).ToList();
            if (tasks.Any())
            {
                foreach (TestTask testTask in tasks)
                {
                    var engine = new TestEngine();
                    _runningInstances.Add(engine);
                    WindowModel.AddRunning(testTask);
                    engine.Finished += OnTestEngineFinished;
                    engine.Reported += OnTestEngineReported;
                    engine.TestTask = testTask;
                    engine.ThreadTask = Task.Factory.StartNew(engine.Start, TaskCreationOptions.LongRunning);
                    await _taskRepository.SetIsStarting(testTask.TaskId);
                }
            }
        }

        private async void OnTestEngineFinished(object sender, EventArgs e)
        {
            var engine = (TestEngine)sender;
            _runningInstances.Remove(engine);
            engine.Finished -= OnTestEngineFinished;
            engine.Reported -= OnTestEngineReported;
            await _testApi.Report(_config.ClientToken, engine.GetReport());
            await _testApi.Finish(_config.ClientToken, engine.TestTask.TaskId);
            WindowModel.RemoveRunning(engine.TestTask.JobId);
            engine.Dispose();
        }
        private async void OnTestEngineReported(object sender, EventArgs e)
        {
            var engine = (TestEngine)sender;
            await _testApi.Report(_config.ClientToken, engine.GetReport());
        }
    }
}