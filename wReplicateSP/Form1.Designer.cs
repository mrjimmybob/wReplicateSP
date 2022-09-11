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
            this.tlpMainConfigurationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lRemoteConfiguration = new System.Windows.Forms.Label();
            this.tlpConfigurationItems = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainDBObjectPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tbDbObjectText = new System.Windows.Forms.TextBox();
            this.gbOriginData = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bLoad = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lObjectTypeName = new System.Windows.Forms.Label();
            this.cbObjectType = new System.Windows.Forms.ComboBox();
            this.lObjectType = new System.Windows.Forms.Label();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.lDatabase = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lUser = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.lServer = new System.Windows.Forms.Label();
            this.msMainMenu.SuspendLayout();
            this.tsButtonBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMainSplitContainer)).BeginInit();
            this.scMainSplitContainer.Panel1.SuspendLayout();
            this.scMainSplitContainer.Panel2.SuspendLayout();
            this.scMainSplitContainer.SuspendLayout();
            this.tlpMainConfigurationPanel.SuspendLayout();
            this.tlpMainDBObjectPanel.SuspendLayout();
            this.gbOriginData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(1040, 24);
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
            this.clearLoadedTextToolStripMenuItem.Name = "clearLoadedTextToolStripMenuItem";
            this.clearLoadedTextToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.clearLoadedTextToolStripMenuItem.Text = "Clear Loaded Text";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tsButtonBar
            // 
            this.tsButtonBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReplicate,
            this.tsbCancel,
            this.tsbReloadConfiguration,
            this.tsbClearLoadedText,
            this.tsbExit});
            this.tsButtonBar.Location = new System.Drawing.Point(0, 24);
            this.tsButtonBar.Name = "tsButtonBar";
            this.tsButtonBar.Size = new System.Drawing.Size(1040, 25);
            this.tsButtonBar.TabIndex = 1;
            this.tsButtonBar.Text = "toolStrip1";
            // 
            // tsbReplicate
            // 
            this.tsbReplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReplicate.Image = ((System.Drawing.Image)(resources.GetObject("tsbReplicate.Image")));
            this.tsbReplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReplicate.Name = "tsbReplicate";
            this.tsbReplicate.Size = new System.Drawing.Size(23, 22);
            this.tsbReplicate.Text = "toolStripButton1";
            // 
            // tsbCancel
            // 
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(23, 22);
            this.tsbCancel.Text = "toolStripButton2";
            // 
            // tsbReloadConfiguration
            // 
            this.tsbReloadConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReloadConfiguration.Image = ((System.Drawing.Image)(resources.GetObject("tsbReloadConfiguration.Image")));
            this.tsbReloadConfiguration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReloadConfiguration.Name = "tsbReloadConfiguration";
            this.tsbReloadConfiguration.Size = new System.Drawing.Size(23, 22);
            this.tsbReloadConfiguration.Text = "toolStripButton1";
            // 
            // tsbClearLoadedText
            // 
            this.tsbClearLoadedText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClearLoadedText.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearLoadedText.Image")));
            this.tsbClearLoadedText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearLoadedText.Name = "tsbClearLoadedText";
            this.tsbClearLoadedText.Size = new System.Drawing.Size(23, 22);
            this.tsbClearLoadedText.Text = "toolStripButton1";
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(23, 22);
            this.tsbExit.Text = "toolStripButton1";
            // 
            // scMainSplitContainer
            // 
            this.scMainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainSplitContainer.Location = new System.Drawing.Point(0, 49);
            this.scMainSplitContainer.Name = "scMainSplitContainer";
            // 
            // scMainSplitContainer.Panel1
            // 
            this.scMainSplitContainer.Panel1.Controls.Add(this.tlpMainConfigurationPanel);
            // 
            // scMainSplitContainer.Panel2
            // 
            this.scMainSplitContainer.Panel2.Controls.Add(this.tlpMainDBObjectPanel);
            this.scMainSplitContainer.Size = new System.Drawing.Size(1040, 436);
            this.scMainSplitContainer.SplitterDistance = 287;
            this.scMainSplitContainer.TabIndex = 2;
            // 
            // tlpMainConfigurationPanel
            // 
            this.tlpMainConfigurationPanel.ColumnCount = 1;
            this.tlpMainConfigurationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainConfigurationPanel.Controls.Add(this.lRemoteConfiguration, 0, 0);
            this.tlpMainConfigurationPanel.Controls.Add(this.tlpConfigurationItems, 0, 1);
            this.tlpMainConfigurationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainConfigurationPanel.Location = new System.Drawing.Point(0, 0);
            this.tlpMainConfigurationPanel.Name = "tlpMainConfigurationPanel";
            this.tlpMainConfigurationPanel.RowCount = 2;
            this.tlpMainConfigurationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.733167F));
            this.tlpMainConfigurationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.26683F));
            this.tlpMainConfigurationPanel.Size = new System.Drawing.Size(287, 436);
            this.tlpMainConfigurationPanel.TabIndex = 0;
            // 
            // lRemoteConfiguration
            // 
            this.lRemoteConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lRemoteConfiguration.AutoSize = true;
            this.lRemoteConfiguration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lRemoteConfiguration.Location = new System.Drawing.Point(3, 0);
            this.lRemoteConfiguration.Name = "lRemoteConfiguration";
            this.lRemoteConfiguration.Size = new System.Drawing.Size(281, 21);
            this.lRemoteConfiguration.TabIndex = 0;
            this.lRemoteConfiguration.Text = "Remote Configuration";
            this.lRemoteConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpConfigurationItems
            // 
            this.tlpConfigurationItems.ColumnCount = 1;
            this.tlpConfigurationItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConfigurationItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConfigurationItems.Location = new System.Drawing.Point(3, 32);
            this.tlpConfigurationItems.Name = "tlpConfigurationItems";
            this.tlpConfigurationItems.RowCount = 1;
            this.tlpConfigurationItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConfigurationItems.Size = new System.Drawing.Size(281, 401);
            this.tlpConfigurationItems.TabIndex = 1;
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
            this.tlpMainDBObjectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.41646F));
            this.tlpMainDBObjectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.58354F));
            this.tlpMainDBObjectPanel.Size = new System.Drawing.Size(749, 436);
            this.tlpMainDBObjectPanel.TabIndex = 0;
            // 
            // tbDbObjectText
            // 
            this.tbDbObjectText.AcceptsReturn = true;
            this.tbDbObjectText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDbObjectText.Location = new System.Drawing.Point(3, 148);
            this.tbDbObjectText.Multiline = true;
            this.tbDbObjectText.Name = "tbDbObjectText";
            this.tbDbObjectText.Size = new System.Drawing.Size(743, 285);
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
            this.gbOriginData.Size = new System.Drawing.Size(743, 139);
            this.gbOriginData.TabIndex = 1;
            this.gbOriginData.TabStop = false;
            this.gbOriginData.Text = "Load Database Object";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bLoad);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lObjectTypeName);
            this.panel1.Controls.Add(this.cbObjectType);
            this.panel1.Controls.Add(this.lObjectType);
            this.panel1.Controls.Add(this.cbDatabase);
            this.panel1.Controls.Add(this.lDatabase);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.lPassword);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.lUser);
            this.panel1.Controls.Add(this.tbServer);
            this.panel1.Controls.Add(this.lServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 111);
            this.panel1.TabIndex = 0;
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(638, 73);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(93, 29);
            this.bLoad.TabIndex = 7;
            this.bLoad.Text = "Load";
            this.bLoad.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(481, 29);
            this.comboBox1.TabIndex = 7;
            // 
            // lObjectTypeName
            // 
            this.lObjectTypeName.AutoSize = true;
            this.lObjectTypeName.Location = new System.Drawing.Point(3, 76);
            this.lObjectTypeName.Name = "lObjectTypeName";
            this.lObjectTypeName.Size = new System.Drawing.Size(142, 21);
            this.lObjectTypeName.TabIndex = 10;
            this.lObjectTypeName.Text = "Stored Procedure";
            // 
            // cbObjectType
            // 
            this.cbObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjectType.FormattingEnabled = true;
            this.cbObjectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbObjectType.Items.AddRange(new object[] {
            "Stored Procedure",
            "Function"});
            this.cbObjectType.Location = new System.Drawing.Point(536, 38);
            this.cbObjectType.Name = "cbObjectType";
            this.cbObjectType.Size = new System.Drawing.Size(195, 29);
            this.cbObjectType.TabIndex = 5;
            this.cbObjectType.SelectedIndexChanged += new System.EventHandler(this.cbObjectType_SelectedIndexChanged);
            // 
            // lObjectType
            // 
            this.lObjectType.AutoSize = true;
            this.lObjectType.Location = new System.Drawing.Point(430, 41);
            this.lObjectType.Name = "lObjectType";
            this.lObjectType.Size = new System.Drawing.Size(100, 21);
            this.lObjectType.TabIndex = 8;
            this.lObjectType.Text = "Object Type";
            // 
            // cbDatabase
            // 
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(90, 38);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(334, 29);
            this.cbDatabase.TabIndex = 4;
            // 
            // lDatabase
            // 
            this.lDatabase.AutoSize = true;
            this.lDatabase.Location = new System.Drawing.Point(3, 41);
            this.lDatabase.Name = "lDatabase";
            this.lDatabase.Size = new System.Drawing.Size(81, 21);
            this.lDatabase.TabIndex = 6;
            this.lDatabase.Text = "Database";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(536, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(195, 29);
            this.tbPassword.TabIndex = 3;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(448, 7);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(82, 21);
            this.lPassword.TabIndex = 4;
            this.lPassword.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(314, 3);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(128, 29);
            this.tbUsername.TabIndex = 2;
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(219, 6);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(87, 21);
            this.lUser.TabIndex = 2;
            this.lUser.Text = "Username";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(90, 3);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(123, 29);
            this.tbServer.TabIndex = 1;
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Location = new System.Drawing.Point(3, 6);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(59, 21);
            this.lServer.TabIndex = 0;
            this.lServer.Text = "Server";
            // 
            // fMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 485);
            this.Controls.Add(this.scMainSplitContainer);
            this.Controls.Add(this.tsButtonBar);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "fMainForm";
            this.Text = "wReplicateSP";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.tsButtonBar.ResumeLayout(false);
            this.tsButtonBar.PerformLayout();
            this.scMainSplitContainer.Panel1.ResumeLayout(false);
            this.scMainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMainSplitContainer)).EndInit();
            this.scMainSplitContainer.ResumeLayout(false);
            this.tlpMainConfigurationPanel.ResumeLayout(false);
            this.tlpMainConfigurationPanel.PerformLayout();
            this.tlpMainDBObjectPanel.ResumeLayout(false);
            this.tlpMainDBObjectPanel.PerformLayout();
            this.gbOriginData.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private TableLayoutPanel tlpMainConfigurationPanel;
        private TableLayoutPanel tlpConfigurationItems;
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
        private ComboBox comboBox1;
        private Label lObjectTypeName;
    }
}