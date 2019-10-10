using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using YumaPos.Tests.Load.Client.Annotations;

namespace YumaPos.Tests.Load.Client.Forms
{
    public class MainWindowModel : INotifyPropertyChanged
    {
        private string _status;
        private string _serverUrl;

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
    }
}