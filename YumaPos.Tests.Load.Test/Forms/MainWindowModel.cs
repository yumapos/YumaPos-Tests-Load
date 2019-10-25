using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using YumaPos.Tests.Load.Client.Annotations;
using YumaPos.Tests.Load.Client.Data.Models;

namespace YumaPos.Tests.Load.Client.Forms
{
    public class MainWindowModel : INotifyPropertyChanged
    {
        private string _status;
        private string _serverUrl;
        private Dictionary<int, JobModel> _jobModels = new Dictionary<int, JobModel>();

        public string Status
        {
            get => _status;
            set { _status = value; OnPropertyChanged(nameof(Status));}
        }

        public string ServerUrl
        {
            get => _serverUrl;
            set { _serverUrl = value; OnPropertyChanged(nameof(ServerUrl)); }
        }

        public bool IsStopping { get; set; }
        public Dictionary<int, JobModel> JobModels => _jobModels;

        public event EventHandler Stopped;
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Stop()
        {
            IsStopping = true;
            Stopped?.Invoke(this, new EventArgs());
        }

        public void AddRunning(TestTask testTask)
        {
            if (!_jobModels.TryGetValue(testTask.JobId, out var jobModel))
            {
                jobModel = new JobModel();
                _jobModels[testTask.JobId] = jobModel;
            }
            jobModel.Import(testTask);
            OnPropertyChanged(nameof(JobModels));
        }

        public void RemoveRunning(int testTaskJobId)
        {
            if (_jobModels.TryGetValue(testTaskJobId, out var jobModel))
            {
                jobModel.Decrease();
                OnPropertyChanged(nameof(JobModels));
            }
        }
    }

    public class JobModel
    {
        public void Import(TestTask testTask)
        {
            JobId = testTask.JobId;
            TenantAlias = testTask.TenantAlias;
            Start = testTask.Start;
            Duration = testTask.Duration;
            MinInterval = testTask.MinInterval;
            MaxInterval = testTask.MaxInterval;
            Scenarios = testTask.Scenarios.Select( p=> p.Split('.').Last().Replace("Scenario","")).ToArray();
            Count++;
        }

        public int Count { get; private set; } = 0;

        public TimeSpan MaxInterval { get; private set; }

        public string[] Scenarios { get; private set; }

        public TimeSpan MinInterval { get; private set; }

        public TimeSpan Duration { get; private set; }

        public DateTime Start { get; private set; }

        public string TenantAlias { get; private set; }

        public int JobId { get; private set; }

        public void Decrease()
        {
            Count--;
        }
    }
}