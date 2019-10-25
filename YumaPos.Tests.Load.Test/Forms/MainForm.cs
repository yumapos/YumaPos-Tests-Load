using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace YumaPos.Tests.Load.Client.Forms
{
    public partial class MainForm : Form
    {
        private bool _exit;
        private Dictionary<int,Control> _jobControls = new Dictionary<int, Control>();
        private Timer _refreshTimer;

        public MainForm()
        {
            InitializeComponent();
            MainWindowModel = new MainWindowModel();
            MainWindowModel.PropertyChanged += ModelOnPropertyChanged;
            _refreshTimer = new Timer();
            _refreshTimer.Interval = 1000;
            _refreshTimer.Tick += RefreshTimerOnTick;
            _refreshTimer.Start();
        }

        private void RefreshTimerOnTick(object sender, EventArgs e)
        {
            foreach (var jobControl in _jobControls)
            {
                jobControl.Value.Refresh();
            }
        }

        private void ModelOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            tlblStatus.Text = MainWindowModel.Status;
            if (e.PropertyName == nameof(Forms.MainWindowModel.JobModels))
            {
                UpdateJobList();
            }
        }

        private void UpdateJobList()
        {
            foreach (var jobModelPair in MainWindowModel.JobModels)
            {
                if (!_jobControls.ContainsKey(jobModelPair.Key))
                {
                    panel1.InvokeIfRequired(() =>
                    {
                        JobControl jobControl = new JobControl();
                        jobControl.Model = jobModelPair.Value;
                        jobControl.Width = panel1.ClientSize.Width-6;
                        _jobControls[jobModelPair.Key] = jobControl;
                        panel1.Controls.Add(jobControl);
                    });
                }
            }
        }

        public MainWindowModel MainWindowModel { get; }

        private void tbtnExit_Click(object sender, System.EventArgs e)
        {
            MainWindowModel.Stop();
            Application.Exit();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!MainWindowModel.IsStopping)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void tbtnOptions_Click(object sender, System.EventArgs e)
        {
            using (var op = new OptionForm())
            {
                op.ServerUrl = MainWindowModel.ServerUrl;
                op.StartPosition = FormStartPosition.CenterParent;
                if (op.ShowDialog(this) == DialogResult.OK)
                {
                    MainWindowModel.ServerUrl = op.ServerUrl;
                }
            }
        }


    }
}
