using System.ComponentModel;
using System.Windows.Forms;

namespace YumaPos.Tests.Load.Client.Forms
{
    public partial class MainForm : Form
    {
        private bool _exit;

        public MainForm()
        {
            Model = new MainWindowModel();
            Model.PropertyChanged += ModelOnPropertyChanged;
            InitializeComponent();
        }

        private void ModelOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            tlblStatus.Text = Model.Status;
        }

        public MainWindowModel Model { get; }

        private void tbtnExit_Click(object sender, System.EventArgs e)
        {
            Model.Stop();
            Application.Exit();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Model.IsStopping)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void tbtnOptions_Click(object sender, System.EventArgs e)
        {
            using (var op = new OptionForm())
            {
                op.ServerUrl = Model.ServerUrl;
                op.StartPosition = FormStartPosition.CenterParent;
                if (op.ShowDialog(this) == DialogResult.OK)
                {
                    Model.ServerUrl = op.ServerUrl;
                }
            }
        }
    }
}
