namespace YumaPos.Tests.Load.Client.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnOptions = new System.Windows.Forms.ToolStripButton();
            this.tlblStatus = new System.Windows.Forms.ToolStripLabel();
            this.tbtnExit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnRun,
            this.toolStripSeparator1,
            this.tbtnOptions,
            this.tlblStatus,
            this.tbtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnRun
            // 
            this.tbtnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnRun.Image = ((System.Drawing.Image)(resources.GetObject("tbtnRun.Image")));
            this.tbtnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnRun.Name = "tbtnRun";
            this.tbtnRun.Size = new System.Drawing.Size(23, 22);
            this.tbtnRun.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnOptions
            // 
            this.tbtnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnOptions.Image = global::YumaPos.Tests.Load.Client.Properties.Resources.options;
            this.tbtnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOptions.Name = "tbtnOptions";
            this.tbtnOptions.Size = new System.Drawing.Size(23, 22);
            this.tbtnOptions.Text = "Options";
            this.tbtnOptions.Click += new System.EventHandler(this.tbtnOptions_Click);
            // 
            // tlblStatus
            // 
            this.tlblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlblStatus.Name = "tlblStatus";
            this.tlblStatus.Size = new System.Drawing.Size(78, 22);
            this.tlblStatus.Text = "Connecting...";
            // 
            // tbtnExit
            // 
            this.tbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnExit.Image = global::YumaPos.Tests.Load.Client.Properties.Resources.power_icon2;
            this.tbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExit.Name = "tbtnExit";
            this.tbtnExit.Size = new System.Drawing.Size(23, 22);
            this.tbtnExit.Text = "Exit";
            this.tbtnExit.Click += new System.EventHandler(this.tbtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 425);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnOptions;
        private System.Windows.Forms.ToolStripLabel tlblStatus;
        private System.Windows.Forms.ToolStripButton tbtnExit;
        private System.Windows.Forms.FlowLayoutPanel panel1;
    }
}