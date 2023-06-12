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
            _Assembly.Text = "Version " + Program.GetCurrentVersionTostring();
            this.AddJunkScans();

            this.SetStyle();
        }

        private void SetStyle()
        {
            btnKebapMenu.Text = "\u22ee";
            btnBack.Text = "\uE72B";

            pnlForm.BackColor =
            pnlMain.BackColor =
            tvwFeatures.BackColor =
            checkResults.BackColor =
            pnlCapabilities.BackColor =
                  Color.FromArgb(239, 239, 247);
            pbBackground.ImageLocation = "https://github.com/builtbybel/BloatyNosy/blob/main/assets/BackgroundImageA.png?raw=true";

            INavPage = pnlForm.Controls[0];              // Set default NavPage
            logger.SetTarget(checkResults);               // Add results to checkedListBox
        }

        public void SetView(Control View)
        {
            var control = View as Control;

            control.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            control.Dock = DockStyle.Fill;
            INavPage.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            INavPage.Dock = DockStyle.Fill;

            pnlForm.Controls.Clear();
            pnlForm.Controls.Add(View);
        }

        public void AddJunkScans()
        {
            tvwFeatures.Nodes.Clear();
            tvwFeatures.BeginUpdate();

            // Default auto scans
            TreeNode root = new TreeNode("Windows 11 " + OsHelper.GetVersion(), new TreeNode[] {
                new FeatureNode(new Features.Feature.Apps.AutoJunk()),
                new FeatureNode(new Features.Feature.Apps.PrivateJunk()),
            })

            {
                Checked = true,
            };

            // Skip if the "PluginsDir" directory does not exist
            if (!Directory.Exists(HelperTool.Utils.Data.PluginsDir))
            {
                tvwFeatures.Nodes.Add(root);
                AddCopilotNode(root);
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
            AddCopilotNode(root);
            ExpandTreeViewNodes();
            tvwFeatures.Nodes[0].NodeFont = new Font(tvwFeatures.Font, FontStyle.Bold);
            tvwFeatures.EndUpdate();
        }

        // Use Copilot for skipping auto scans
        private void AddCopilotNode(TreeNode root)
        {
            TreeNode copilotNode = new TreeNode("Skip and use Copilot ");
            root.Nodes.Add(copilotNode);
            TreeNodeTheming.RemoveCheckmarks(tvwFeatures, copilotNode);
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
                lnkHeader.Text = info;
            }
            else if (e.Node.Parent != null && e.Node.Parent.Text == "Plugins")
            {
                // Get the plugin name
                string pluginName = e.Node.Text;

                // Get the plugin info using the GetPluginInfo method
                string info = pluginBase.GetPluginInfo(pluginName);

                // Display the info
                lnkHeader.Text = info;
            }
            else
            {
                lnkHeader.Text = "Idle.";
            }

            switch (e.Node.Text)
            {
                case "Skip and use Copilot ":
                    this.SetView(new CopilotPageView());  // Set Copilot view
                    break;

                default:
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

            // Remove checkmarks from copilot child node
            TreeNodeTheming.RemoveCheckmarks(tvwFeatures, tvwFeatures.Nodes[0].Nodes[3]);
            tvwFeatures.EndUpdate();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            Reset();
            btnBack.PerformClick();
            pnlCapabilities.SendToBack();
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
                    // node.ForeColor = Color.Crimson;
                }
                else
                {
                    node.Checked = false;
                    // node.ForeColor = Color.Gray;
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
            lnkStatus.Text = "Scans completed. Click to switch view.";
            btnBack.Enabled = true;

            int itemsInRecycleList = checkResults.Items.Count;
            lblItemsInRecycleList.Text = itemsInRecycleList.ToString() + " junk apps found.";
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

                    if (item.Contains("[!]") || (item.Contains("(We recommend uninstalling this app)")))
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
            pnlCapabilities.Visible = !pnlCapabilities.Visible;

            if (pnlCapabilities.Visible)
            {
                pnlCapabilities.BringToFront();
                checkResults.Visible = true;
            }
            else
            {
                checkResults.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
     
            pnlForm.Controls.Add(INavPage);
            ToggleControlVisibility();
        }

        public void ClearPanel2Controls()
            => pnlForm.Controls.Clear();

        public void AddINavPageToPanel2()
           => pnlForm.Controls.Add(INavPage);

        private void lnkStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
           => btnBack.PerformClick();

        private void lnkHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
          => MessageBox.Show(lnkHeader.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void btnKebapMenu_Click(object sender, EventArgs e)
             => this.contextKebapMenu.Show(Cursor.Position.X, Cursor.Position.Y);

        private void lnkAppMediaTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_TWITTER);

        private void _Assembly_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => HelperTool.Utils.CheckForUpdates();

        private void lnkAppMediaDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
             => Process.Start(HelperTool.Utils.Uri.URL_DONATE);

        private void lnkAppMediaGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
          => Process.Start(HelperTool.Utils.Uri.URL_GITREPO);

        private void lnkHeader_Click(object sender, EventArgs e)
         => MessageBox.Show(lnkHeader.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void lnkAddTopTenToBin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var apps = JunkTopTen.GetList();

            foreach (string app in apps)
            {
                recycleList.Add(app);
            }

            this.SetView(new CopilotPageView());
        }
    }
}