using Features.Feature;
using HelperTool;
using Junkctrl.ITreeNode;
using Junkctrl.Theming;
using Junkctrl.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junkctrl
{
    public partial class MainForm : Form
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        public static List<string> recycleList = new List<string>();

        public Control INavPage;
        private PluginBase pluginBase;
        private int progression = 0;
        private int progressionIncrease = 0;

        public MainForm()
        {
            InitializeComponent();

            pluginBase = new PluginBase(lnkStatus, progressBar, checkResults);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            _lblAssembly.Text = "Version " + Program.GetCurrentVersionTostring();
            this.AddJunkScans();
            this.AddJunkTopTen();

            this.SetStyle();
        }

        private void SetStyle()
        {
            btnKebapMenu.Text = "\u22ee";
            btnBack.Text = "\uE72B";

            INavPage = sc.Panel2.Controls[0];              // Set default NavPage
            logger.SetTarget(checkResults);               // Add results to checkedListBox

            // Enables double-buffering here in sc.panel2 using reflection => move later to e.g. DoubleBufferedSplitContainer
            typeof(Panel).InvokeMember("DoubleBuffered",
             BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
             null, sc.Panel2, new object[] { true });
        }

        public void SetView(Control View)
        {
            var control = View as Control;

            control.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            control.Dock = DockStyle.Fill;
            INavPage.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            INavPage.Dock = DockStyle.Fill;

            sc.Panel2.Controls.Clear();
            sc.Panel2.Controls.Add(View);
        }

        public void AddJunkScans()
        {
            tvwFeatures.Nodes.Clear();
            tvwFeatures.BeginUpdate();

            // Default auto scans
            TreeNode root = new TreeNode("Windows 11 " + OsHelper.GetVersion(), new TreeNode[] {
                new FeatureNode(new Features.Feature.Apps.AutoApps()),
                new FeatureNode(new Features.Feature.Apps.PrivateApps()),
            })

            {
                Checked = true,
            };

            // Skip if the "PluginsDir" directory does not exist
            if (!Directory.Exists(HelperTool.Utils.Data.PluginsDir))
            {
                tvwFeatures.Nodes.Add(root);
                AddAssistantNode(root);
                ExpandTreeViewNodes();
                tvwFeatures.Nodes[0].NodeFont = new Font(tvwFeatures.Font, FontStyle.Bold);
                tvwFeatures.EndUpdate();
                return;
            }

            // If the "PluginsDir" directory exists, continue with the plugin functionality
            if (Directory.GetFiles(HelperTool.Utils.Data.PluginsDir, "*.txt").Length > 0)
            {
                TreeNode pluginsNode = CreatePluginsNode();
                root.Nodes.Add(pluginsNode);
            }
            tvwFeatures.Nodes.Add(root);
            AddAssistantNode(root);
            ExpandTreeViewNodes();
            tvwFeatures.Nodes[0].NodeFont = new Font(tvwFeatures.Font, FontStyle.Bold);
            tvwFeatures.EndUpdate();
        }

        // Use Assistant for skipping auto scans
        private void AddAssistantNode(TreeNode root)
        {
            TreeNode assistantNode = new TreeNode("Skip and use Copilot ");
            root.Nodes.Add(assistantNode);
            TreeNodeTheming.RemoveCheckmarks(tvwFeatures, assistantNode);
        }

        // Add the Plugins node (if available)
        private TreeNode CreatePluginsNode()
        {
            TreeNode pluginsNode = new TreeNode("Plugins");
            string pluginDirectory = HelperTool.Utils.Data.PluginsDir;
            foreach (string textFile in Directory.GetFiles(pluginDirectory, "*.txt"))
            {
                pluginsNode.Nodes.Add(new TreeNode(Path.GetFileNameWithoutExtension(textFile)));
            }
            return pluginsNode;
        }

        private void ExpandTreeViewNodes()
        {
            foreach (TreeNode tn in tvwFeatures.Nodes)
            {
                tn.ExpandAll();
            }
        }

        private void tvwFeatures_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Check if the clicked TreeNode is a FeatureNode
            if (e.Node is FeatureNode clickedFeatureNode)
            {
                // Get the FeatureNode's FeatureBase object
                FeatureBase feature = clickedFeatureNode.Feature;

                // Get the information from the Info() method
                string info = feature.Info();
                lnkStatus.Text = info;
            }
            else if (e.Node.Parent != null && e.Node.Parent.Text == "Plugins")
            {
                // Get the plugin name
                string pluginName = e.Node.Text;

                // Get the plugin info using the GetPluginInfo method
                string info = pluginBase.GetPluginInfo(pluginName);

                // Display the info
                lnkStatus.Text = info;
            }
            else
            {
                lnkStatus.Text = "Idle.";
            }

            switch (e.Node.Text)
            {
                case "Skip and use Copilot ":
                    this.SetView(new CopilotPageView());  // Set Assistant view
                    sc.Panel1Collapsed = true;
                    break;

                default:
                    sc.Panel2.Controls.Clear();
                    if (INavPage != null) sc.Panel2.Controls.Add(INavPage);
                    break;
            }
        }

        private void tvwFeatures_AfterCheck(object sender, TreeViewEventArgs e)
        {
            tvwFeatures.BeginUpdate();

            foreach (System.Windows.Forms.TreeNode child in e.Node.Nodes)
            {
                child.Checked = e.Node.Checked;
            }

            // Remove checkmarks from assistant child node
            TreeNodeTheming.RemoveCheckmarks(tvwFeatures, tvwFeatures.Nodes[0].Nodes[3]);
            tvwFeatures.EndUpdate();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            Reset();
            checkResults.Items.Clear();
            logger.GetLogList().Clear();
            btnSearch.Enabled = false;
            int performFeaturesCount = 0;

            List<FeatureNode> selectedFeatures = CollectFeatureNodes();

            lnkStatus.Text = $"{selectedFeatures.Count} auto scans are running...";
            foreach (FeatureNode node in selectedFeatures)
            {
                var feature = node.Feature;
                ConfiguredTaskAwaitable<bool> analyzeTask = Task<bool>.Factory.StartNew(() => feature.CheckFeature()).ConfigureAwait(true);

                bool shouldPerform = await analyzeTask;
                lnkStatus.Text = "Check " + feature.ID();

                if (shouldPerform)
                {
                    performFeaturesCount += 1;
                    node.ForeColor = Color.Crimson;
                }
                else
                {
                    node.Checked = false;
                    node.ForeColor = Color.Gray;
                }
            }

            // Pass corresponding Plugin instances
            foreach (TreeNode node in tvwFeatures.Nodes)
            {
                await pluginBase.CheckNodeForSearch(node);
            }

            tvwFeatures.SelectedNode = tvwFeatures.Nodes[0];
            DoProgress(100);

            btnSearch.Enabled = true;
            lnkStatus.Text = "Scans completed. See details below.\r\n";
            btnBack.Enabled = true;
            btnBack.PerformClick();
        }

        private void SelectFeatureNodes(TreeNodeCollection trNodeCollection, bool isCheck)
        {
            foreach (TreeNode trNode in trNodeCollection)
            {
                trNode.Checked = isCheck;
                if (trNode.Nodes.Count > 0)
                    SelectFeatureNodes(trNode.Nodes, isCheck);
            }
        }

        private List<FeatureNode> CollectFeatureNodes()
        {
            List<FeatureNode> selectedFeatures = new List<FeatureNode>();

            foreach (TreeNode treeNode in tvwFeatures.Nodes.All())
            {
                if (treeNode.Checked && treeNode.GetType() == typeof(FeatureNode))
                {
                    selectedFeatures.Add((FeatureNode)treeNode);
                }
            }

            progressionIncrease = (int)Math.Floor(100.0f / selectedFeatures.Count);

            return selectedFeatures;
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            Reset();
            recycleList.Clear();
            for (int i = 0; i < checkResults.Items.Count; i++)
            {
                if (checkResults.GetItemChecked(i))
                {
                    string item = checkResults.Items[i].ToString();

                    if (item.Contains("[!]"))
                    {
                        // Skip adding the item to the recycleList
                        continue;
                    }

                    recycleList.Add(item);
                    IncrementProgress();
                }
            }
            DoProgress(100);

            if (recycleList.Count == 0)
            {
                MessageBox.Show("You haven't done a search yet or added anything to the bin.\nAccordingly the recycle list is empty. Please select at least one item.");
            }
            else
            {
                this.SetView(new CopilotPageView());
            }
        }

        private void Reset()
        {
            lnkStatus.Visible = true;
            progression = 0;
            progressionIncrease = 0;

            progressBar.Value = 0;
            progressBar.Visible = true;
            checkResults.Visible = true;
            checkResults.Text = "";
        }

        private void DoProgress(int value)
        {
            progression = value;
            progressBar.Value = progression;
        }

        private void IncrementProgress()
        {
            progression += progressionIncrease;
            progressBar.Value = progression;
        }

        public void ToggleControlVisibility()
        {
            tvwFeatures.Visible = !tvwFeatures.Visible;

            if (tvwFeatures.Visible)
            {
                tvwFeatures.BringToFront();
            }
            else
            {
                checkResults.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            sc.Panel2.Controls.Clear();
            sc.Panel2.Controls.Add(INavPage);
            sc.Panel1Collapsed = false;
            ToggleControlVisibility();
        }

        public void ClearPanel2Controls()
        => sc.Panel2.Controls.Clear();

        public void AddINavPageToPanel2()
           => sc.Panel2.Controls.Add(INavPage);

        private void lnkStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
           => btnBack.PerformClick();

        private void btnAppMediaGitHub_Click(object sender, EventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_GITREPO);

        private void lnkAppMediaTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_TWITTER);

        private void lnkUpdateCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => HelperTool.Utils.CheckForUpdates();

        private void lnkAppMediaDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_DONATE);

        private void btnKebapMenu_Click(object sender, EventArgs e)
            => this.contextKebapMenu.Show(Cursor.Position.X, Cursor.Position.Y);

        private void lblHideWelcomeMsg_Click(object sender, EventArgs e)
        {
            lblHeader.Visible = false;
            lblHideWelcomeMsg.Visible = false;
        }

        private void btnAddTopTenToBin_Click(object sender, EventArgs e)
        {
            foreach (var item in listTopTen.SelectedItems)
            {
                recycleList.Add(item.ToString());
            }
            this.SetView(new CopilotPageView());
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            List<string> logList = logger.GetLogList();
            checkResults.Items.Clear();

            foreach (string str in logList)
            {
                if (str.IndexOf(textSearch.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    checkResults.Items.Add(str);
                }
            }
        }

        private void textSearch_Click(object sender, EventArgs e)
             => textSearch.Text = "";

        private void AddJunkTopTen()
        {
            var apps = BloatwareTopTen.GetList();

            foreach (string app in apps)
            {
                listTopTen.Items.Add(app);
            }
        }

        private void menuPluginsDir_Click(object sender, EventArgs e)
        {
            // Open the plugins folder
            string pluginsFolder = Path.GetDirectoryName(HelperTool.Utils.Data.PluginsDir);
            Process.Start(pluginsFolder);
        }

        private void DeleteSelectedPlugin(TreeNode selectedNode)
        {
            string selectedPlugin = selectedNode.Text;
            string appFolderPath = HelperTool.Utils.Data.PluginsDir;

            string pluginFile = Path.Combine(appFolderPath, $"{selectedPlugin}.txt");

            if (File.Exists(pluginFile))
            {
                // Delete the plugin file
                File.Delete(pluginFile);

                selectedNode.Remove();
            }
        }

        private void menuPluginDelete_Click(object sender, EventArgs e)
        {
            if (tvwFeatures.SelectedNode != null)
            {
                TreeNode selectedNode = tvwFeatures.SelectedNode;

                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected plugin?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteSelectedPlugin(selectedNode);
                }
            }
        }

        private void menuPluginCreate_Click(object sender, EventArgs e)
        {
            // Get the path to the plugins folder
            string appFolderPath = HelperTool.Utils.Data.PluginsDir;

            // Construct the path to the new plugin file
            string pluginFile = Path.Combine(appFolderPath, $"New.txt");

            // Create an empty plugin file
            File.Create(pluginFile).Close();

            // Open the plugin file using Notepad
            Process.Start("notepad.exe", pluginFile);

            // Refresh
            tvwFeatures.Nodes.Clear();
            AddJunkScans();
        }

        private void menuPluginEdit_Click(object sender, EventArgs e)
        {
            // Get the selected node from the TreeView
            TreeNode selectedNode = tvwFeatures.SelectedNode;

            // Ensure a node is selected
            if (selectedNode != null)
            {
                // Get the path to the plugins folder
                string appFolderPath = HelperTool.Utils.Data.PluginsDir;

                // Construct the path to the selected plugin file
                string selectedPlugin = selectedNode.Text;
                string pluginFile = Path.Combine(appFolderPath, $"{selectedPlugin}.txt");

                if (File.Exists(pluginFile))
                {
                    Process.Start("notepad.exe", pluginFile);
                }
                else
                {
                    MessageBox.Show("Selected plugin file does not exist.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No plugin selected.", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}