namespace YumaPos.Tests.Load.Client.Forms
{
    partial class JobControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtScenarios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblJobId = new System.Windows.Forms.Label();
            this.lblTerminalCount = new System.Windows.Forms.Label();
            this.lblTenantAlias = new System.Windows.Forms.Label();
            this.lblEstimated = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtScenarios, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblJobId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTerminalCount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTenantAlias, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEstimated, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 88);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtScenarios
            // 
            this.txtScenarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScenarios.Location = new System.Drawing.Point(192, 3);
            this.txtScenarios.Multiline = true;
            this.txtScenarios.Name = "txtScenarios";
            this.txtScenarios.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.txtScenarios, 4);
            this.txtScenarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScenarios.Size = new System.Drawing.Size(406, 82);
            this.txtScenarios.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Terminals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tenant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estimated";
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Location = new System.Drawing.Point(72, 0);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(10, 13);
            this.lblJobId.TabIndex = 5;
            this.lblJobId.Text = ".";
            // 
            // lblTerminalCount
            // 
            this.lblTerminalCount.AutoSize = true;
            this.lblTerminalCount.Location = new System.Drawing.Point(72, 20);
            this.lblTerminalCount.Name = "lblTerminalCount";
            this.lblTerminalCount.Size = new System.Drawing.Size(10, 13);
            this.lblTerminalCount.TabIndex = 6;
            this.lblTerminalCount.Text = ".";
            // 
            // lblTenantAlias
            // 
            this.lblTenantAlias.AutoSize = true;
            this.lblTenantAlias.Location = new System.Drawing.Point(72, 40);
            this.lblTenantAlias.Name = "lblTenantAlias";
            this.lblTenantAlias.Size = new System.Drawing.Size(10, 13);
            this.lblTenantAlias.TabIndex = 7;
            this.lblTenantAlias.Text = ".";
            // 
            // lblEstimated
            // 
            this.lblEstimated.AutoSize = true;
            this.lblEstimated.Location = new System.Drawing.Point(72, 60);
            this.lblEstimated.Name = "lblEstimated";
            this.lblEstimated.Size = new System.Drawing.Size(10, 13);
            this.lblEstimated.TabIndex = 8;
            this.lblEstimated.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "JobId";
            // 
            // JobControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JobControl";
            this.Size = new System.Drawing.Size(598, 88);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtScenarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.Label lblTerminalCount;
        private System.Windows.Forms.Label lblTenantAlias;
        private System.Windows.Forms.Label lblEstimated;
    }
}
