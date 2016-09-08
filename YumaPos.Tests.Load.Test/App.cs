using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Client.Interfaces;
using YumaPos.Tests.Load.Client.Logic;
using YumaPos.Tests.Load.Data.Interfaces;
using YumaPos.Tests.Load.Data.Models;
using YumaPos.Tests.Load.Infrastucture.Dto;
using YumaPos.Tests.Load.Test.Logic;

namespace YumaPos.Tests.Load.Client
{
    public class App
    {
        private bool _run = true;
        private readonly IConfig _config;
        private readonly ITestApi _testApi;
        private readonly ITaskRepository _taskRepository;
        private readonly List<TestEngine> _runningInstances = new List<TestEngine>();
        private CancellationTokenSource _cancellationTokenSource;

        public App(IConfig config, ITestApi testApi, ITaskRepository taskRepository)
        {
            _config = config;
            _testApi = testApi;
            _taskRepository = taskRepository;
        }

        public void Stop()
        {
            _run = false;
        }

        public async void Start()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            if (!_config.ClientIsRegistered)
            {
                var token = await _testApi.RegisterClient(_config.ClientId);
                _config.ClientToken = token;
            }
            while (_run)
            {
                await CheckNewTask();
                await CheckTaskForExecute();
                await Task.Delay(TimeSpan.FromMinutes(1), _cancellationTokenSource.Token);
            }
            StopAllTasks();
        }

        private async Task CheckNewTask()
        {
            TestTaskDto[] tasks = await _testApi.GetTasks(_config.ClientToken, _config.MaxInstanceCount);
            if (tasks.Length > 0)
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
                    engine.Finished += OnTestEngineFinished;
                    engine.TestTask = testTask;
                    engine.ThreadTask = Task.Factory.StartNew(engine.Start, TaskCreationOptions.LongRunning);
                    await _taskRepository.SetIsStarting(testTask.TaskId);
                }
            }
        }

        private void OnTestEngineFinished(object sender, EventArgs e)
        {
            var engine = (TestEngine) sender;
            _runningInstances.Remove(engine);
            engine.Finished -= OnTestEngineFinished;
            engine.Dispose();
        }

        private void StopAllTasks()
        {
            _cancellationTokenSource.Cancel();
            foreach (var testEngine in _runningInstances)
            {
                testEngine.Stop();
            }
        }
    }
}