namespace Junkctrl.Views
{
    partial class CopilotPageView
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem menuAppsExport;
            this.menuAppsRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppsImport = new System.Windows.Forms.ToolStripMenuItem();
            this.contextKebapMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textHeaderAppInfo = new System.Windows.Forms.ToolStripTextBox();
            this.checkAppsSystem = new System.Windows.Forms.CheckBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.lblAppsBinOptions = new System.Windows.Forms.LinkLabel();
            this.listRemove = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRestoreAll = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnMeatballMenu = new System.Windows.Forms.Button();
            this.listApps = new System.Windows.Forms.ListBox();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.lblAppsInstalled = new System.Windows.Forms.Label();
            this.lblAppsBin = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            menuAppsExport = new System.Windows.Forms.ToolStripMenuItem();
            this.contextKebapMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAppsExport
            // 
            menuAppsExport.Name = "menuAppsExport";
            menuAppsExport.Size = new System.Drawing.Size(260, 22);
            menuAppsExport.Text = "Export junk in bin";
            menuAppsExport.Click += new System.EventHandler(this.menuAppsExport_Click);
            // 
            // menuAppsRemoveAll
            // 
            this.menuAppsRemoveAll.Name = "menuAppsRemoveAll";
            this.menuAppsRemoveAll.Size = new System.Drawing.Size(260, 22);
            this.menuAppsRemoveAll.Text = "Uninstall all apps";
            this.menuAppsRemoveAll.Click += new System.EventHandler(this.menuAppsRemoveAll_Click);
            // 
            // menuAppsImport
            // 
            this.menuAppsImport.Name = "menuAppsImport";
            this.menuAppsImport.Size = new System.Drawing.Size(260, 22);
            this.menuAppsImport.Text = "Import junk list";
            this.menuAppsImport.Click += new System.EventHandler(this.menuAppsImport_Click);
            // 
            // contextKebapMenu
            // 
            this.contextKebapMenu.BackColor = System.Drawing.Color.White;
            this.contextKebapMenu.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextKebapMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textHeaderAppInfo,
            this.menuAppsImport,
            menuAppsExport,
            this.menuAppsRemoveAll});
            this.contextKebapMenu.Name = "menuMain";
            this.contextKebapMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextKebapMenu.Size = new System.Drawing.Size(261, 103);
            this.contextKebapMenu.Text = "Info";
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
            this.textHeaderAppInfo.Text = "App-Settings";
            // 
            // checkAppsSystem
            // 
            this.checkAppsSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAppsSystem.AutoSize = true;
            this.checkAppsSystem.FlatAppearance.BorderSize = 0;
            this.checkAppsSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAppsSystem.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAppsSystem.ForeColor = System.Drawing.Color.Gray;
            this.checkAppsSystem.Location = new System.Drawing.Point(36, 751);
            this.checkAppsSystem.Name = "checkAppsSystem";
            this.checkAppsSystem.Size = new System.Drawing.Size(132, 21);
            this.checkAppsSystem.TabIndex = 185;
            this.checkAppsSystem.Text = "Show system apps";
            this.checkAppsSystem.UseVisualStyleBackColor = true;
            this.checkAppsSystem.CheckedChanged += new System.EventHandler(this.checkAppsSystem_CheckedChanged);
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSearch.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.ForeColor = System.Drawing.Color.Gray;
            this.textSearch.Location = new System.Drawing.Point(36, 708);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(118, 24);
            this.textSearch.TabIndex = 196;
            this.textSearch.Text = "Search";
            this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeader.Location = new System.Drawing.Point(98, 4);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(127, 28);
            this.lblHeader.TabIndex = 195;
            this.lblHeader.Text = "All my apps";
            // 
            // btnUninstall
            // 
            this.btnUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUninstall.BackColor = System.Drawing.Color.Transparent;
            this.btnUninstall.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnUninstall.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstall.ForeColor = System.Drawing.Color.Black;
            this.btnUninstall.Location = new System.Drawing.Point(840, 19);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(181, 35);
            this.btnUninstall.TabIndex = 193;
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.UseVisualStyleBackColor = false;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // lblAppsBinOptions
            // 
            this.lblAppsBinOptions.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppsBinOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppsBinOptions.AutoEllipsis = true;
            this.lblAppsBinOptions.BackColor = System.Drawing.Color.Transparent;
            this.lblAppsBinOptions.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppsBinOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblAppsBinOptions.LinkColor = System.Drawing.Color.Gray;
            this.lblAppsBinOptions.Location = new System.Drawing.Point(680, 68);
            this.lblAppsBinOptions.Name = "lblAppsBinOptions";
            this.lblAppsBinOptions.Size = new System.Drawing.Size(303, 18);
            this.lblAppsBinOptions.TabIndex = 159;
            this.lblAppsBinOptions.TabStop = true;
            this.lblAppsBinOptions.Text = "Move the apps you want to uninstall here or import via file.";
            this.lblAppsBinOptions.VisitedLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lblAppsBinOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAppsBinOptions_LinkClicked);
            // 
            // listRemove
            // 
            this.listRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRemove.BackColor = System.Drawing.Color.White;
            this.listRemove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRemove.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRemove.FormattingEnabled = true;
            this.listRemove.ItemHeight = 17;
            this.listRemove.Location = new System.Drawing.Point(596, 90);
            this.listRemove.Name = "listRemove";
            this.listRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRemove.Size = new System.Drawing.Size(425, 612);
            this.listRemove.Sorted = true;
            this.listRemove.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(39, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(42, 38);
            this.btnRefresh.TabIndex = 190;
            this.btnRefresh.Text = "...";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnAppOptions_Click);
            // 
            // btnRestoreAll
            // 
            this.btnRestoreAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreAll.BackColor = System.Drawing.Color.Transparent;
            this.btnRestoreAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRestoreAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestoreAll.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreAll.ForeColor = System.Drawing.Color.Black;
            this.btnRestoreAll.Location = new System.Drawing.Point(483, 320);
            this.btnRestoreAll.Name = "btnRestoreAll";
            this.btnRestoreAll.Size = new System.Drawing.Size(89, 23);
            this.btnRestoreAll.TabIndex = 188;
            this.btnRestoreAll.Text = "<< Restore all";
            this.btnRestoreAll.UseVisualStyleBackColor = false;
            this.btnRestoreAll.Click += new System.EventHandler(this.btnRestoreAll_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.Location = new System.Drawing.Point(483, 349);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(89, 23);
            this.btnRestore.TabIndex = 187;
            this.btnRestore.Text = "< Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveAll.BackColor = System.Drawing.Color.Transparent;
            this.btnMoveAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMoveAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMoveAll.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAll.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAll.Location = new System.Drawing.Point(483, 208);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(89, 23);
            this.btnMoveAll.TabIndex = 189;
            this.btnMoveAll.Text = "Move all >>";
            this.btnMoveAll.UseVisualStyleBackColor = false;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMove.BackColor = System.Drawing.Color.Transparent;
            this.btnMove.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMove.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.ForeColor = System.Drawing.Color.Black;
            this.btnMove.Location = new System.Drawing.Point(483, 237);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(89, 23);
            this.btnMove.TabIndex = 186;
            this.btnMove.Text = "Move >";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnMeatballMenu
            // 
            this.btnMeatballMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMeatballMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMeatballMenu.FlatAppearance.BorderSize = 0;
            this.btnMeatballMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMeatballMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeatballMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeatballMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMeatballMenu.Location = new System.Drawing.Point(979, 60);
            this.btnMeatballMenu.Name = "btnMeatballMenu";
            this.btnMeatballMenu.Size = new System.Drawing.Size(42, 30);
            this.btnMeatballMenu.TabIndex = 213;
            this.btnMeatballMenu.Text = "...";
            this.btnMeatballMenu.UseVisualStyleBackColor = false;
            this.btnMeatballMenu.Click += new System.EventHandler(this.btnMeatballMenu_Click);
            // 
            // listApps
            // 
            this.listApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listApps.BackColor = System.Drawing.Color.White;
            this.listApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listApps.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listApps.ForeColor = System.Drawing.Color.Black;
            this.listApps.FormattingEnabled = true;
            this.listApps.ItemHeight = 17;
            this.listApps.Location = new System.Drawing.Point(36, 90);
            this.listApps.Name = "listApps";
            this.listApps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listApps.Size = new System.Drawing.Size(425, 612);
            this.listApps.Sorted = true;
            this.listApps.TabIndex = 13;
            // 
            // rtbStatus
            // 
            this.rtbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbStatus.BackColor = System.Drawing.Color.White;
            this.rtbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbStatus.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStatus.ForeColor = System.Drawing.Color.Black;
            this.rtbStatus.HideSelection = false;
            this.rtbStatus.Location = new System.Drawing.Point(596, 90);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.ReadOnly = true;
            this.rtbStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbStatus.Size = new System.Drawing.Size(425, 612);
            this.rtbStatus.TabIndex = 139;
            this.rtbStatus.Text = "";
            this.rtbStatus.Visible = false;
            // 
            // lblAppsInstalled
            // 
            this.lblAppsInstalled.AutoSize = true;
            this.lblAppsInstalled.BackColor = System.Drawing.Color.Transparent;
            this.lblAppsInstalled.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppsInstalled.Location = new System.Drawing.Point(36, 71);
            this.lblAppsInstalled.Name = "lblAppsInstalled";
            this.lblAppsInstalled.Size = new System.Drawing.Size(70, 15);
            this.lblAppsInstalled.TabIndex = 214;
            this.lblAppsInstalled.Text = "Installed apps";
            // 
            // lblAppsBin
            // 
            this.lblAppsBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppsBin.AutoSize = true;
            this.lblAppsBin.BackColor = System.Drawing.Color.Transparent;
            this.lblAppsBin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppsBin.Location = new System.Drawing.Point(593, 71);
            this.lblAppsBin.Name = "lblAppsBin";
            this.lblAppsBin.Size = new System.Drawing.Size(67, 13);
            this.lblAppsBin.TabIndex = 215;
            this.lblAppsBin.Text = "Apps in bin";
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
            this.btnBack.TabIndex = 220;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CopilotPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMeatballMenu);
            this.Controls.Add(this.lblAppsBin);
            this.Controls.Add(this.lblAppsInstalled);
            this.Controls.Add(this.lblAppsBinOptions);
            this.Controls.Add(this.listApps);
            this.Controls.Add(this.checkAppsSystem);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRestoreAll);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnMoveAll);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.listRemove);
            this.Controls.Add(this.rtbStatus);
            this.Name = "CopilotPageView";
            this.Size = new System.Drawing.Size(1054, 795);
            this.contextKebapMenu.ResumeLayout(false);
            this.contextKebapMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuAppsRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem menuAppsImport;
        private System.Windows.Forms.ContextMenuStrip contextKebapMenu;
        private System.Windows.Forms.CheckBox checkAppsSystem;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.LinkLabel lblAppsBinOptions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRestoreAll;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.Button btnMove;
        public System.Windows.Forms.ListBox listRemove;
        private System.Windows.Forms.Button btnMeatballMenu;
        private System.Windows.Forms.ToolStripTextBox textHeaderAppInfo;
        private System.Windows.Forms.ListBox listApps;
        public System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Label lblAppsInstalled;
        private System.Windows.Forms.Label lblAppsBin;
        private System.Windows.Forms.Button btnBack;
    }
}
