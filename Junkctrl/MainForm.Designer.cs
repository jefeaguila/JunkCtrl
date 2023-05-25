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
            this.menuPluginCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPluginEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPluginDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPluginsDir = new System.Windows.Forms.ToolStripMenuItem();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this._lblAboutInfo = new System.Windows.Forms.Label();
            this.lnkAppMediaTwitter = new System.Windows.Forms.LinkLabel();
            this.lnkAppMediaDonate = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this._lblAssembly = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkUpdateCheck = new System.Windows.Forms.LinkLabel();
            this.listTopTen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTopTenToBin = new System.Windows.Forms.Button();
            this.btnAppMediaGitHub = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.btnBin = new System.Windows.Forms.Button();
            this.lnkStatus = new System.Windows.Forms.LinkLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.checkResults = new System.Windows.Forms.CheckedListBox();
            this.tvwFeatures = new System.Windows.Forms.TreeView();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.lblHideWelcomeMsg = new System.Windows.Forms.Button();
            this.btnKebapMenu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.contextKebapMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.pnlMain.SuspendLayout();
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
            this.menuPluginCreate,
            this.menuPluginEdit,
            this.menuPluginDelete,
            this.menuPluginsDir});
            this.contextKebapMenu.Name = "menuMain";
            this.contextKebapMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextKebapMenu.Size = new System.Drawing.Size(261, 141);
            // 
            // menuPluginCreate
            // 
            this.menuPluginCreate.Name = "menuPluginCreate";
            this.menuPluginCreate.Size = new System.Drawing.Size(260, 26);
            this.menuPluginCreate.Text = "Create plugin";
            this.menuPluginCreate.Click += new System.EventHandler(this.menuPluginCreate_Click);
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
            this.sc.Location = new System.Drawing.Point(0, 70);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.AutoScroll = true;
            this.sc.Panel1.Controls.Add(this.label2);
            this.sc.Panel1.Controls.Add(this._lblAboutInfo);
            this.sc.Panel1.Controls.Add(this.lnkAppMediaTwitter);
            this.sc.Panel1.Controls.Add(this.lnkAppMediaDonate);
            this.sc.Panel1.Controls.Add(this.label4);
            this.sc.Panel1.Controls.Add(this._lblAssembly);
            this.sc.Panel1.Controls.Add(this.label3);
            this.sc.Panel1.Controls.Add(this.lnkUpdateCheck);
            this.sc.Panel1.Controls.Add(this.listTopTen);
            this.sc.Panel1.Controls.Add(this.label1);
            this.sc.Panel1.Controls.Add(this.btnAddTopTenToBin);
            this.sc.Panel1.Controls.Add(this.btnAppMediaGitHub);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.AutoScroll = true;
            this.sc.Panel2.Controls.Add(this.pnlMain);
            this.sc.Size = new System.Drawing.Size(1044, 667);
            this.sc.SplitterDistance = 211;
            this.sc.TabIndex = 220;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 30, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 60);
            this.label2.TabIndex = 211;
            this.label2.Text = "Follow this open source project on GitHub\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblAboutInfo
            // 
            this._lblAboutInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblAboutInfo.AutoEllipsis = true;
            this._lblAboutInfo.AutoSize = true;
            this._lblAboutInfo.BackColor = System.Drawing.Color.White;
            this._lblAboutInfo.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblAboutInfo.ForeColor = System.Drawing.Color.Black;
            this._lblAboutInfo.Location = new System.Drawing.Point(13, 542);
            this._lblAboutInfo.Name = "_lblAboutInfo";
            this._lblAboutInfo.Size = new System.Drawing.Size(101, 17);
            this._lblAboutInfo.TabIndex = 197;
            this._lblAboutInfo.Text = "About this App";
            // 
            // lnkAppMediaTwitter
            // 
            this.lnkAppMediaTwitter.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkAppMediaTwitter.AutoEllipsis = true;
            this.lnkAppMediaTwitter.AutoSize = true;
            this.lnkAppMediaTwitter.BackColor = System.Drawing.Color.White;
            this.lnkAppMediaTwitter.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAppMediaTwitter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAppMediaTwitter.LinkColor = System.Drawing.Color.Gray;
            this.lnkAppMediaTwitter.Location = new System.Drawing.Point(13, 568);
            this.lnkAppMediaTwitter.Name = "lnkAppMediaTwitter";
            this.lnkAppMediaTwitter.Size = new System.Drawing.Size(105, 15);
            this.lnkAppMediaTwitter.TabIndex = 199;
            this.lnkAppMediaTwitter.TabStop = true;
            this.lnkAppMediaTwitter.Text = "Follow dev on Twitter";
            this.lnkAppMediaTwitter.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAppMediaTwitter_LinkClicked);
            // 
            // lnkAppMediaDonate
            // 
            this.lnkAppMediaDonate.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkAppMediaDonate.AutoEllipsis = true;
            this.lnkAppMediaDonate.AutoSize = true;
            this.lnkAppMediaDonate.BackColor = System.Drawing.Color.White;
            this.lnkAppMediaDonate.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAppMediaDonate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAppMediaDonate.LinkColor = System.Drawing.Color.Gray;
            this.lnkAppMediaDonate.Location = new System.Drawing.Point(14, 586);
            this.lnkAppMediaDonate.Name = "lnkAppMediaDonate";
            this.lnkAppMediaDonate.Size = new System.Drawing.Size(42, 15);
            this.lnkAppMediaDonate.TabIndex = 200;
            this.lnkAppMediaDonate.TabStop = true;
            this.lnkAppMediaDonate.Text = "Donate";
            this.lnkAppMediaDonate.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkAppMediaDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAppMediaDonate_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 2);
            this.label4.TabIndex = 218;
            this.label4.Text = "div";
            // 
            // _lblAssembly
            // 
            this._lblAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblAssembly.AutoEllipsis = true;
            this._lblAssembly.AutoSize = true;
            this._lblAssembly.BackColor = System.Drawing.Color.White;
            this._lblAssembly.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblAssembly.ForeColor = System.Drawing.Color.Gray;
            this._lblAssembly.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._lblAssembly.Location = new System.Drawing.Point(14, 626);
            this._lblAssembly.Name = "_lblAssembly";
            this._lblAssembly.Size = new System.Drawing.Size(43, 15);
            this._lblAssembly.TabIndex = 202;
            this._lblAssembly.Text = "Version";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 2);
            this.label3.TabIndex = 217;
            this.label3.Text = "div";
            // 
            // lnkUpdateCheck
            // 
            this.lnkUpdateCheck.ActiveLinkColor = System.Drawing.Color.Fuchsia;
            this.lnkUpdateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkUpdateCheck.AutoEllipsis = true;
            this.lnkUpdateCheck.AutoSize = true;
            this.lnkUpdateCheck.BackColor = System.Drawing.Color.White;
            this.lnkUpdateCheck.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUpdateCheck.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkUpdateCheck.LinkColor = System.Drawing.Color.Crimson;
            this.lnkUpdateCheck.Location = new System.Drawing.Point(14, 611);
            this.lnkUpdateCheck.Name = "lnkUpdateCheck";
            this.lnkUpdateCheck.Size = new System.Drawing.Size(92, 15);
            this.lnkUpdateCheck.TabIndex = 203;
            this.lnkUpdateCheck.TabStop = true;
            this.lnkUpdateCheck.Text = "Check for updates";
            this.lnkUpdateCheck.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkUpdateCheck.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdateCheck_LinkClicked);
            // 
            // listTopTen
            // 
            this.listTopTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listTopTen.BackColor = System.Drawing.Color.White;
            this.listTopTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTopTen.Font = new System.Drawing.Font("Segoe UI Variable Display Semil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTopTen.FormattingEnabled = true;
            this.listTopTen.ItemHeight = 15;
            this.listTopTen.Location = new System.Drawing.Point(16, 291);
            this.listTopTen.MultiColumn = true;
            this.listTopTen.Name = "listTopTen";
            this.listTopTen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listTopTen.Size = new System.Drawing.Size(160, 165);
            this.listTopTen.TabIndex = 205;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 206;
            this.label1.Text = "Most hated apps";
            // 
            // btnAddTopTenToBin
            // 
            this.btnAddTopTenToBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTopTenToBin.AutoEllipsis = true;
            this.btnAddTopTenToBin.BackColor = System.Drawing.Color.White;
            this.btnAddTopTenToBin.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAddTopTenToBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTopTenToBin.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddTopTenToBin.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddTopTenToBin.Location = new System.Drawing.Point(17, 462);
            this.btnAddTopTenToBin.Name = "btnAddTopTenToBin";
            this.btnAddTopTenToBin.Size = new System.Drawing.Size(100, 34);
            this.btnAddTopTenToBin.TabIndex = 207;
            this.btnAddTopTenToBin.TabStop = false;
            this.btnAddTopTenToBin.Text = "+ Add to bin";
            this.btnAddTopTenToBin.UseVisualStyleBackColor = false;
            this.btnAddTopTenToBin.Click += new System.EventHandler(this.btnAddTopTenToBin_Click);
            // 
            // btnAppMediaGitHub
            // 
            this.btnAppMediaGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAppMediaGitHub.BackColor = System.Drawing.Color.White;
            this.btnAppMediaGitHub.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAppMediaGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppMediaGitHub.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppMediaGitHub.ForeColor = System.Drawing.Color.Crimson;
            this.btnAppMediaGitHub.Location = new System.Drawing.Point(11, 136);
            this.btnAppMediaGitHub.Name = "btnAppMediaGitHub";
            this.btnAppMediaGitHub.Size = new System.Drawing.Size(159, 39);
            this.btnAppMediaGitHub.TabIndex = 210;
            this.btnAppMediaGitHub.TabStop = false;
            this.btnAppMediaGitHub.Text = "Follow";
            this.btnAppMediaGitHub.UseVisualStyleBackColor = false;
            this.btnAppMediaGitHub.Click += new System.EventHandler(this.btnAppMediaGitHub_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.lblSubHeader);
            this.pnlMain.Controls.Add(this.btnBin);
            this.pnlMain.Controls.Add(this.lnkStatus);
            this.pnlMain.Controls.Add(this.progressBar);
            this.pnlMain.Controls.Add(this.checkResults);
            this.pnlMain.Controls.Add(this.tvwFeatures);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(829, 667);
            this.pnlMain.TabIndex = 216;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.AutoEllipsis = true;
            this.btnSearch.BackColor = System.Drawing.Color.Crimson;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(415, 586);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 35);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubHeader.AutoEllipsis = true;
            this.lblSubHeader.BackColor = System.Drawing.Color.White;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.Location = new System.Drawing.Point(104, 13);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(301, 33);
            this.lblSubHeader.TabIndex = 176;
            this.lblSubHeader.Text = "Capabilities";
            this.lblSubHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBin
            // 
            this.btnBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBin.AutoEllipsis = true;
            this.btnBin.BackColor = System.Drawing.Color.White;
            this.btnBin.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBin.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnBin.ForeColor = System.Drawing.Color.Black;
            this.btnBin.Location = new System.Drawing.Point(309, 587);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(100, 34);
            this.btnBin.TabIndex = 215;
            this.btnBin.TabStop = false;
            this.btnBin.Text = "+ Add to bin";
            this.btnBin.UseVisualStyleBackColor = false;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // lnkStatus
            // 
            this.lnkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkStatus.AutoEllipsis = true;
            this.lnkStatus.BackColor = System.Drawing.Color.Transparent;
            this.lnkStatus.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkStatus.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkStatus.LinkColor = System.Drawing.Color.Black;
            this.lnkStatus.Location = new System.Drawing.Point(105, 46);
            this.lnkStatus.Name = "lnkStatus";
            this.lnkStatus.Size = new System.Drawing.Size(552, 36);
            this.lnkStatus.TabIndex = 196;
            this.lnkStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStatus_LinkClicked);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(108, 85);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(416, 5);
            this.progressBar.TabIndex = 166;
            this.progressBar.Visible = false;
            // 
            // checkResults
            // 
            this.checkResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkResults.BackColor = System.Drawing.Color.White;
            this.checkResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkResults.CheckOnClick = true;
            this.checkResults.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkResults.FormattingEnabled = true;
            this.checkResults.Location = new System.Drawing.Point(109, 96);
            this.checkResults.Name = "checkResults";
            this.checkResults.Size = new System.Drawing.Size(415, 440);
            this.checkResults.TabIndex = 204;
            this.checkResults.Visible = false;
            // 
            // tvwFeatures
            // 
            this.tvwFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwFeatures.BackColor = System.Drawing.Color.White;
            this.tvwFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwFeatures.CheckBoxes = true;
            this.tvwFeatures.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwFeatures.ForeColor = System.Drawing.Color.Black;
            this.tvwFeatures.FullRowSelect = true;
            this.tvwFeatures.Indent = 5;
            this.tvwFeatures.ItemHeight = 50;
            this.tvwFeatures.Location = new System.Drawing.Point(109, 96);
            this.tvwFeatures.Name = "tvwFeatures";
            this.tvwFeatures.ShowLines = false;
            this.tvwFeatures.ShowNodeToolTips = true;
            this.tvwFeatures.ShowPlusMinus = false;
            this.tvwFeatures.Size = new System.Drawing.Size(415, 449);
            this.tvwFeatures.TabIndex = 168;
            this.tvwFeatures.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwFeatures_AfterCheck);
            this.tvwFeatures.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwFeatures_NodeMouseClick);
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSearch.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.ForeColor = System.Drawing.Color.Gray;
            this.textSearch.Location = new System.Drawing.Point(365, 20);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(255, 31);
            this.textSearch.TabIndex = 197;
            this.textSearch.Text = "Search";
            this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.Location = new System.Drawing.Point(156, 4);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(3, 0, 30, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(677, 59);
            this.lblHeader.TabIndex = 208;
            this.lblHeader.Text = "Depending on what you are going to be using your Windows 11 device for, you can l" +
    "et Junkctrl declutter it.";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // divider
            // 
            this.divider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divider.BackColor = System.Drawing.Color.Gainsboro;
            this.divider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divider.ForeColor = System.Drawing.Color.Black;
            this.divider.Location = new System.Drawing.Point(0, 63);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(1045, 1);
            this.divider.TabIndex = 216;
            this.divider.Text = "div";
            // 
            // lblHideWelcomeMsg
            // 
            this.lblHideWelcomeMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHideWelcomeMsg.AutoEllipsis = true;
            this.lblHideWelcomeMsg.BackColor = System.Drawing.Color.White;
            this.lblHideWelcomeMsg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lblHideWelcomeMsg.FlatAppearance.BorderSize = 0;
            this.lblHideWelcomeMsg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHideWelcomeMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHideWelcomeMsg.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHideWelcomeMsg.ForeColor = System.Drawing.Color.Crimson;
            this.lblHideWelcomeMsg.Location = new System.Drawing.Point(879, 17);
            this.lblHideWelcomeMsg.Name = "lblHideWelcomeMsg";
            this.lblHideWelcomeMsg.Size = new System.Drawing.Size(69, 35);
            this.lblHideWelcomeMsg.TabIndex = 209;
            this.lblHideWelcomeMsg.TabStop = false;
            this.lblHideWelcomeMsg.Text = "OK";
            this.lblHideWelcomeMsg.UseVisualStyleBackColor = false;
            this.lblHideWelcomeMsg.Click += new System.EventHandler(this.lblHideWelcomeMsg_Click);
            // 
            // btnKebapMenu
            // 
            this.btnKebapMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKebapMenu.BackColor = System.Drawing.Color.White;
            this.btnKebapMenu.FlatAppearance.BorderSize = 0;
            this.btnKebapMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKebapMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKebapMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKebapMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKebapMenu.Location = new System.Drawing.Point(990, 12);
            this.btnKebapMenu.Name = "btnKebapMenu";
            this.btnKebapMenu.Size = new System.Drawing.Size(42, 47);
            this.btnKebapMenu.TabIndex = 212;
            this.btnKebapMenu.Text = "...";
            this.btnKebapMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKebapMenu.UseVisualStyleBackColor = false;
            this.btnKebapMenu.Click += new System.EventHandler(this.btnKebapMenu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 32);
            this.label5.TabIndex = 222;
            this.label5.Text = "Junk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 223;
            this.label6.Text = "CTRL";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 38);
            this.btnBack.TabIndex = 219;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 737);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKebapMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblHideWelcomeMsg);
            this.Controls.Add(this.textSearch);
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
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripTextBox textHeaderAppInfo;
        private System.Windows.Forms.ContextMenuStrip contextKebapMenu;
        private System.Windows.Forms.ToolStripMenuItem menuPluginsDir;
        private System.Windows.Forms.ToolStripMenuItem menuPluginDelete;
        private System.Windows.Forms.ToolStripMenuItem menuPluginCreate;
        private System.Windows.Forms.ToolStripMenuItem menuPluginEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKebapMenu;
        private System.Windows.Forms.Button lblHideWelcomeMsg;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lblAboutInfo;
        private System.Windows.Forms.LinkLabel lnkAppMediaTwitter;
        private System.Windows.Forms.LinkLabel lnkAppMediaDonate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _lblAssembly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkUpdateCheck;
        private System.Windows.Forms.ListBox listTopTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTopTenToBin;
        private System.Windows.Forms.Button btnAppMediaGitHub;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.LinkLabel lnkStatus;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckedListBox checkResults;
        private System.Windows.Forms.TreeView tvwFeatures;
        public System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnBack;
    }
}

