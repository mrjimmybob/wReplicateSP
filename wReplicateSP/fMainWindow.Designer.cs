namespace wreplicaesp
{
    partial class fMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainForm));
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLoadedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsButtonBar = new System.Windows.Forms.ToolStrip();
            this.tsbReplicate = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbReloadConfiguration = new System.Windows.Forms.ToolStripButton();
            this.tsbClearLoadedText = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.scMainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.tlpConfigurationItemsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lRemoteConfiguration = new System.Windows.Forms.Label();
            this.tlpMainDBObjectPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tbDbObjectText = new System.Windows.Forms.TextBox();
            this.gbOriginData = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpSourceDBControls = new System.Windows.Forms.FlowLayoutPanel();
            this.lServer = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.lUser = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lDatabase = new System.Windows.Forms.Label();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.lObjectType = new System.Windows.Forms.Label();
            this.cbObjectType = new System.Windows.Forms.ComboBox();
            this.lObjectTypeName = new System.Windows.Forms.Label();
            this.cbDatabaseObjects = new System.Windows.Forms.ComboBox();
            this.bLoad = new System.Windows.Forms.Button();
            this.cbOverwrite = new System.Windows.Forms.CheckBox();
            this.cbCreateOnAlter = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bwTransfer = new System.ComponentModel.BackgroundWorker();
            this.msMainMenu.SuspendLayout();
            this.tsButtonBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMainSplitContainer)).BeginInit();
            this.scMainSplitContainer.Panel1.SuspendLayout();
            this.scMainSplitContainer.Panel2.SuspendLayout();
            this.scMainSplitContainer.SuspendLayout();
            this.tlpMainDBObjectPanel.SuspendLayout();
            this.gbOriginData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flpSourceDBControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(1234, 24);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replicateToolStripMenuItem,
            this.reloadConfigurationToolStripMenuItem,
            this.clearLoadedTextToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // replicateToolStripMenuItem
            // 
            this.replicateToolStripMenuItem.Name = "replicateToolStripMenuItem";
            this.replicateToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.replicateToolStripMenuItem.Text = "Replicate";
            // 
            // reloadConfigurationToolStripMenuItem
            // 
            this.reloadConfigurationToolStripMenuItem.Name = "reloadConfigurationToolStripMenuItem";
            this.reloadConfigurationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reloadConfigurationToolStripMenuItem.Text = "Reload Configuration";
            // 
            // clearLoadedTextToolStripMenuItem
            // 
            this.clearLoadedTextToolStripMenuItem.Enabled = false;
            this.clearLoadedTextToolStripMenuItem.Name = "clearLoadedTextToolStripMenuItem";
            this.clearLoadedTextToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.clearLoadedTextToolStripMenuItem.Text = "Clear Loaded Text";
            this.clearLoadedTextToolStripMenuItem.Click += new System.EventHandler(this.clearLoadedTextToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tsButtonBar
            // 
            this.tsButtonBar.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.tsButtonBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReplicate,
            this.tsbCancel,
            this.tsbReloadConfiguration,
            this.tsbClearLoadedText,
            this.tsbExit});
            this.tsButtonBar.Location = new System.Drawing.Point(0, 24);
            this.tsButtonBar.Name = "tsButtonBar";
            this.tsButtonBar.Size = new System.Drawing.Size(1234, 71);
            this.tsButtonBar.TabIndex = 1;
            this.tsButtonBar.Text = "toolStrip1";
            // 
            // tsbReplicate
            // 
            this.tsbReplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReplicate.Enabled = false;
            this.tsbReplicate.Image = global::wReplicateSP.Properties.Resources.replicar;
            this.tsbReplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReplicate.Name = "tsbReplicate";
            this.tsbReplicate.Size = new System.Drawing.Size(68, 68);
            this.tsbReplicate.Text = "toolStripButton1";
            this.tsbReplicate.ToolTipText = "Replicate database object to destination as per configuration";
            this.tsbReplicate.Click += new System.EventHandler(this.tsbReplicate_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancel.Enabled = false;
            this.tsbCancel.Image = global::wReplicateSP.Properties.Resources.stop;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(68, 68);
            this.tsbCancel.Text = "Stop any process in execution";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbReloadConfiguration
            // 
            this.tsbReloadConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReloadConfiguration.Image = global::wReplicateSP.Properties.Resources.reload;
            this.tsbReloadConfiguration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReloadConfiguration.Name = "tsbReloadConfiguration";
            this.tsbReloadConfiguration.Size = new System.Drawing.Size(68, 68);
            this.tsbReloadConfiguration.Text = "toolStripButton1";
            this.tsbReloadConfiguration.ToolTipText = "Reload configuration file";
            this.tsbReloadConfiguration.Click += new System.EventHandler(this.tsbReloadConfiguration_Click);
            // 
            // tsbClearLoadedText
            // 
            this.tsbClearLoadedText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClearLoadedText.Enabled = false;
            this.tsbClearLoadedText.Image = global::wReplicateSP.Properties.Resources.clear;
            this.tsbClearLoadedText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearLoadedText.Name = "tsbClearLoadedText";
            this.tsbClearLoadedText.Size = new System.Drawing.Size(68, 68);
            this.tsbClearLoadedText.Text = "toolStripButton1";
            this.tsbClearLoadedText.ToolTipText = "Clear loaded database object data (stored procedure or fuction)";
            this.tsbClearLoadedText.Click += new System.EventHandler(this.tsbClearLoadedText_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = global::wReplicateSP.Properties.Resources.exit;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(68, 68);
            this.tsbExit.Text = "toolStripButton1";
            this.tsbExit.ToolTipText = "Termitate program and exit to desktop";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // scMainSplitContainer
            // 
            this.scMainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainSplitContainer.Location = new System.Drawing.Point(0, 95);
            this.scMainSplitContainer.Name = "scMainSplitContainer";
            // 
            // scMainSplitContainer.Panel1
            // 
            this.scMainSplitContainer.Panel1.Controls.Add(this.cbSelectAll);
            this.scMainSplitContainer.Panel1.Controls.Add(this.tlpConfigurationItemsPanel);
            this.scMainSplitContainer.Panel1.Controls.Add(this.lRemoteConfiguration);
            // 
            // scMainSplitContainer.Panel2
            // 
            this.scMainSplitContainer.Panel2.Controls.Add(this.tlpMainDBObjectPanel);
            this.scMainSplitContainer.Size = new System.Drawing.Size(1234, 701);
            this.scMainSplitContainer.SplitterDistance = 463;
            this.scMainSplitContainer.TabIndex = 2;
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSelectAll.Checked = true;
            this.cbSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSelectAll.Location = new System.Drawing.Point(371, -4);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.cbSelectAll.Size = new System.Drawing.Size(89, 25);
            this.cbSelectAll.TabIndex = 2;
            this.cbSelectAll.Text = "Select None";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            this.cbSelectAll.CheckedChanged += new System.EventHandler(this.cbSelectAll_CheckedChanged);
            // 
            // tlpConfigurationItemsPanel
            // 
            this.tlpConfigurationItemsPanel.AutoSize = true;
            this.tlpConfigurationItemsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpConfigurationItemsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.tlpConfigurationItemsPanel.ColumnCount = 1;
            this.tlpConfigurationItemsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConfigurationItemsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpConfigurationItemsPanel.Location = new System.Drawing.Point(0, 21);
            this.tlpConfigurationItemsPanel.Name = "tlpConfigurationItemsPanel";
            this.tlpConfigurationItemsPanel.RowCount = 1;
            this.tlpConfigurationItemsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConfigurationItemsPanel.Size = new System.Drawing.Size(463, 0);
            this.tlpConfigurationItemsPanel.TabIndex = 1;
            // 
            // lRemoteConfiguration
            // 
            this.lRemoteConfiguration.AutoSize = true;
            this.lRemoteConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.lRemoteConfiguration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lRemoteConfiguration.Location = new System.Drawing.Point(0, 0);
            this.lRemoteConfiguration.Name = "lRemoteConfiguration";
            this.lRemoteConfiguration.Size = new System.Drawing.Size(180, 21);
            this.lRemoteConfiguration.TabIndex = 0;
            this.lRemoteConfiguration.Text = "Remote Configuration";
            this.lRemoteConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpMainDBObjectPanel
            // 
            this.tlpMainDBObjectPanel.ColumnCount = 1;
            this.tlpMainDBObjectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainDBObjectPanel.Controls.Add(this.tbDbObjectText, 0, 1);
            this.tlpMainDBObjectPanel.Controls.Add(this.gbOriginData, 0, 0);
            this.tlpMainDBObjectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainDBObjectPanel.Location = new System.Drawing.Point(0, 0);
            this.tlpMainDBObjectPanel.Name = "tlpMainDBObjectPanel";
            this.tlpMainDBObjectPanel.RowCount = 2;
            this.tlpMainDBObjectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.10699F));
            this.tlpMainDBObjectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.89301F));
            this.tlpMainDBObjectPanel.Size = new System.Drawing.Size(767, 701);
            this.tlpMainDBObjectPanel.TabIndex = 0;
            // 
            // tbDbObjectText
            // 
            this.tbDbObjectText.AcceptsReturn = true;
            this.tbDbObjectText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDbObjectText.Location = new System.Drawing.Point(3, 179);
            this.tbDbObjectText.Multiline = true;
            this.tbDbObjectText.Name = "tbDbObjectText";
            this.tbDbObjectText.Size = new System.Drawing.Size(761, 519);
            this.tbDbObjectText.TabIndex = 0;
            this.tbDbObjectText.TabStop = false;
            // 
            // gbOriginData
            // 
            this.gbOriginData.Controls.Add(this.panel1);
            this.gbOriginData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOriginData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbOriginData.Location = new System.Drawing.Point(3, 3);
            this.gbOriginData.Name = "gbOriginData";
            this.gbOriginData.Size = new System.Drawing.Size(761, 170);
            this.gbOriginData.TabIndex = 1;
            this.gbOriginData.TabStop = false;
            this.gbOriginData.Text = "Load Source Database Object";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpSourceDBControls);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 142);
            this.panel1.TabIndex = 0;
            // 
            // flpSourceDBControls
            // 
            this.flpSourceDBControls.BackColor = System.Drawing.SystemColors.Control;
            this.flpSourceDBControls.Controls.Add(this.lServer);
            this.flpSourceDBControls.Controls.Add(this.tbServer);
            this.flpSourceDBControls.Controls.Add(this.lUser);
            this.flpSourceDBControls.Controls.Add(this.tbUsername);
            this.flpSourceDBControls.Controls.Add(this.lPassword);
            this.flpSourceDBControls.Controls.Add(this.tbPassword);
            this.flpSourceDBControls.Controls.Add(this.lDatabase);
            this.flpSourceDBControls.Controls.Add(this.cbDatabase);
            this.flpSourceDBControls.Controls.Add(this.lObjectType);
            this.flpSourceDBControls.Controls.Add(this.cbObjectType);
            this.flpSourceDBControls.Controls.Add(this.lObjectTypeName);
            this.flpSourceDBControls.Controls.Add(this.cbDatabaseObjects);
            this.flpSourceDBControls.Controls.Add(this.bLoad);
            this.flpSourceDBControls.Controls.Add(this.cbOverwrite);
            this.flpSourceDBControls.Controls.Add(this.cbCreateOnAlter);
            this.flpSourceDBControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSourceDBControls.Location = new System.Drawing.Point(0, 0);
            this.flpSourceDBControls.Name = "flpSourceDBControls";
            this.flpSourceDBControls.Size = new System.Drawing.Size(755, 142);
            this.flpSourceDBControls.TabIndex = 11;
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Location = new System.Drawing.Point(3, 6);
            this.lServer.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(59, 21);
            this.lServer.TabIndex = 0;
            this.lServer.Text = "Server";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(68, 3);
            this.tbServer.Name = "tbServer";
            this.tbServer.PlaceholderText = "Server name or address";
            this.tbServer.Size = new System.Drawing.Size(137, 29);
            this.tbServer.TabIndex = 1;
            this.tbServer.Text = "ANDROMEDA\\SQLSERVER";
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(211, 6);
            this.lUser.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(87, 21);
            this.lUser.TabIndex = 2;
            this.lUser.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(304, 3);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(128, 29);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(438, 6);
            this.lPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(82, 21);
            this.lPassword.TabIndex = 4;
            this.lPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSourceDBControls.SetFlowBreak(this.tbPassword, true);
            this.tbPassword.Location = new System.Drawing.Point(526, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(128, 29);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // lDatabase
            // 
            this.lDatabase.AutoSize = true;
            this.lDatabase.Location = new System.Drawing.Point(3, 41);
            this.lDatabase.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lDatabase.Name = "lDatabase";
            this.lDatabase.Size = new System.Drawing.Size(81, 21);
            this.lDatabase.TabIndex = 6;
            this.lDatabase.Text = "Database";
            // 
            // cbDatabase
            // 
            this.cbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(90, 38);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(291, 29);
            this.cbDatabase.TabIndex = 4;
            this.cbDatabase.SelectedValueChanged += new System.EventHandler(this.cbDatabase_SelectedValueChanged);
            // 
            // lObjectType
            // 
            this.lObjectType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lObjectType.AutoSize = true;
            this.lObjectType.Location = new System.Drawing.Point(387, 41);
            this.lObjectType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lObjectType.Name = "lObjectType";
            this.lObjectType.Size = new System.Drawing.Size(100, 21);
            this.lObjectType.TabIndex = 8;
            this.lObjectType.Text = "Object Type";
            // 
            // cbObjectType
            // 
            this.cbObjectType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flpSourceDBControls.SetFlowBreak(this.cbObjectType, true);
            this.cbObjectType.FormattingEnabled = true;
            this.cbObjectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbObjectType.Items.AddRange(new object[] {
            "Stored Procedure",
            "Function"});
            this.cbObjectType.Location = new System.Drawing.Point(493, 38);
            this.cbObjectType.Name = "cbObjectType";
            this.cbObjectType.Size = new System.Drawing.Size(161, 29);
            this.cbObjectType.TabIndex = 5;
            this.cbObjectType.SelectedIndexChanged += new System.EventHandler(this.cbObjectType_SelectedIndexChanged);
            this.cbObjectType.SelectedValueChanged += new System.EventHandler(this.cbObjectType_SelectedValueChanged);
            // 
            // lObjectTypeName
            // 
            this.lObjectTypeName.AutoSize = true;
            this.lObjectTypeName.Location = new System.Drawing.Point(3, 70);
            this.lObjectTypeName.Name = "lObjectTypeName";
            this.lObjectTypeName.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lObjectTypeName.Size = new System.Drawing.Size(148, 33);
            this.lObjectTypeName.TabIndex = 10;
            this.lObjectTypeName.Text = "Stored Procedure";
            // 
            // cbDatabaseObjects
            // 
            this.cbDatabaseObjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDatabaseObjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabaseObjects.FormattingEnabled = true;
            this.cbDatabaseObjects.Location = new System.Drawing.Point(157, 73);
            this.cbDatabaseObjects.Name = "cbDatabaseObjects";
            this.cbDatabaseObjects.Size = new System.Drawing.Size(386, 29);
            this.cbDatabaseObjects.TabIndex = 7;
            // 
            // bLoad
            // 
            this.bLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLoad.Location = new System.Drawing.Point(549, 73);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(106, 29);
            this.bLoad.TabIndex = 7;
            this.bLoad.Text = "Load text";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // cbOverwrite
            // 
            this.cbOverwrite.AutoSize = true;
            this.cbOverwrite.Location = new System.Drawing.Point(11, 108);
            this.cbOverwrite.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.cbOverwrite.Name = "cbOverwrite";
            this.cbOverwrite.Size = new System.Drawing.Size(190, 25);
            this.cbOverwrite.TabIndex = 11;
            this.cbOverwrite.Text = "Overwrite on CREATE";
            this.toolTip1.SetToolTip(this.cbOverwrite, "Overwrite object on CREATE even if it does exist");
            this.cbOverwrite.UseVisualStyleBackColor = true;
            // 
            // cbCreateOnAlter
            // 
            this.cbCreateOnAlter.AutoSize = true;
            this.cbCreateOnAlter.Location = new System.Drawing.Point(207, 108);
            this.cbCreateOnAlter.Name = "cbCreateOnAlter";
            this.cbCreateOnAlter.Size = new System.Drawing.Size(152, 25);
            this.cbCreateOnAlter.TabIndex = 12;
            this.cbCreateOnAlter.Text = "Create on ALTER";
            this.toolTip1.SetToolTip(this.cbCreateOnAlter, "Create object on ALTER if it does not exist");
            this.cbCreateOnAlter.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bwTransfer
            // 
            this.bwTransfer.WorkerReportsProgress = true;
            this.bwTransfer.WorkerSupportsCancellation = true;
            this.bwTransfer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwTransfer_DoWork);
            this.bwTransfer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwTransfer_ProgressChanged);
            this.bwTransfer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwTransfer_RunWorkerCompleted);
            // 
            // fMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 796);
            this.Controls.Add(this.scMainSplitContainer);
            this.Controls.Add(this.tsButtonBar);
            this.Controls.Add(this.msMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "fMainForm";
            this.Text = "wReplicateSP";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.tsButtonBar.ResumeLayout(false);
            this.tsButtonBar.PerformLayout();
            this.scMainSplitContainer.Panel1.ResumeLayout(false);
            this.scMainSplitContainer.Panel1.PerformLayout();
            this.scMainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMainSplitContainer)).EndInit();
            this.scMainSplitContainer.ResumeLayout(false);
            this.tlpMainDBObjectPanel.ResumeLayout(false);
            this.tlpMainDBObjectPanel.PerformLayout();
            this.gbOriginData.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flpSourceDBControls.ResumeLayout(false);
            this.flpSourceDBControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msMainMenu;
        private ToolStrip tsButtonBar;
        private SplitContainer scMainSplitContainer;
        private Label lRemoteConfiguration;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem replicateToolStripMenuItem;
        private ToolStripMenuItem reloadConfigurationToolStripMenuItem;
        private ToolStripMenuItem clearLoadedTextToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripButton tsbReplicate;
        private ToolStripButton tsbCancel;
        private ToolStripButton tsbReloadConfiguration;
        private ToolStripButton tsbClearLoadedText;
        private ToolStripButton tsbExit;
        private TableLayoutPanel tlpMainDBObjectPanel;
        private TextBox tbDbObjectText;
        private GroupBox gbOriginData;
        private Panel panel1;
        private TextBox tbServer;
        private Label lServer;
        private ComboBox cbObjectType;
        private Label lObjectType;
        private ComboBox cbDatabase;
        private Label lDatabase;
        private TextBox tbPassword;
        private Label lPassword;
        private TextBox tbUsername;
        private Label lUser;
        private Button bLoad;
        private ComboBox cbDatabaseObjects;
        private Label lObjectTypeName;
        private FlowLayoutPanel flpSourceDBControls;
        private TableLayoutPanel tlpConfigurationItemsPanel;
        private ImageList imageList1;
        private CheckBox cbOverwrite;
        private ToolTip toolTip1;
        private CheckBox cbCreateOnAlter;
        private CheckBox cbSelectAll;
        private System.ComponentModel.BackgroundWorker bwTransfer;
    }
}