using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YumaPos.Tests.Load.Client.Forms
{
    public partial class JobControl : UserControl
    {
        public JobModel Model { get; set; }
        public JobControl()
        {
            InitializeComponent();
            this.Refresh();
        }

        public override void Refresh()
        {
            base.Refresh();
            if (Model == null) return;
            lblJobId.Text = Model.JobId.ToString();
            lblTerminalCount.Text = Model.Count.ToString();
            lblTenantAlias.Text = Model.TenantAlias.ToString();
            lblEstimated.Text = (Model.Duration - (DateTime.Now - Model.Start)).ToString(@"hh\:mm\:ss");
            txtScenarios.Text = String.Join(",\r\n",Model.Scenarios);
        }
    }
}
