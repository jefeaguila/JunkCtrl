namespace Junkctrl
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textHeaderAppInfo = new System.Windows.Forms.ToolStripTextBox();
            this.contextKebapMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPluginAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPluginEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPluginDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPluginsDir = new System.Windows.Forms.ToolStripMenuItem();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.lnkAppMediaGitHub = new System.Windows.Forms.LinkLabel();
            this.lblAppInfo = new System.Windows.Forms.Label();
            this.lnkAppMediaTwitter = new System.Windows.Forms.LinkLabel();
            this._Assembly = new System.Windows.Forms.LinkLabel();
            this.lnkAppMediaDonate = new System.Windows.Forms.LinkLabel();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnKebapMenu = new System.Windows.Forms.Button();
            this.pnlCapabilities = new System.Windows.Forms.Panel();
            this.lnkHeader = new System.Windows.Forms.LinkLabel();
            this.lnkAddTopTenToBin = new System.Windows.Forms.LinkLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tvwFeatures = new System.Windows.Forms.TreeView();
            this.lblItemsInRecycleList = new System.Windows.Forms.Label();
            this.btnBin = new System.Windows.Forms.Button();
            this.lnkStatus = new System.Windows.Forms.LinkLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.checkResults = new System.Windows.Forms.CheckedListBox();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.contextKebapMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlCapabilities.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // textHeaderAppInfo
            // 
            this.textHeaderAppInfo.BackColor = System.Drawing.Color.White;
            this.textHeaderAppInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHeaderAppInfo.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHeaderAppInfo.ForeColor = System.Drawing.Color.Gray;
            this.textHeaderAppInfo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 10);
            this.textHeaderAppInfo.Name = "textHeaderAppInfo";
            this.textHeaderAppInfo.ReadOnly = true;
            this.textHeaderAppInfo.Size = new System.Drawing.Size(200, 18);
            this.textHeaderAppInfo.Text = "App-Settings (progress)";
            // 
            // contextKebapMenu
            // 
            this.contextKebapMenu.BackColor = System.Drawing.Color.White;
            this.contextKebapMenu.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextKebapMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textHeaderAppInfo,
            this.menuPluginAdd,
            this.menuPluginEdit,
            this.menuPluginDelete,
            this.menuPluginsDir});
            this.contextKebapMenu.Name = "menuMain";
            this.contextKebapMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextKebapMenu.Size = new System.Drawing.Size(261, 141);
            // 
            // menuPluginAdd
            // 
            this.menuPluginAdd.Name = "menuPluginAdd";
            this.menuPluginAdd.Size = new System.Drawing.Size(260, 26);
            this.menuPluginAdd.Text = "Create plugin";
            this.menuPluginAdd.Click += new System.EventHandler(this.menuPluginCreate_Click);
            // 
            // menuPluginEdit
            // 
            this.menuPluginEdit.Name = "menuPluginEdit";
            this.menuPluginEdit.Size = new System.Drawing.Size(260, 26);
            this.menuPluginEdit.Text = "Edit plugin";
            this.menuPluginEdit.Click += new System.EventHandler(this.menuPluginEdit_Click);
            // 
            // menuPluginDelete
            // 
            this.menuPluginDelete.Name = "menuPluginDelete";
            this.menuPluginDelete.Size = new System.Drawing.Size(260, 26);
            this.menuPluginDelete.Text = "Delete plugin";
            this.menuPluginDelete.Click += new System.EventHandler(this.menuPluginDelete_Click);
            // 
            // menuPluginsDir
            // 
            this.menuPluginsDir.Name = "menuPluginsDir";
            this.menuPluginsDir.Size = new System.Drawing.Size(260, 26);
            this.menuPluginsDir.Text = "Open plugins folder";
            this.menuPluginsDir.Click += new System.EventHandler(this.menuPluginsDir_Click);
            // 
            // sc
            // 
            this.sc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sc.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.sc.Location = new System.Drawing.Point(0, 0);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.AutoScroll = true;
            this.sc.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.sc.Panel1.Controls.Add(this.lnkAppMediaGitHub);
            this.sc.Panel1.Controls.Add(this.lblAppInfo);
            this.sc.Panel1.Controls.Add(this.lnkAppMediaTwitter);
            this.sc.Panel1.Controls.Add(this._Assembly);
            this.sc.Panel1.Controls.Add(this.lnkAppMediaDonate);
            this.sc.Panel1.Controls.Add(this.pbBackground);
            this.sc.Panel1.Controls.Add(this.btnBack);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.AutoScroll = true;
            this.sc.Panel2.Controls.Add(this.pnlMain);
            this.sc.Size = new System.Drawing.Size(1026, 663);
            this.sc.SplitterDistance = 412;
            this.sc.TabIndex = 220;
            // 
            // lnkAppMediaGitHub
            // 
            this.lnkAppMediaGitHub.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkAppMediaGitHub.AutoEllipsis = true;
            this.lnkAppMediaGitHub.AutoSize = true;
            this.lnkAppMediaGitHub.BackColor = System.Drawing.Color.Transparent;
            this.lnkAppMediaGitHub.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAppMediaGitHub.ForeColor = System.Drawing.Color.Black;
            this.lnkAppMediaGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAppMediaGitHub.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaGitHub.Location = new System.Drawing.Point(12, 603);
            this.lnkAppMediaGitHub.Name = "lnkAppMediaGitHub";
            this.lnkAppMediaGitHub.Size = new System.Drawing.Size(39, 15);
            this.lnkAppMediaGitHub.TabIndex = 221;
            this.lnkAppMediaGitHub.TabStop = true;
            this.lnkAppMediaGitHub.Text = "GitHub";
            this.lnkAppMediaGitHub.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAppMediaGitHub_LinkClicked);
            // 
            // lblAppInfo
            // 
            this.lblAppInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAppInfo.AutoSize = true;
            this.lblAppInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblAppInfo.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppInfo.ForeColor = System.Drawing.Color.Black;
            this.lblAppInfo.Location = new System.Drawing.Point(12, 567);
            this.lblAppInfo.Name = "lblAppInfo";
            this.lblAppInfo.Size = new System.Drawing.Size(94, 17);
            this.lblAppInfo.TabIndex = 220;
            this.lblAppInfo.Text = "About this app";
            // 
            // lnkAppMediaTwitter
            // 
            this.lnkAppMediaTwitter.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkAppMediaTwitter.AutoEllipsis = true;
            this.lnkAppMediaTwitter.AutoSize = true;
            this.lnkAppMediaTwitter.BackColor = System.Drawing.Color.Transparent;
            this.lnkAppMediaTwitter.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAppMediaTwitter.ForeColor = System.Drawing.Color.Black;
            this.lnkAppMediaTwitter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAppMediaTwitter.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaTwitter.Location = new System.Drawing.Point(12, 633);
            this.lnkAppMediaTwitter.Name = "lnkAppMediaTwitter";
            this.lnkAppMediaTwitter.Size = new System.Drawing.Size(38, 15);
            this.lnkAppMediaTwitter.TabIndex = 199;
            this.lnkAppMediaTwitter.TabStop = true;
            this.lnkAppMediaTwitter.Text = "Twitter";
            this.lnkAppMediaTwitter.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAppMediaTwitter_LinkClicked);
            // 
            // _Assembly
            // 
            this._Assembly.ActiveLinkColor = System.Drawing.Color.Fuchsia;
            this._Assembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._Assembly.AutoEllipsis = true;
            this._Assembly.AutoSize = true;
            this._Assembly.BackColor = System.Drawing.Color.Transparent;
            this._Assembly.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 8.25F);
            this._Assembly.ForeColor = System.Drawing.Color.Transparent;
            this._Assembly.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this._Assembly.LinkColor = System.Drawing.Color.MediumVioletRed;
            this._Assembly.Location = new System.Drawing.Point(12, 588);
            this._Assembly.Name = "_Assembly";
            this._Assembly.Size = new System.Drawing.Size(92, 15);
            this._Assembly.TabIndex = 203;
            this._Assembly.TabStop = true;
            this._Assembly.Text = "Builtbybel May, 23";
            this._Assembly.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this._Assembly.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._Assembly_LinkClicked);
            // 
            // lnkAppMediaDonate
            // 
            this.lnkAppMediaDonate.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkAppMediaDonate.AutoEllipsis = true;
            this.lnkAppMediaDonate.AutoSize = true;
            this.lnkAppMediaDonate.BackColor = System.Drawing.Color.Transparent;
            this.lnkAppMediaDonate.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAppMediaDonate.ForeColor = System.Drawing.Color.Black;
            this.lnkAppMediaDonate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAppMediaDonate.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaDonate.Location = new System.Drawing.Point(12, 618);
            this.lnkAppMediaDonate.Name = "lnkAppMediaDonate";
            this.lnkAppMediaDonate.Size = new System.Drawing.Size(42, 15);
            this.lnkAppMediaDonate.TabIndex = 200;
            this.lnkAppMediaDonate.TabStop = true;
            this.lnkAppMediaDonate.Text = "Donate";
            this.lnkAppMediaDonate.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAppMediaDonate_LinkClicked);
            // 
            // pbBackground
            // 
            this.pbBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBackground.ErrorImage = null;
            this.pbBackground.InitialImage = null;
            this.pbBackground.Location = new System.Drawing.Point(3, 44);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(407, 604);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackground.TabIndex = 223;
            this.pbBackground.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 38);
            this.btnBack.TabIndex = 219;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.btnKebapMenu);
            this.pnlMain.Controls.Add(this.pnlCapabilities);
            this.pnlMain.Controls.Add(this.lblItemsInRecycleList);
            this.pnlMain.Controls.Add(this.btnBin);
            this.pnlMain.Controls.Add(this.lnkStatus);
            this.pnlMain.Controls.Add(this.progressBar);
            this.pnlMain.Controls.Add(this.checkResults);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(610, 663);
            this.pnlMain.TabIndex = 216;
            // 
            // btnKebapMenu
            // 
            this.btnKebapMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKebapMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnKebapMenu.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnKebapMenu.FlatAppearance.BorderSize = 0;
            this.btnKebapMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnKebapMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKebapMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnKebapMenu.ForeColor = System.Drawing.Color.Black;
            this.btnKebapMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKebapMenu.Location = new System.Drawing.Point(565, 3);
            this.btnKebapMenu.Name = "btnKebapMenu";
            this.btnKebapMenu.Size = new System.Drawing.Size(42, 47);
            this.btnKebapMenu.TabIndex = 212;
            this.btnKebapMenu.Text = "...";
            this.btnKebapMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKebapMenu.UseVisualStyleBackColor = false;
            this.btnKebapMenu.Click += new System.EventHandler(this.btnKebapMenu_Click);
            // 
            // pnlCapabilities
            // 
            this.pnlCapabilities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCapabilities.AutoScroll = true;
            this.pnlCapabilities.Controls.Add(this.lnkHeader);
            this.pnlCapabilities.Controls.Add(this.lnkAddTopTenToBin);
            this.pnlCapabilities.Controls.Add(this.btnSearch);
            this.pnlCapabilities.Controls.Add(this.tvwFeatures);
            this.pnlCapabilities.Location = new System.Drawing.Point(24, 12);
            this.pnlCapabilities.Name = "pnlCapabilities";
            this.pnlCapabilities.Size = new System.Drawing.Size(544, 584);
            this.pnlCapabilities.TabIndex = 224;
            // 
            // lnkHeader
            // 
            this.lnkHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkHeader.AutoEllipsis = true;
            this.lnkHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lnkHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkHeader.LinkColor = System.Drawing.Color.DimGray;
            this.lnkHeader.Location = new System.Drawing.Point(15, 15);
            this.lnkHeader.Name = "lnkHeader";
            this.lnkHeader.Size = new System.Drawing.Size(511, 42);
            this.lnkHeader.TabIndex = 224;
            this.lnkHeader.TabStop = true;
            this.lnkHeader.Text = "Have you just freshly installed Windows 11? I\'m here to provide explanations on v" +
    "arious cleanup actions. Click on me to get more information about an option.";
            this.lnkHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHeader_LinkClicked);
            // 
            // lnkAddTopTenToBin
            // 
            this.lnkAddTopTenToBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAddTopTenToBin.AutoSize = true;
            this.lnkAddTopTenToBin.BackColor = System.Drawing.Color.Transparent;
            this.lnkAddTopTenToBin.Location = new System.Drawing.Point(25, 546);
            this.lnkAddTopTenToBin.Name = "lnkAddTopTenToBin";
            this.lnkAddTopTenToBin.Size = new System.Drawing.Size(219, 13);
            this.lnkAddTopTenToBin.TabIndex = 222;
            this.lnkAddTopTenToBin.TabStop = true;
            this.lnkAddTopTenToBin.Text = "+ Add Top 10 hated Windows 11 apps to bin";
            this.lnkAddTopTenToBin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddTopTenToBin_LinkClicked);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AutoEllipsis = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(326, 529);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 39);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "+    New search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tvwFeatures
            // 
            this.tvwFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwFeatures.BackColor = System.Drawing.Color.White;
            this.tvwFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwFeatures.CheckBoxes = true;
            this.tvwFeatures.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwFeatures.ForeColor = System.Drawing.Color.Black;
            this.tvwFeatures.FullRowSelect = true;
            this.tvwFeatures.Indent = 5;
            this.tvwFeatures.ItemHeight = 50;
            this.tvwFeatures.Location = new System.Drawing.Point(18, 71);
            this.tvwFeatures.Name = "tvwFeatures";
            this.tvwFeatures.ShowLines = false;
            this.tvwFeatures.ShowNodeToolTips = true;
            this.tvwFeatures.ShowPlusMinus = false;
            this.tvwFeatures.Size = new System.Drawing.Size(508, 445);
            this.tvwFeatures.TabIndex = 168;
            this.tvwFeatures.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwFeatures_AfterCheck);
            this.tvwFeatures.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwFeatures_NodeMouseClick);
            // 
            // lblItemsInRecycleList
            // 
            this.lblItemsInRecycleList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblItemsInRecycleList.AutoSize = true;
            this.lblItemsInRecycleList.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsInRecycleList.Location = new System.Drawing.Point(39, 545);
            this.lblItemsInRecycleList.Name = "lblItemsInRecycleList";
            this.lblItemsInRecycleList.Size = new System.Drawing.Size(17, 17);
            this.lblItemsInRecycleList.TabIndex = 224;
            this.lblItemsInRecycleList.Text = "...";
            // 
            // btnBin
            // 
            this.btnBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBin.AutoEllipsis = true;
            this.btnBin.BackColor = System.Drawing.Color.White;
            this.btnBin.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnBin.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnBin.ForeColor = System.Drawing.Color.Black;
            this.btnBin.Location = new System.Drawing.Point(285, 545);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(227, 39);
            this.btnBin.TabIndex = 215;
            this.btnBin.TabStop = false;
            this.btnBin.Text = "+ Add everything selected to bin";
            this.btnBin.UseVisualStyleBackColor = false;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // lnkStatus
            // 
            this.lnkStatus.ActiveLinkColor = System.Drawing.Color.Fuchsia;
            this.lnkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkStatus.AutoEllipsis = true;
            this.lnkStatus.BackColor = System.Drawing.Color.Transparent;
            this.lnkStatus.Font = new System.Drawing.Font("Segoe UI Variable Display Semil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkStatus.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkStatus.LinkColor = System.Drawing.Color.Black;
            this.lnkStatus.Location = new System.Drawing.Point(39, 628);
            this.lnkStatus.Name = "lnkStatus";
            this.lnkStatus.Size = new System.Drawing.Size(453, 20);
            this.lnkStatus.TabIndex = 196;
            this.lnkStatus.TabStop = true;
            this.lnkStatus.Text = "Depending on what you are going to be using your Windows 11 device for, you can l" +
    "et Junkctrl declutter it.";
            this.lnkStatus.VisitedLinkColor = System.Drawing.Color.Fuchsia;
            this.lnkStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStatus_LinkClicked);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(42, 521);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(485, 5);
            this.progressBar.TabIndex = 166;
            this.progressBar.Visible = false;
            // 
            // checkResults
            // 
            this.checkResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkResults.BackColor = System.Drawing.Color.White;
            this.checkResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkResults.CheckOnClick = true;
            this.checkResults.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkResults.FormattingEnabled = true;
            this.checkResults.Location = new System.Drawing.Point(42, 53);
            this.checkResults.Name = "checkResults";
            this.checkResults.Size = new System.Drawing.Size(523, 462);
            this.checkResults.Sorted = true;
            this.checkResults.TabIndex = 204;
            this.checkResults.Visible = false;
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.sc);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1026, 663);
            this.pnlForm.TabIndex = 221;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 663);
            this.Controls.Add(this.pnlForm);
            this.MinimumSize = new System.Drawing.Size(942, 523);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Junkctrl";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.contextKebapMenu.ResumeLayout(false);
            this.contextKebapMenu.PerformLayout();
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel1.PerformLayout();
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlCapabilities.ResumeLayout(false);
            this.pnlCapabilities.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripTextBox textHeaderAppInfo;
        private System.Windows.Forms.ContextMenuStrip contextKebapMenu;
        private System.Windows.Forms.ToolStripMenuItem menuPluginsDir;
        private System.Windows.Forms.ToolStripMenuItem menuPluginDelete;
        private System.Windows.Forms.ToolStripMenuItem menuPluginAdd;
        private System.Windows.Forms.ToolStripMenuItem menuPluginEdit;
        private System.Windows.Forms.Button btnKebapMenu;
        private System.Windows.Forms.LinkLabel lnkAppMediaTwitter;
        private System.Windows.Forms.LinkLabel lnkAppMediaDonate;
        private System.Windows.Forms.LinkLabel _Assembly;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.LinkLabel lnkStatus;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckedListBox checkResults;
        private System.Windows.Forms.TreeView tvwFeatures;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlCapabilities;
        private System.Windows.Forms.Label lblAppInfo;
        private System.Windows.Forms.Label lblItemsInRecycleList;
        private System.Windows.Forms.LinkLabel lnkAppMediaGitHub;
        private System.Windows.Forms.LinkLabel lnkAddTopTenToBin;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.LinkLabel lnkHeader;
        public System.Windows.Forms.SplitContainer sc;
        public System.Windows.Forms.Panel pnlForm;
    }
}

