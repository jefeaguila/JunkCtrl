using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junkctrl
{
    internal class PluginBase
    {
        public static readonly PowerShell powerShell = PowerShell.Create();

        private LinkLabel pluginStatus;
        private ProgressBar pluginProgress;
        private CheckedListBox pluginResults;

        // Initializing the variables within the class
        public PluginBase(LinkLabel lnkStatus, ProgressBar progressBar, CheckedListBox checkResults)
        {
            this.pluginStatus = lnkStatus;
            this.pluginProgress = progressBar;
            this.pluginResults = checkResults;
        }

        public async Task CheckNodeForSearch(TreeNode node)
        {
            if (node.Checked && node.Nodes.Count == 0 && node.Parent != null)
            {
                await SearchTextPlugins(node);
            }

            foreach (TreeNode childNode in node.Nodes)
            {
                await CheckNodeForSearch(childNode);
            }
        }

        public async Task SearchTextPlugins(TreeNode selectedNode)
        {
            string selectedPlugin = selectedNode.Text;
            string appFolderPath = HelperTool.Utils.Data.PluginsDir;

            string pluginFile = Path.Combine(appFolderPath, $"{selectedPlugin}.txt");

            if (File.Exists(pluginFile))
            {
                int totalCount = File.ReadLines(pluginFile).Count();
                pluginStatus.Text = $"Checking {selectedPlugin}...";
                int processedCount = 0;

                using (StreamReader reader = new StreamReader(pluginFile))
                {
                    string line;
                    bool executePowerShellCode = false;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        string trimmedLine = line.Trim();
                        if (trimmedLine.StartsWith("@copilot"))
                        {
                            DialogResult result = MessageBox.Show("The plugin " + selectedPlugin + " features PowerShell code. Do you want to run the PowerShell code for " + selectedPlugin + "?",
                                 "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (result == DialogResult.Yes)
                            {
                                executePowerShellCode = true;
                            }
                        }
                        else if (await PluginBase.IsAppInstalled(trimmedLine))
                        {
                            pluginResults.Items.Add(trimmedLine, true);
                        }

                        processedCount++;
                        int progress = (int)Math.Floor((double)processedCount / totalCount * 100);
                        pluginProgress.Value = progress;

                        if (executePowerShellCode)
                        {
                            string powerShellCode = await reader.ReadToEndAsync();
                            await ExecutePowerShellCode(powerShellCode);
                            break; // Assuming there is only one @copilot block per file
                        }
                    }
                }
            }
        }

        public bool IsPowerShellPlugin(TreeNode node)
        {
            string pluginName = node.Text;
            string appFolderPath = HelperTool.Utils.Data.PluginsDir;
            string pluginFilePath = Path.Combine(appFolderPath, $"{pluginName}.txt");

            if (File.Exists(pluginFilePath))
            {
                string firstLine = File.ReadLines(pluginFilePath).FirstOrDefault();
                if (firstLine != null && firstLine.Trim().StartsWith("@copilot"))
                {
                    return true;
                }
            }

            return false;
        }

        public async Task ExecutePowerShellPlugin(TreeNode node)
        {
            string pluginName = node.Text;
            string appFolderPath = HelperTool.Utils.Data.PluginsDir;
            string pluginFilePath = Path.Combine(appFolderPath, $"{pluginName}.txt");

            if (File.Exists(pluginFilePath))
            {
                string powerShellCode = File.ReadAllText(pluginFilePath);

                await ExecutePowerShellCode(powerShellCode);
            }
        }

        public string GetPluginInfo(string pluginName)
        {
            string appFolderPath = HelperTool.Utils.Data.PluginsDir;
            string pluginFile = Path.Combine(appFolderPath, $"{pluginName}.txt");

            if (File.Exists(pluginFile))
            {
                using (StreamReader reader = new StreamReader(pluginFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string trimmedLine = line.Trim();
                        if (trimmedLine.StartsWith("#"))
                        {
                            // Return the info section marked with '#'
                            return trimmedLine.Substring(1).Trim();
                        }
                    }
                }
            }

            return string.Empty;
        }

        public static async Task<bool> IsAppInstalled(string appName)
        {
            powerShell.Commands.Clear();
            powerShell.AddCommand("get-appxpackage");
            powerShell.AddCommand("Select").AddParameter("property", "name");

            var invokeTask = Task.Run(() => powerShell.Invoke());

            foreach (PSObject result in await invokeTask)
            {
                string current = result.Properties["Name"].Value.ToString();

                if (string.Equals(current, appName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public async Task ExecutePowerShellCode(string powerShellCode)
        {
            powerShell.Commands.Clear();

            // Split the PowerShell code into lines
            string[] codeLines = powerShellCode.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Skip the first line if it starts with "@copilot"
            IEnumerable<string> filteredCodeLines = codeLines.Skip(codeLines[0].StartsWith("@copilot") ? 1 : 0);

            // Join the filtered code lines back into a single string
            string filteredPowerShellCode = string.Join(Environment.NewLine, filteredCodeLines);

            powerShell.AddScript(filteredPowerShellCode);

            await Task.Run(() => powerShell.Invoke());
        }
    }
}