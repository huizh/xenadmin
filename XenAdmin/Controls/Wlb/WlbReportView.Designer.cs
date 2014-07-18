namespace XenAdmin.Controls.Wlb
{
    partial class WlbReportView
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
            this.components = new System.ComponentModel.Container();
            this.labelHostCombo = new System.Windows.Forms.Label();
            this.hostComboBox = new System.Windows.Forms.ComboBox();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboBoxView = new System.Windows.Forms.ComboBox();
            this.labelShow = new System.Windows.Forms.Label();
            this.panelHosts = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblExported = new System.Windows.Forms.Label();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.panelObjects = new System.Windows.Forms.Panel();
            this.labelObjects = new System.Windows.Forms.Label();
            this.objectComboBox = new System.Windows.Forms.ComboBox();
            this.panelHosts.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.panelObjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHostCombo
            // 
            this.labelHostCombo.AutoSize = true;
            this.labelHostCombo.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelHostCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelHostCombo.Location = new System.Drawing.Point(14, 4);
            this.labelHostCombo.Name = "labelHostCombo";
            this.labelHostCombo.Size = new System.Drawing.Size(33, 13);
            this.labelHostCombo.TabIndex = 4;
            this.labelHostCombo.Text = "&Host:";
            // 
            // hostComboBox
            // 
            this.hostComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hostComboBox.FormattingEnabled = true;
            this.hostComboBox.Location = new System.Drawing.Point(52, 0);
            this.hostComboBox.MaxDropDownItems = 20;
            this.hostComboBox.Name = "hostComboBox";
            this.hostComboBox.Size = new System.Drawing.Size(208, 21);
            this.hostComboBox.TabIndex = 5;
            this.hostComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_DrawItem);
            this.hostComboBox.DropDownClosed += new System.EventHandler(this.comboBox_DropDownClosed);
            this.hostComboBox.Leave += new System.EventHandler(this.comboBox_DropDownClosed);
            // 
            // btnRunReport
            // 
            this.btnRunReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunReport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRunReport.Location = new System.Drawing.Point(3, 3);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(102, 23);
            this.btnRunReport.TabIndex = 8;
            this.btnRunReport.Text = "&Run Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            this.btnRunReport.Click += new System.EventHandler(this.btnRunReport_Click);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEndDate.Location = new System.Drawing.Point(200, 7);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(55, 13);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "&End Date:";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Font = new System.Drawing.Font("Tahoma", 8F);
            this.EndDatePicker.Location = new System.Drawing.Point(261, 4);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(102, 20);
            this.EndDatePicker.TabIndex = 3;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.comboBox_SelectionChanged);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelStartDate.Location = new System.Drawing.Point(7, 7);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(61, 13);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "S&tart Date:";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Font = new System.Drawing.Font("Tahoma", 8F);
            this.StartDatePicker.Location = new System.Drawing.Point(74, 3);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(102, 20);
            this.StartDatePicker.TabIndex = 1;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.comboBox_SelectionChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.reportViewer1.Location = new System.Drawing.Point(0, 53);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(844, 526);
            this.reportViewer1.TabIndex = 6;
            this.reportViewer1.ReportExport += new Microsoft.Reporting.WinForms.ExportEventHandler(this.reportViewer1_ReportExport);
            this.reportViewer1.Back += new Microsoft.Reporting.WinForms.BackEventHandler(this.reportViewer1_Back);
            this.reportViewer1.Drillthrough += new Microsoft.Reporting.WinForms.DrillthroughEventHandler(this.reportViewer1_Drillthrough);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubscribe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubscribe.Location = new System.Drawing.Point(111, 3);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(102, 23);
            this.btnSubscribe.TabIndex = 9;
            this.btnSubscribe.Text = "&Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(219, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboBoxView
            // 
            this.comboBoxView.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxView.FormattingEnabled = true;
            this.comboBoxView.Location = new System.Drawing.Point(54, 0);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(110, 21);
            this.comboBoxView.TabIndex = 7;
            this.comboBoxView.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_DrawItem);
            this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.comboBoxView_SelectedIndexChanged);
            this.comboBoxView.DropDownClosed += new System.EventHandler(this.comboBox_DropDownClosed);
            // 
            // labelShow
            // 
            this.labelShow.Location = new System.Drawing.Point(12, 4);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(37, 13);
            this.labelShow.TabIndex = 6;
            this.labelShow.Text = "Sh&ow:";
            // 
            // panelHosts
            // 
            this.panelHosts.AutoSize = true;
            this.panelHosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelHosts.Controls.Add(this.hostComboBox);
            this.panelHosts.Controls.Add(this.labelHostCombo);
            this.panelHosts.Location = new System.Drawing.Point(3, 3);
            this.panelHosts.Name = "panelHosts";
            this.panelHosts.Size = new System.Drawing.Size(263, 24);
            this.panelHosts.TabIndex = 12;
            // 
            // panelShow
            // 
            this.panelShow.AutoSize = true;
            this.panelShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelShow.Controls.Add(this.labelShow);
            this.panelShow.Controls.Add(this.comboBoxView);
            this.panelShow.Location = new System.Drawing.Point(272, 3);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(167, 24);
            this.panelShow.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panelHosts);
            this.flowLayoutPanel1.Controls.Add(this.panelShow);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(369, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(442, 30);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblExported
            // 
            this.lblExported.AutoSize = true;
            this.lblExported.BackColor = System.Drawing.Color.Khaki;
            this.lblExported.Location = new System.Drawing.Point(-3, 31);
            this.lblExported.Name = "lblExported";
            this.lblExported.Size = new System.Drawing.Size(0, 13);
            this.lblExported.TabIndex = 14;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelButtons.AutoSize = true;
            this.flowLayoutPanelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons.Controls.Add(this.btnClose);
            this.flowLayoutPanelButtons.Controls.Add(this.btnSubscribe);
            this.flowLayoutPanelButtons.Controls.Add(this.btnRunReport);
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(519, 598);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(324, 29);
            this.flowLayoutPanelButtons.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.panelUsers);
            this.flowLayoutPanel2.Controls.Add(this.panelObjects);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(369, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(326, 30);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // panelUsers
            // 
            this.panelUsers.AutoSize = true;
            this.panelUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelUsers.Controls.Add(this.userComboBox);
            this.panelUsers.Controls.Add(this.labelUser);
            this.panelUsers.Location = new System.Drawing.Point(3, 3);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(158, 24);
            this.panelUsers.TabIndex = 12;
            // 
            // userComboBox
            // 
            this.userComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(52, 0);
            this.userComboBox.MaxDropDownItems = 20;
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(103, 21);
            this.userComboBox.TabIndex = 5;
            this.userComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_DrawItem);
            this.userComboBox.DropDownClosed += new System.EventHandler(this.comboBox_DropDownClosed);
            this.userComboBox.TextChanged += new System.EventHandler(this.comboBox_SelectionChanged);
            this.userComboBox.Leave += new System.EventHandler(this.comboBox_DropDownClosed);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUser.Location = new System.Drawing.Point(14, 4);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(33, 13);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "&User:";
            // 
            // panelObjects
            // 
            this.panelObjects.AutoSize = true;
            this.panelObjects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelObjects.Controls.Add(this.labelObjects);
            this.panelObjects.Controls.Add(this.objectComboBox);
            this.panelObjects.Location = new System.Drawing.Point(167, 3);
            this.panelObjects.Name = "panelObjects";
            this.panelObjects.Size = new System.Drawing.Size(156, 24);
            this.panelObjects.TabIndex = 13;
            // 
            // labelObjects
            // 
            this.labelObjects.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelObjects.Location = new System.Drawing.Point(3, 4);
            this.labelObjects.Name = "labelObjects";
            this.labelObjects.Size = new System.Drawing.Size(49, 13);
            this.labelObjects.TabIndex = 6;
            this.labelObjects.Text = "Ob&ject:";
            // 
            // objectComboBox
            // 
            this.objectComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.objectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objectComboBox.FormattingEnabled = true;
            this.objectComboBox.Location = new System.Drawing.Point(58, 0);
            this.objectComboBox.Name = "objectComboBox";
            this.objectComboBox.Size = new System.Drawing.Size(95, 21);
            this.objectComboBox.TabIndex = 7;
            this.objectComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_DrawItem);
            this.objectComboBox.DropDownClosed += new System.EventHandler(this.comboBox_DropDownClosed);
            this.objectComboBox.TextChanged += new System.EventHandler(this.comboBox_SelectionChanged);
            this.objectComboBox.Leave += new System.EventHandler(this.comboBox_DropDownClosed);
            // 
            // WlbReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanelButtons);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblExported);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.StartDatePicker);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WlbReportView";
            this.Size = new System.Drawing.Size(844, 628);
            this.Load += new System.EventHandler(this.ReportView_Load);
            this.panelHosts.ResumeLayout(false);
            this.panelHosts.PerformLayout();
            this.panelShow.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            this.panelObjects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelHostCombo;
        public System.Windows.Forms.ComboBox hostComboBox;
        public System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.Button btnSubscribe;
        public System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboBoxView;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Panel panelHosts;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblExported;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panelUsers;
        public System.Windows.Forms.ComboBox userComboBox;
        public System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panelObjects;
        private System.Windows.Forms.Label labelObjects;
        private System.Windows.Forms.ComboBox objectComboBox;

    }
}
