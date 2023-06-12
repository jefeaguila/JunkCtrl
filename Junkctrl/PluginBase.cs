using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Text.RegularExpressions;
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

                        // Run PowerShell code in plugin marked with @copilot
                        if (trimmedLine.StartsWith("@copilot"))
                        {
                            DialogResult result = MessageBox.Show("The plugin " + selectedPlugin + " features PowerShell code. Do you want to run the PowerShell code for " + selectedPlugin + "?",
                                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (result == DialogResult.Yes)
                            {
                                executePowerShellCode = true;
                            }
                        }
                        // PowerShell search with Get-AppxPackage cmdlet
                        else if (trimmedLine.StartsWith("Get-AppxPackage"))
                        {
                            string[] appNames = trimmedLine.Split(',');
                            foreach (string appName in appNames)
                            {
                                string partialAppName = ExtractPartialAppName(appName.Trim());
                                if (!string.IsNullOrEmpty(partialAppName))
                                {
                                    await CheckAppxPackage(partialAppName);
                                }
                            }
                        }
                        // Search for Win32 apps: Uninstall currently NOT implemented!
                        // Search for Win32 apps: Uninstall currently NOT implemented!
                        else if (trimmedLine.Contains("*") || trimmedLine.Contains("?"))
                        {
                            string[] appNames = trimmedLine.Split(',');
                            StringBuilder uninstallApps = new StringBuilder();
                            bool containsWin32Apps = false;

                            foreach (string appName in appNames)
                            {
                                await CheckWin32Apps(appName.Trim());
                            }

                            // Iterate through the pluginResults list box items and add apps to uninstallApps StringBuilder
                            foreach (string foundApp in pluginResults.Items)
                            {
                                if (foundApp.Contains("We recommend uninstalling this app"))
                                {
                                    uninstallApps.AppendLine("+ " + foundApp);
                                    containsWin32Apps = true;
                                }
                            }

                            if (containsWin32Apps)
                            {
                                string introText = "The following apps should be uninstalled manually:\nWe've opened the Windows 11 > Uninstall apps page.\n\n";
                                string filePath = Path.Combine(Path.GetTempPath(), $"{selectedPlugin}_uninstall_apps.txt");
                                string settingsAppPath = Environment.ExpandEnvironmentVariables(@"%windir%\explorer.exe");
                                string uninstallAppsUri = "ms-settings:appsfeatures-app";

                                File.WriteAllText(filePath, introText + uninstallApps.ToString());
                                Process.Start(settingsAppPath, uninstallAppsUri);
                                Process.Start("notepad.exe", filePath);
                            }
                        }



                        else
                        {
                            // Normal search: check if the trimmed line matches installed appx packages
                            string[] appNames = trimmedLine.Split(',');
                            foreach (string appName in appNames)
                            {
                                string trimmedAppName = appName.Trim();
                                if (await IsAppInstalled(trimmedAppName))
                                {
                                    pluginResults.Items.Add(trimmedAppName, true);
                                }
                            }
                        }

                        processedCount++;
                        int progress = (int)Math.Floor((double)processedCount / totalCount * 100);
                        pluginProgress.Value = progress;

                        if (executePowerShellCode)
                        {
                            string powerShellCode = await reader.ReadToEndAsync();
                            await ExecutePowerShellCode(powerShellCode);
                            break;
                        }
                    }
                }
            }
        }

        /* Used for enhancing plugin engine with PowerShell cmdlets in format Get-AppxPackage –Name *microsoft*
         Extracts the partial app name from the line using a regex pattern */
        private string ExtractPartialAppName(string line)
        {
            string pattern = @"\*(.*?)\*";
            Match match = Regex.Match(line, pattern);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            return null;
        }

        /* Used for enhancing plugin engine with PowerShell cmdlets in format Get-AppxPackage –Name *microsoft*
       Use PowerShell command to filter appx packages by partial app name */
        public async Task CheckAppxPackage(string partialAppName)
        {
            powerShell.Commands.Clear();
            powerShell.AddScript($"Get-AppxPackage | Where-Object {{ $_.Name -like '*{partialAppName}*' }}");

            var invokeTask = Task.Run(() => powerShell.Invoke());

            foreach (PSObject result in await invokeTask)
            {
                string appName = result.Properties["Name"].Value.ToString();
                pluginResults.Items.Add(appName, true);
            }
        }

        public bool IsPowerShellPlugin(TreeNode node)
        {
            string pluginName = node.Text;
            string appFolderPath = HelperTool.Utils.Data.PluginsDir;
            string pluginFilePath = Path.Combine(appFolderPath, $"{pluginName}.txt");

            if (File.Exists(pluginFilePath))
            {
                using (StreamReader reader = new StreamReader(pluginFilePath))
                {
                    string firstLine = reader.ReadLine();
                    if (firstLine != null && firstLine.Trim().StartsWith("Get-AppxPackage"))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Comment section to Gget plugin info from the plugin file
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

        // Check if the appx is installed
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

        // Allow running PowerShell code inside the plugin file
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

        // Search for Win32 apps
        public async Task CheckWin32Apps(string partialAppName)
        {
            await Task.Run(() =>
            {
                // Local machine hive
                CheckRegistryUninstallKey(Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall"), partialAppName);

                // Current user hive
                CheckRegistryUninstallKey(Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall"), partialAppName);

                // 32-bit apps installed onto 64-bit Operating System
                CheckRegistryUninstallKey(Registry.LocalMachine.OpenSubKey("Software\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\Uninstall"), partialAppName);
            });
        }

        // Search for Win32 apps in the registry
        private void CheckRegistryUninstallKey(RegistryKey uninstallKey, string partialAppName)
        {
            if (uninstallKey != null)
            {
                string[] subKeyNames = uninstallKey.GetSubKeyNames();

                foreach (string subKeyName in subKeyNames)
                {
                    RegistryKey appKey = uninstallKey.OpenSubKey(subKeyName);

                    if (appKey != null)
                    {
                        string displayName = appKey.GetValue("DisplayName") as string;

                        if (!string.IsNullOrEmpty(displayName) && WildcardMatch(displayName, partialAppName))
                        {
                            pluginResults.BeginInvoke(new Action(() => pluginResults.Items.Add(displayName + " (We recommend uninstalling this app)", true)));
                        }

                        appKey.Close();
                    }
                }

                uninstallKey.Close();
            }
        }

        // Check if the win32 app names matches the wildcard pattern
        private bool WildcardMatch(string input, string wildcard)
        {
            // Escape special characters and convert '*' to '.*' (matches any sequence of characters)
            // and '?' to '.' (matches any single character)
            string pattern = "^" + Regex.Escape(wildcard).Replace("\\*", ".*").Replace("\\?", ".") + "$";

            // Use a regular expression with the IgnoreCase option to perform the matching
            return Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase);
        }
    }
}