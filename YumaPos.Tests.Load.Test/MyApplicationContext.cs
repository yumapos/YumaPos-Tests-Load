using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YumaPos.Tests.Load.Client.Forms;

namespace YumaPos.Tests.Load.Client
{
    class MyApplicationContext : ApplicationContext
    {
        //Component declarations
        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayIconContextMenu;
        private ToolStripMenuItem CloseMenuItem;
        private ToolStripMenuItem ShowMenuItem;
        private MainForm MainWindow;

        public MyApplicationContext()
        {
            Application.ApplicationExit += OnApplicationExit;
            InitializeComponent();
            TrayIcon.Visible = true;
        }

        private void InitializeComponent()
        {
            TrayIcon = new NotifyIcon
            {
                BalloonTipIcon = ToolTipIcon.Info,
                BalloonTipText = "I noticed that you double-clicked me! What can I do for you?",
                BalloonTipTitle = "You called Master?",
                Text = "Yumapos test client",
                Icon = Resources.Resource.TrayIcon
            };

            MainWindow = new MainForm();
            MainWindow.Show();
            MainWindow.MainWindowModel.Stopped += OnApplicationExit;

            //The icon is added to the project resources.
            //Here I assume that the name of the file is 'TrayIcon.ico'

            //Optional - handle doubleclicks on the icon:
            TrayIcon.Click += TrayIcon_Click;
            TrayIcon.DoubleClick += TrayIcon_DoubleClick;

            //Optional - Add a context menu to the TrayIcon:
            TrayIconContextMenu = new ContextMenuStrip();
            CloseMenuItem = new ToolStripMenuItem();
            ShowMenuItem = new ToolStripMenuItem();
            TrayIconContextMenu.SuspendLayout();

            // 
            // TrayIconContextMenu
            // 
            this.TrayIconContextMenu.Items.AddRange(new ToolStripItem[] {ShowMenuItem, new ToolStripSeparator(), CloseMenuItem});
            this.TrayIconContextMenu.Name = "TrayIconContextMenu";
            this.TrayIconContextMenu.Size = new Size(153, 70);
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new Size(152, 22);
            this.CloseMenuItem.Text = "Exit";
            this.CloseMenuItem.Click += new EventHandler(this.CloseMenuItem_Click);
            // 
            // ShowMenuItem
            // 
            this.ShowMenuItem.Name = "ShowMenuItem";
            this.ShowMenuItem.Size = new Size(152, 22);
            this.ShowMenuItem.Text = "Open window";
            this.ShowMenuItem.Click += new EventHandler(this.ShowMenuItem_Click);

            TrayIconContextMenu.ResumeLayout(false);
            TrayIcon.ContextMenuStrip = TrayIconContextMenu;

            App = Bootstrapper.GetObjectInstance<App>();
            App.WindowModel = MainWindow.MainWindowModel;
            TaskScheduler.UnobservedTaskException += ErrorHandler;
            Task.Factory.StartNew(App.Start, TaskCreationOptions.LongRunning);
        }

        private void ErrorHandler(object sender, UnobservedTaskExceptionEventArgs unobservedTaskExceptionEventArgs)
        {
            var ex = unobservedTaskExceptionEventArgs.Exception.Flatten();
            MessageBox.Show(ex.Message);
        }

        public App App { get; set; }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            //Cleanup so that the icon will be removed when the application is closed
            App.Stop().Wait();
            TrayIcon.Visible = false;
        }

        private void TrayIcon_Click(object sender, EventArgs e)
        {
            //TrayIcon.ShowBalloonTip(10000);
        }
        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            MainWindow.Show();
        }

        private void ShowMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow.Show();
        }
        private async void CloseMenuItem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Do you really want to close me?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MainWindow.MainWindowModel.Stop();
                await App.Stop();
                Application.Exit();
            }
        }
    }
}