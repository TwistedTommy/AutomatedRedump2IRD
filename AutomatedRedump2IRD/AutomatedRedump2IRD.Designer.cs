namespace AutomatedRedump2IRD
{
    partial class AutomatedRedump2IRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomatedRedump2IRD));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiAutomatedRedump2IRD = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuildIRDs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbBuildIRDs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSaveLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbViewLog = new System.Windows.Forms.ToolStripButton();
            this.tsbViewOptions = new System.Windows.Forms.ToolStripButton();
            this.tsbViewHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbViewLicense = new System.Windows.Forms.ToolStripButton();
            this.tsbViewToolbar = new System.Windows.Forms.ToolStripButton();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsbCancel = new System.Windows.Forms.ToolStripSplitButton();
            this.tsslStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSnap = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbTaskProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tspbOverallProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.tcOptions = new System.Windows.Forms.TabControl();
            this.tabPaths = new System.Windows.Forms.TabPage();
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.lblPathTempExtractionDir = new System.Windows.Forms.Label();
            this.txtPathTempExtractionDir = new System.Windows.Forms.TextBox();
            this.lblPathRedumpPS3IRDsDir = new System.Windows.Forms.Label();
            this.txtPathRedumpPS3IRDsDir = new System.Windows.Forms.TextBox();
            this.txtPathRedumpPS3ROMsDir = new System.Windows.Forms.TextBox();
            this.lblPathRedumpPS3ROMsDir = new System.Windows.Forms.Label();
            this.lblPathRedumpSQLiteDB = new System.Windows.Forms.Label();
            this.txtPathRedumpSQLiteDB = new System.Windows.Forms.TextBox();
            this.gbPathsInfo = new System.Windows.Forms.GroupBox();
            this.lblPathsInfo2 = new System.Windows.Forms.Label();
            this.lblPathsInfo1 = new System.Windows.Forms.Label();
            this.tabPreferences = new System.Windows.Forms.TabPage();
            this.gbPreferences = new System.Windows.Forms.GroupBox();
            this.lblOutputName = new System.Windows.Forms.Label();
            this.lblInputName = new System.Windows.Forms.Label();
            this.cbOutputName = new System.Windows.Forms.ComboBox();
            this.cbInputName = new System.Windows.Forms.ComboBox();
            this.chkSkipExistingIRDs = new System.Windows.Forms.CheckBox();
            this.tabTUID = new System.Windows.Forms.TabPage();
            this.gbTUID = new System.Windows.Forms.GroupBox();
            this.chkSendIRDsToTheUltimateIRDDatabase = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.rtbHelp = new System.Windows.Forms.RichTextBox();
            this.tabLicense = new System.Windows.Forms.TabPage();
            this.rtbLicense = new System.Windows.Forms.RichTextBox();
            this.bgwBuildIRDs = new System.ComponentModel.BackgroundWorker();
            this.bgwStartupTasks = new System.ComponentModel.BackgroundWorker();
            this.gbTUIDInfo = new System.Windows.Forms.GroupBox();
            this.lblTUIDInfo = new System.Windows.Forms.Label();
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tcOptions.SuspendLayout();
            this.tabPaths.SuspendLayout();
            this.gbPaths.SuspendLayout();
            this.gbPathsInfo.SuspendLayout();
            this.tabPreferences.SuspendLayout();
            this.gbPreferences.SuspendLayout();
            this.tabTUID.SuspendLayout();
            this.gbTUID.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.tabLicense.SuspendLayout();
            this.gbTUIDInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAutomatedRedump2IRD,
            this.tsmiView});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(644, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMain";
            // 
            // tsmiAutomatedRedump2IRD
            // 
            this.tsmiAutomatedRedump2IRD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuildIRDs,
            this.tsmiSaveLog,
            this.tsmiExit});
            this.tsmiAutomatedRedump2IRD.Name = "tsmiAutomatedRedump2IRD";
            this.tsmiAutomatedRedump2IRD.Size = new System.Drawing.Size(157, 20);
            this.tsmiAutomatedRedump2IRD.Text = "Automated Redump 2 IRD";
            // 
            // tsmiBuildIRDs
            // 
            this.tsmiBuildIRDs.Enabled = false;
            this.tsmiBuildIRDs.Image = global::AutomatedRedump2IRD.Properties.Resources.BuildIRDs_32x32;
            this.tsmiBuildIRDs.Name = "tsmiBuildIRDs";
            this.tsmiBuildIRDs.Size = new System.Drawing.Size(127, 22);
            this.tsmiBuildIRDs.Text = "Build IRDs";
            this.tsmiBuildIRDs.Click += new System.EventHandler(this.BuildIRDs_Click);
            // 
            // tsmiSaveLog
            // 
            this.tsmiSaveLog.Enabled = false;
            this.tsmiSaveLog.Image = global::AutomatedRedump2IRD.Properties.Resources.SaveLog_32x32;
            this.tsmiSaveLog.Name = "tsmiSaveLog";
            this.tsmiSaveLog.Size = new System.Drawing.Size(127, 22);
            this.tsmiSaveLog.Text = "Save Log";
            this.tsmiSaveLog.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = global::AutomatedRedump2IRD.Properties.Resources.Exit_32x32;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(127, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewLog,
            this.tsmiViewOptions,
            this.tsmiViewHelp,
            this.tsmiViewLicense,
            this.tsmiViewToolbar});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(44, 20);
            this.tsmiView.Text = "View";
            // 
            // tsmiViewLog
            // 
            this.tsmiViewLog.Checked = true;
            this.tsmiViewLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiViewLog.Name = "tsmiViewLog";
            this.tsmiViewLog.Size = new System.Drawing.Size(144, 22);
            this.tsmiViewLog.Text = "View Log";
            this.tsmiViewLog.Click += new System.EventHandler(this.ViewLog_Click);
            // 
            // tsmiViewOptions
            // 
            this.tsmiViewOptions.Checked = true;
            this.tsmiViewOptions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiViewOptions.Name = "tsmiViewOptions";
            this.tsmiViewOptions.Size = new System.Drawing.Size(144, 22);
            this.tsmiViewOptions.Text = "View Options";
            this.tsmiViewOptions.Click += new System.EventHandler(this.ViewOptions_Click);
            // 
            // tsmiViewHelp
            // 
            this.tsmiViewHelp.Name = "tsmiViewHelp";
            this.tsmiViewHelp.Size = new System.Drawing.Size(144, 22);
            this.tsmiViewHelp.Text = "View Help";
            this.tsmiViewHelp.Click += new System.EventHandler(this.ViewHelp_Click);
            // 
            // tsmiViewLicense
            // 
            this.tsmiViewLicense.Name = "tsmiViewLicense";
            this.tsmiViewLicense.Size = new System.Drawing.Size(144, 22);
            this.tsmiViewLicense.Text = "View License";
            this.tsmiViewLicense.Click += new System.EventHandler(this.ViewLicense_Click);
            // 
            // tsmiViewToolbar
            // 
            this.tsmiViewToolbar.Checked = true;
            this.tsmiViewToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiViewToolbar.Name = "tsmiViewToolbar";
            this.tsmiViewToolbar.Size = new System.Drawing.Size(144, 22);
            this.tsmiViewToolbar.Text = "View Toolbar";
            this.tsmiViewToolbar.Click += new System.EventHandler(this.ViewToolbar_Click);
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBuildIRDs,
            this.toolStripSeparator1,
            this.tsbSaveLog,
            this.toolStripSeparator2,
            this.tsbViewLog,
            this.tsbViewOptions,
            this.tsbViewHelp,
            this.tsbViewLicense,
            this.tsbViewToolbar});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(644, 39);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "tsMain";
            // 
            // tsbBuildIRDs
            // 
            this.tsbBuildIRDs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuildIRDs.Enabled = false;
            this.tsbBuildIRDs.Image = global::AutomatedRedump2IRD.Properties.Resources.BuildIRDs_32x32;
            this.tsbBuildIRDs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuildIRDs.Name = "tsbBuildIRDs";
            this.tsbBuildIRDs.Size = new System.Drawing.Size(36, 36);
            this.tsbBuildIRDs.Text = "Build IRDs";
            this.tsbBuildIRDs.Click += new System.EventHandler(this.BuildIRDs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbSaveLog
            // 
            this.tsbSaveLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveLog.Enabled = false;
            this.tsbSaveLog.Image = global::AutomatedRedump2IRD.Properties.Resources.SaveLog_32x32;
            this.tsbSaveLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveLog.Name = "tsbSaveLog";
            this.tsbSaveLog.Size = new System.Drawing.Size(36, 36);
            this.tsbSaveLog.Text = "Save Log";
            this.tsbSaveLog.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbViewLog
            // 
            this.tsbViewLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewLog.Image = global::AutomatedRedump2IRD.Properties.Resources.Log_32x32;
            this.tsbViewLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewLog.Name = "tsbViewLog";
            this.tsbViewLog.Size = new System.Drawing.Size(36, 36);
            this.tsbViewLog.Text = "View Log";
            this.tsbViewLog.Click += new System.EventHandler(this.ViewLog_Click);
            // 
            // tsbViewOptions
            // 
            this.tsbViewOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewOptions.Image = global::AutomatedRedump2IRD.Properties.Resources.Options_32x32;
            this.tsbViewOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewOptions.Name = "tsbViewOptions";
            this.tsbViewOptions.Size = new System.Drawing.Size(36, 36);
            this.tsbViewOptions.Text = "View Options";
            this.tsbViewOptions.Click += new System.EventHandler(this.ViewOptions_Click);
            // 
            // tsbViewHelp
            // 
            this.tsbViewHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewHelp.Image = global::AutomatedRedump2IRD.Properties.Resources.Help_32x32;
            this.tsbViewHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewHelp.Name = "tsbViewHelp";
            this.tsbViewHelp.Size = new System.Drawing.Size(36, 36);
            this.tsbViewHelp.Text = "View Help";
            this.tsbViewHelp.Click += new System.EventHandler(this.ViewHelp_Click);
            // 
            // tsbViewLicense
            // 
            this.tsbViewLicense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewLicense.Image = global::AutomatedRedump2IRD.Properties.Resources.License_32x32;
            this.tsbViewLicense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewLicense.Name = "tsbViewLicense";
            this.tsbViewLicense.Size = new System.Drawing.Size(36, 36);
            this.tsbViewLicense.Text = "View License";
            this.tsbViewLicense.Click += new System.EventHandler(this.ViewLicense_Click);
            // 
            // tsbViewToolbar
            // 
            this.tsbViewToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewToolbar.Image = global::AutomatedRedump2IRD.Properties.Resources.Toolbar_32x32;
            this.tsbViewToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbViewToolbar.Name = "tsbViewToolbar";
            this.tsbViewToolbar.Size = new System.Drawing.Size(36, 36);
            this.tsbViewToolbar.Text = "View Toolbar";
            this.tsbViewToolbar.Click += new System.EventHandler(this.ViewToolbar_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCancel,
            this.tsslStatusMessage,
            this.tsslSnap,
            this.tspbTaskProgress,
            this.tspbOverallProgress});
            this.ssMain.Location = new System.Drawing.Point(0, 359);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(644, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "ssMain";
            // 
            // tsbCancel
            // 
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancel.DropDownButtonWidth = 0;
            this.tsbCancel.Enabled = false;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(21, 20);
            this.tsbCancel.Text = "Cancel";
            this.tsbCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // tsslStatusMessage
            // 
            this.tsslStatusMessage.Name = "tsslStatusMessage";
            this.tsslStatusMessage.Size = new System.Drawing.Size(152, 17);
            this.tsslStatusMessage.Text = "Performing Startup Tasks ...";
            // 
            // tsslSnap
            // 
            this.tsslSnap.Name = "tsslSnap";
            this.tsslSnap.Size = new System.Drawing.Size(52, 17);
            this.tsslSnap.Spring = true;
            // 
            // tspbTaskProgress
            // 
            this.tspbTaskProgress.Name = "tspbTaskProgress";
            this.tspbTaskProgress.Size = new System.Drawing.Size(200, 16);
            // 
            // tspbOverallProgress
            // 
            this.tspbOverallProgress.Name = "tspbOverallProgress";
            this.tspbOverallProgress.Size = new System.Drawing.Size(200, 16);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabLog);
            this.tcMain.Controls.Add(this.tabOptions);
            this.tcMain.Controls.Add(this.tabHelp);
            this.tcMain.Controls.Add(this.tabLicense);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 63);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(644, 296);
            this.tcMain.TabIndex = 3;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.rtbLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(636, 270);
            this.tabLog.TabIndex = 0;
            this.tabLog.Text = " Log ";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(6, 6);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(624, 258);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tcOptions);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(636, 270);
            this.tabOptions.TabIndex = 1;
            this.tabOptions.Text = " Options ";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // tcOptions
            // 
            this.tcOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcOptions.Controls.Add(this.tabPaths);
            this.tcOptions.Controls.Add(this.tabPreferences);
            this.tcOptions.Controls.Add(this.tabTUID);
            this.tcOptions.Location = new System.Drawing.Point(6, 6);
            this.tcOptions.Name = "tcOptions";
            this.tcOptions.SelectedIndex = 0;
            this.tcOptions.Size = new System.Drawing.Size(624, 258);
            this.tcOptions.TabIndex = 3;
            // 
            // tabPaths
            // 
            this.tabPaths.Controls.Add(this.gbPaths);
            this.tabPaths.Controls.Add(this.gbPathsInfo);
            this.tabPaths.Location = new System.Drawing.Point(4, 22);
            this.tabPaths.Name = "tabPaths";
            this.tabPaths.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaths.Size = new System.Drawing.Size(616, 232);
            this.tabPaths.TabIndex = 0;
            this.tabPaths.Text = " Paths ";
            this.tabPaths.UseVisualStyleBackColor = true;
            // 
            // gbPaths
            // 
            this.gbPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPaths.Controls.Add(this.lblPathTempExtractionDir);
            this.gbPaths.Controls.Add(this.txtPathTempExtractionDir);
            this.gbPaths.Controls.Add(this.lblPathRedumpPS3IRDsDir);
            this.gbPaths.Controls.Add(this.txtPathRedumpPS3IRDsDir);
            this.gbPaths.Controls.Add(this.txtPathRedumpPS3ROMsDir);
            this.gbPaths.Controls.Add(this.lblPathRedumpPS3ROMsDir);
            this.gbPaths.Controls.Add(this.lblPathRedumpSQLiteDB);
            this.gbPaths.Controls.Add(this.txtPathRedumpSQLiteDB);
            this.gbPaths.Location = new System.Drawing.Point(6, 6);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Size = new System.Drawing.Size(604, 123);
            this.gbPaths.TabIndex = 0;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "Paths";
            // 
            // lblPathTempExtractionDir
            // 
            this.lblPathTempExtractionDir.AutoSize = true;
            this.lblPathTempExtractionDir.Location = new System.Drawing.Point(6, 100);
            this.lblPathTempExtractionDir.Name = "lblPathTempExtractionDir";
            this.lblPathTempExtractionDir.Size = new System.Drawing.Size(106, 13);
            this.lblPathTempExtractionDir.TabIndex = 10;
            this.lblPathTempExtractionDir.Text = "Temp Extraction Dir: ";
            // 
            // txtPathTempExtractionDir
            // 
            this.txtPathTempExtractionDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathTempExtractionDir.Enabled = false;
            this.txtPathTempExtractionDir.Location = new System.Drawing.Point(137, 97);
            this.txtPathTempExtractionDir.Name = "txtPathTempExtractionDir";
            this.txtPathTempExtractionDir.ReadOnly = true;
            this.txtPathTempExtractionDir.Size = new System.Drawing.Size(461, 20);
            this.txtPathTempExtractionDir.TabIndex = 9;
            this.txtPathTempExtractionDir.Click += new System.EventHandler(this.PathTempExtractionDir_Click);
            // 
            // lblPathRedumpPS3IRDsDir
            // 
            this.lblPathRedumpPS3IRDsDir.AutoSize = true;
            this.lblPathRedumpPS3IRDsDir.Location = new System.Drawing.Point(6, 74);
            this.lblPathRedumpPS3IRDsDir.Name = "lblPathRedumpPS3IRDsDir";
            this.lblPathRedumpPS3IRDsDir.Size = new System.Drawing.Size(119, 13);
            this.lblPathRedumpPS3IRDsDir.TabIndex = 8;
            this.lblPathRedumpPS3IRDsDir.Text = "Redump PS3 IRDs Dir: ";
            // 
            // txtPathRedumpPS3IRDsDir
            // 
            this.txtPathRedumpPS3IRDsDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathRedumpPS3IRDsDir.Enabled = false;
            this.txtPathRedumpPS3IRDsDir.Location = new System.Drawing.Point(137, 71);
            this.txtPathRedumpPS3IRDsDir.Name = "txtPathRedumpPS3IRDsDir";
            this.txtPathRedumpPS3IRDsDir.ReadOnly = true;
            this.txtPathRedumpPS3IRDsDir.Size = new System.Drawing.Size(461, 20);
            this.txtPathRedumpPS3IRDsDir.TabIndex = 7;
            this.txtPathRedumpPS3IRDsDir.Click += new System.EventHandler(this.PathRedumpPS3IRDsDir_Click);
            // 
            // txtPathRedumpPS3ROMsDir
            // 
            this.txtPathRedumpPS3ROMsDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathRedumpPS3ROMsDir.Enabled = false;
            this.txtPathRedumpPS3ROMsDir.Location = new System.Drawing.Point(137, 45);
            this.txtPathRedumpPS3ROMsDir.Name = "txtPathRedumpPS3ROMsDir";
            this.txtPathRedumpPS3ROMsDir.ReadOnly = true;
            this.txtPathRedumpPS3ROMsDir.Size = new System.Drawing.Size(461, 20);
            this.txtPathRedumpPS3ROMsDir.TabIndex = 6;
            this.txtPathRedumpPS3ROMsDir.Click += new System.EventHandler(this.PathRedumpPS3ROMsDir_Click);
            // 
            // lblPathRedumpPS3ROMsDir
            // 
            this.lblPathRedumpPS3ROMsDir.AutoSize = true;
            this.lblPathRedumpPS3ROMsDir.Location = new System.Drawing.Point(6, 48);
            this.lblPathRedumpPS3ROMsDir.Name = "lblPathRedumpPS3ROMsDir";
            this.lblPathRedumpPS3ROMsDir.Size = new System.Drawing.Size(125, 13);
            this.lblPathRedumpPS3ROMsDir.TabIndex = 5;
            this.lblPathRedumpPS3ROMsDir.Text = "Redump PS3 ROMs Dir: ";
            // 
            // lblPathRedumpSQLiteDB
            // 
            this.lblPathRedumpSQLiteDB.AutoSize = true;
            this.lblPathRedumpSQLiteDB.Location = new System.Drawing.Point(6, 22);
            this.lblPathRedumpSQLiteDB.Name = "lblPathRedumpSQLiteDB";
            this.lblPathRedumpSQLiteDB.Size = new System.Drawing.Size(106, 13);
            this.lblPathRedumpSQLiteDB.TabIndex = 4;
            this.lblPathRedumpSQLiteDB.Text = "Redump SQLite DB: ";
            // 
            // txtPathRedumpSQLiteDB
            // 
            this.txtPathRedumpSQLiteDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathRedumpSQLiteDB.Enabled = false;
            this.txtPathRedumpSQLiteDB.Location = new System.Drawing.Point(137, 19);
            this.txtPathRedumpSQLiteDB.Name = "txtPathRedumpSQLiteDB";
            this.txtPathRedumpSQLiteDB.ReadOnly = true;
            this.txtPathRedumpSQLiteDB.Size = new System.Drawing.Size(461, 20);
            this.txtPathRedumpSQLiteDB.TabIndex = 1;
            this.txtPathRedumpSQLiteDB.Click += new System.EventHandler(this.PathRedumpSQLiteDB_Click);
            // 
            // gbPathsInfo
            // 
            this.gbPathsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPathsInfo.Controls.Add(this.lblPathsInfo2);
            this.gbPathsInfo.Controls.Add(this.lblPathsInfo1);
            this.gbPathsInfo.Location = new System.Drawing.Point(6, 135);
            this.gbPathsInfo.Name = "gbPathsInfo";
            this.gbPathsInfo.Size = new System.Drawing.Size(604, 64);
            this.gbPathsInfo.TabIndex = 2;
            this.gbPathsInfo.TabStop = false;
            this.gbPathsInfo.Text = "Paths Info";
            // 
            // lblPathsInfo2
            // 
            this.lblPathsInfo2.AutoSize = true;
            this.lblPathsInfo2.Location = new System.Drawing.Point(6, 41);
            this.lblPathsInfo2.Name = "lblPathsInfo2";
            this.lblPathsInfo2.Size = new System.Drawing.Size(367, 13);
            this.lblPathsInfo2.TabIndex = 1;
            this.lblPathsInfo2.Text = "ROMs in the Redump PS3 ROMs Dir will  not be moved, modified, or deleted";
            // 
            // lblPathsInfo1
            // 
            this.lblPathsInfo1.AutoSize = true;
            this.lblPathsInfo1.Location = new System.Drawing.Point(6, 22);
            this.lblPathsInfo1.Name = "lblPathsInfo1";
            this.lblPathsInfo1.Size = new System.Drawing.Size(482, 13);
            this.lblPathsInfo1.TabIndex = 0;
            this.lblPathsInfo1.Text = "The Temp Extraction Path must have at least enough freee space for the largest IS" +
    "O being extracted";
            // 
            // tabPreferences
            // 
            this.tabPreferences.Controls.Add(this.gbPreferences);
            this.tabPreferences.Location = new System.Drawing.Point(4, 22);
            this.tabPreferences.Name = "tabPreferences";
            this.tabPreferences.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreferences.Size = new System.Drawing.Size(616, 232);
            this.tabPreferences.TabIndex = 1;
            this.tabPreferences.Text = " Preferences ";
            this.tabPreferences.UseVisualStyleBackColor = true;
            // 
            // gbPreferences
            // 
            this.gbPreferences.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPreferences.Controls.Add(this.lblOutputName);
            this.gbPreferences.Controls.Add(this.lblInputName);
            this.gbPreferences.Controls.Add(this.cbOutputName);
            this.gbPreferences.Controls.Add(this.cbInputName);
            this.gbPreferences.Controls.Add(this.chkSkipExistingIRDs);
            this.gbPreferences.Location = new System.Drawing.Point(6, 6);
            this.gbPreferences.Name = "gbPreferences";
            this.gbPreferences.Size = new System.Drawing.Size(604, 96);
            this.gbPreferences.TabIndex = 1;
            this.gbPreferences.TabStop = false;
            this.gbPreferences.Text = "Preferences";
            // 
            // lblOutputName
            // 
            this.lblOutputName.AutoSize = true;
            this.lblOutputName.Location = new System.Drawing.Point(6, 72);
            this.lblOutputName.Name = "lblOutputName";
            this.lblOutputName.Size = new System.Drawing.Size(147, 13);
            this.lblOutputName.TabIndex = 5;
            this.lblOutputName.Text = "Output Filenames (IRD Files): ";
            // 
            // lblInputName
            // 
            this.lblInputName.AutoSize = true;
            this.lblInputName.Location = new System.Drawing.Point(6, 45);
            this.lblInputName.Name = "lblInputName";
            this.lblInputName.Size = new System.Drawing.Size(177, 13);
            this.lblInputName.TabIndex = 4;
            this.lblInputName.Text = "Input Filenames (ISO and Zip Files): ";
            // 
            // cbOutputName
            // 
            this.cbOutputName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOutputName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputName.FormattingEnabled = true;
            this.cbOutputName.Items.AddRange(new object[] {
            "MD5"});
            this.cbOutputName.Location = new System.Drawing.Point(189, 69);
            this.cbOutputName.Name = "cbOutputName";
            this.cbOutputName.Size = new System.Drawing.Size(409, 21);
            this.cbOutputName.TabIndex = 3;
            // 
            // cbInputName
            // 
            this.cbInputName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInputName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInputName.FormattingEnabled = true;
            this.cbInputName.Items.AddRange(new object[] {
            "Title"});
            this.cbInputName.Location = new System.Drawing.Point(189, 42);
            this.cbInputName.Name = "cbInputName";
            this.cbInputName.Size = new System.Drawing.Size(409, 21);
            this.cbInputName.TabIndex = 2;
            // 
            // chkSkipExistingIRDs
            // 
            this.chkSkipExistingIRDs.AutoSize = true;
            this.chkSkipExistingIRDs.Checked = true;
            this.chkSkipExistingIRDs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipExistingIRDs.Enabled = false;
            this.chkSkipExistingIRDs.Location = new System.Drawing.Point(6, 19);
            this.chkSkipExistingIRDs.Name = "chkSkipExistingIRDs";
            this.chkSkipExistingIRDs.Size = new System.Drawing.Size(113, 17);
            this.chkSkipExistingIRDs.TabIndex = 1;
            this.chkSkipExistingIRDs.Text = "Skip Existing IRDs";
            this.chkSkipExistingIRDs.UseVisualStyleBackColor = true;
            // 
            // tabTUID
            // 
            this.tabTUID.Controls.Add(this.gbTUIDInfo);
            this.tabTUID.Controls.Add(this.gbTUID);
            this.tabTUID.Location = new System.Drawing.Point(4, 22);
            this.tabTUID.Name = "tabTUID";
            this.tabTUID.Padding = new System.Windows.Forms.Padding(3);
            this.tabTUID.Size = new System.Drawing.Size(616, 232);
            this.tabTUID.TabIndex = 2;
            this.tabTUID.Text = " TUID ";
            this.tabTUID.UseVisualStyleBackColor = true;
            // 
            // gbTUID
            // 
            this.gbTUID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTUID.Controls.Add(this.chkSendIRDsToTheUltimateIRDDatabase);
            this.gbTUID.Controls.Add(this.txtPassword);
            this.gbTUID.Controls.Add(this.txtUsername);
            this.gbTUID.Controls.Add(this.lblPassword);
            this.gbTUID.Controls.Add(this.lblUsername);
            this.gbTUID.Location = new System.Drawing.Point(6, 6);
            this.gbTUID.Name = "gbTUID";
            this.gbTUID.Size = new System.Drawing.Size(604, 92);
            this.gbTUID.TabIndex = 3;
            this.gbTUID.TabStop = false;
            this.gbTUID.Text = "The Ultimate IRD Database";
            // 
            // chkSendIRDsToTheUltimateIRDDatabase
            // 
            this.chkSendIRDsToTheUltimateIRDDatabase.AutoSize = true;
            this.chkSendIRDsToTheUltimateIRDDatabase.Enabled = false;
            this.chkSendIRDsToTheUltimateIRDDatabase.Location = new System.Drawing.Point(6, 19);
            this.chkSendIRDsToTheUltimateIRDDatabase.Name = "chkSendIRDsToTheUltimateIRDDatabase";
            this.chkSendIRDsToTheUltimateIRDDatabase.Size = new System.Drawing.Size(293, 17);
            this.chkSendIRDsToTheUltimateIRDDatabase.TabIndex = 2;
            this.chkSendIRDsToTheUltimateIRDDatabase.Text = "Send IRDs To The Ultimate IRD Database After Building";
            this.chkSendIRDsToTheUltimateIRDDatabase.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(73, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(525, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(73, 42);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(525, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 71);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 45);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username: ";
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.rtbHelp);
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelp.Size = new System.Drawing.Size(636, 270);
            this.tabHelp.TabIndex = 2;
            this.tabHelp.Text = " Help ";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // rtbHelp
            // 
            this.rtbHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbHelp.Location = new System.Drawing.Point(6, 6);
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.ReadOnly = true;
            this.rtbHelp.Size = new System.Drawing.Size(624, 258);
            this.rtbHelp.TabIndex = 0;
            this.rtbHelp.Text = "";
            // 
            // tabLicense
            // 
            this.tabLicense.Controls.Add(this.rtbLicense);
            this.tabLicense.Location = new System.Drawing.Point(4, 22);
            this.tabLicense.Name = "tabLicense";
            this.tabLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tabLicense.Size = new System.Drawing.Size(636, 270);
            this.tabLicense.TabIndex = 3;
            this.tabLicense.Text = " License ";
            this.tabLicense.UseVisualStyleBackColor = true;
            // 
            // rtbLicense
            // 
            this.rtbLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLicense.Location = new System.Drawing.Point(6, 6);
            this.rtbLicense.Name = "rtbLicense";
            this.rtbLicense.ReadOnly = true;
            this.rtbLicense.Size = new System.Drawing.Size(624, 258);
            this.rtbLicense.TabIndex = 0;
            this.rtbLicense.Text = "";
            // 
            // bgwBuildIRDs
            // 
            this.bgwBuildIRDs.WorkerReportsProgress = true;
            this.bgwBuildIRDs.WorkerSupportsCancellation = true;
            this.bgwBuildIRDs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BuildIRDs_DoWork);
            this.bgwBuildIRDs.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BuildIRDs_ProgressChanged);
            this.bgwBuildIRDs.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BuildIRDs_RunWorkerCompleted);
            // 
            // bgwStartupTasks
            // 
            this.bgwStartupTasks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StartupTasks_DoWork);
            this.bgwStartupTasks.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.StartupTasks_RunWorkerCompleted);
            // 
            // gbTUIDInfo
            // 
            this.gbTUIDInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTUIDInfo.Controls.Add(this.lblTUIDInfo);
            this.gbTUIDInfo.Location = new System.Drawing.Point(6, 104);
            this.gbTUIDInfo.Name = "gbTUIDInfo";
            this.gbTUIDInfo.Size = new System.Drawing.Size(604, 32);
            this.gbTUIDInfo.TabIndex = 4;
            this.gbTUIDInfo.TabStop = false;
            this.gbTUIDInfo.Text = "The Ultimate IRD Database Info";
            // 
            // lblTUIDInfo
            // 
            this.lblTUIDInfo.AutoSize = true;
            this.lblTUIDInfo.Location = new System.Drawing.Point(6, 16);
            this.lblTUIDInfo.Name = "lblTUIDInfo";
            this.lblTUIDInfo.Size = new System.Drawing.Size(173, 13);
            this.lblTUIDInfo.TabIndex = 0;
            this.lblTUIDInfo.Text = "Passwords are stored unencrypted.";
            // 
            // AutomatedRedump2IRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 381);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "AutomatedRedump2IRD";
            this.Text = "Automated Redump 2 IRD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.tcOptions.ResumeLayout(false);
            this.tabPaths.ResumeLayout(false);
            this.gbPaths.ResumeLayout(false);
            this.gbPaths.PerformLayout();
            this.gbPathsInfo.ResumeLayout(false);
            this.gbPathsInfo.PerformLayout();
            this.tabPreferences.ResumeLayout(false);
            this.gbPreferences.ResumeLayout(false);
            this.gbPreferences.PerformLayout();
            this.tabTUID.ResumeLayout(false);
            this.gbTUID.ResumeLayout(false);
            this.gbTUID.PerformLayout();
            this.tabHelp.ResumeLayout(false);
            this.tabLicense.ResumeLayout(false);
            this.gbTUIDInfo.ResumeLayout(false);
            this.gbTUIDInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutomatedRedump2IRD;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuildIRDs;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripButton tsbBuildIRDs;
        private System.Windows.Forms.ToolStripSplitButton tsbCancel;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusMessage;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.ToolStripStatusLabel tsslSnap;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.GroupBox gbPreferences;
        private System.Windows.Forms.GroupBox gbPaths;
        private System.Windows.Forms.Label lblPathRedumpSQLiteDB;
        private System.Windows.Forms.TextBox txtPathRedumpSQLiteDB;
        private System.Windows.Forms.TextBox txtPathRedumpPS3ROMsDir;
        private System.Windows.Forms.Label lblPathRedumpPS3ROMsDir;
        private System.Windows.Forms.Label lblPathRedumpPS3IRDsDir;
        private System.Windows.Forms.TextBox txtPathRedumpPS3IRDsDir;
        private System.Windows.Forms.Label lblPathTempExtractionDir;
        private System.Windows.Forms.TextBox txtPathTempExtractionDir;
        private System.Windows.Forms.ToolStripProgressBar tspbTaskProgress;
        private System.Windows.Forms.ToolStripProgressBar tspbOverallProgress;
        private System.ComponentModel.BackgroundWorker bgwBuildIRDs;
        private System.Windows.Forms.GroupBox gbPathsInfo;
        private System.Windows.Forms.Label lblPathsInfo1;
        private System.Windows.Forms.CheckBox chkSkipExistingIRDs;
        private System.Windows.Forms.Label lblPathsInfo2;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.TabPage tabLicense;
        private System.Windows.Forms.RichTextBox rtbHelp;
        private System.Windows.Forms.RichTextBox rtbLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSaveLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbViewLog;
        private System.Windows.Forms.ToolStripButton tsbViewOptions;
        private System.Windows.Forms.ToolStripButton tsbViewHelp;
        private System.Windows.Forms.ToolStripButton tsbViewLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewToolbar;
        private System.Windows.Forms.ToolStripButton tsbViewToolbar;
        private System.Windows.Forms.TabControl tcOptions;
        private System.Windows.Forms.TabPage tabPaths;
        private System.Windows.Forms.TabPage tabPreferences;
        private System.ComponentModel.BackgroundWorker bgwStartupTasks;
        private System.Windows.Forms.Label lblOutputName;
        private System.Windows.Forms.Label lblInputName;
        private System.Windows.Forms.ComboBox cbOutputName;
        private System.Windows.Forms.ComboBox cbInputName;
        private System.Windows.Forms.TabPage tabTUID;
        private System.Windows.Forms.GroupBox gbTUID;
        private System.Windows.Forms.CheckBox chkSendIRDsToTheUltimateIRDDatabase;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox gbTUIDInfo;
        private System.Windows.Forms.Label lblTUIDInfo;
    }
}

