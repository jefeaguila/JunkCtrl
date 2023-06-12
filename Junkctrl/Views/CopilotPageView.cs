using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junkctrl.Views
{
    public partial class CopilotPageView : UserControl
    {
        public List<string> removeAppsList = new List<string>();
        public List<string> removeAppsListAutoDetected = new List<string>();
        private List<string> removeAppsFailedList = new List<string>();
        private List<string> removeAppsSystem = new List<string>();

        private readonly PowerShell powerShell = PowerShell.Create();

        public CopilotPageView()
        {
            InitializeComponent();

            this.InitializeAppsSystem();        // Retrieve hidden systemapps from resource file
            this.InitializeAppsAutoDetected();  // Now the auto detected in MainForm
            this.InitializeApps();              // Yet just the normal

            SetStyle();
        }

        // Some UI nicety
        private void SetStyle()
        {
            btnMeatballMenu.Text = "\uE712";
            btnRefresh.Text = "\uE895";
            btnBack.Text = "\uE72B";
            BackColor =
            listApps.BackColor =
            listRemove.BackColor =
            rtbStatus.BackColor =
                  Color.FromArgb(239, 239, 247);
        }

        private void InitializeApps()
        {
            listApps.Items.Clear();
            powerShell.Commands.Clear();
            powerShell.AddCommand("get-appxpackage");
            powerShell.AddCommand("Select").AddParameter("property", "name");

            foreach (PSObject result in powerShell.Invoke())
            {
                string current = result.ToString();
                // Show ONLY NON-SYSTEM apps by comparing found apps with systemapps.txt
                if (removeAppsSystem != null) if ((removeAppsSystem.Any(current.Contains)) & !checkAppsSystem.Checked) continue;

                if (listApps.Items.Contains(Regex.Replace(current, "(@{Name=)|(})", ""))) continue;
                listApps.Items.Add(Regex.Replace(current, "(@{Name=)|(})", ""));
                removeAppsList.Add(Regex.Replace(current, "(@{Name=)|(})", ""));
            }

            // Compare left and rights apps list and remove differences
            foreach (string itemToRemove in listRemove.Items)
            {
                for (int i = listApps.Items.Count - 1; i >= 0; i--)
                {
                    string item = listApps.Items[i].ToString().Trim();

                    if (itemToRemove.Trim().Contains(item))
                    {
                        listApps.Items.RemoveAt(i);
                    }
                }
            }

            RefreshApps();
        }

        private void InitializeAppsAutoDetected()
        {
            listRemove.Items.AddRange(MainForm.recycleList.ToArray());
            RefreshApps();
        }

        private void InitializeAppsSystem()
        {
            StreamReader Database = null;

            try
            {
                HelperTool.Utils.CreateDataDir();
                Database = File.OpenText(HelperTool.Utils.Data.DataRootDir + "systemApps.txt");
            }
            catch (FileNotFoundException) // Create file if it doesnt exisits
            {
                StreamWriter sw = File.CreateText(HelperTool.Utils.Data.DataRootDir + "systemApps.txt");
                sw.Write(Junkctrl.Properties.Resources.systemApps);    // Populate it with built in preset
                sw.Close();

                Database = File.OpenText(HelperTool.Utils.Data.DataRootDir + "systemApps.txt");
            }
            finally
            {
                if (Database.Peek() > 0) // Exists and not empty
                {
                    string buff;
                    while ((buff = Database.ReadLine()) != null)
                    {
                        removeAppsSystem.Add(buff);
                    }
                };
                Database.Close();
            }
        }

        private void RemoveApps(string app)
        {
            bool error = false;

            using (PowerShell script = PowerShell.Create())
            {
                script.AddScript("Get-AppxPackage | Where-Object { $_.Name -like '*" + app.Trim() + "*' } | Remove-AppxPackage");

                try
                {
                    script.Invoke();
                    error = script.HadErrors;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (error)
            {
                removeAppsFailedList.Add(app);
            }
            else
            {
                removeAppsList.Add(app);
            }

            return;
        }

        private void RefreshApps()
        {
            int installed = listApps.Items.Count;
            int remove = listRemove.Items.Count;
            lblAppsInstalled.Text = installed.ToString() + " apps installed";
            lblAppsBin.Text = "Recycle bin" + " (" + remove.ToString() + ")";

            if (listRemove.Items.Count == 0)
            {
                lblAppsBinOptions.Visible = true;

                rtbStatus.Visible = true;
                listRemove.Visible = false;
            }
            else
            {
                lblAppsBinOptions.Visible = false;

                rtbStatus.Visible = false;
                listRemove.Visible = true;
            }

            if (installed == 0)
                btnMoveAll.Enabled =
                btnMove.Enabled =
                false;
            else
                btnMoveAll.Enabled =
                btnMove.Enabled =
                true;

            if (remove == 0)
                btnRestoreAll.Enabled =
                btnRestore.Enabled =
                false;
            else
                btnRestoreAll.Enabled =
                btnRestore.Enabled =
                true;
        }

        private void btnRestoreAll_Click(object sender, System.EventArgs e)
        {
            foreach (var item in listRemove.Items)
            {
                listApps.Items.Add(item);
            }
            listRemove.Items.Clear();
            RefreshApps();
        }

        private void btnRestore_Click(object sender, System.EventArgs e)
        {
            if (listRemove.Items.Count != 0)
            {
                if (listRemove.SelectedItem == null) listRemove.SelectedIndex = 0;
                while (listRemove.SelectedItem != null)
                {
                    listApps.Items.Add(listRemove.SelectedItem);
                    listRemove.Items.Remove(listRemove.SelectedItem);
                }
                RefreshApps();
            }
        }

        private void btnMove_Click(object sender, System.EventArgs e)
        {
            if (listApps.Items.Count != 0)
            {
                if (listApps.SelectedItem == null) listApps.SelectedIndex = 0;
                while (listApps.SelectedItem != null)
                {
                    listRemove.Items.Add(listApps.SelectedItem);
                    listApps.Items.Remove(listApps.SelectedItem);
                }
                RefreshApps();
            }
        }

        private void btnMoveAll_Click(object sender, System.EventArgs e)
        {
            foreach (var item in listApps.Items)
            {
                listRemove.Items.Add(item);
            }
            listApps.Items.Clear();
            RefreshApps();
        }

        private void checkAppsSystem_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkAppsSystem.Checked)
            {
                MessageBox.Show("Be picky about which System applications to uninstall." +
                "\n\nYou can uninstall most of the built-in apps, even ones that don't normally offer an \"Uninstall\" option." +
                "\n\nNote, however, this app won't allow you to remove a few of the most important built-in apps, like Microsoft Edge, .NET framework, UI.Xaml etc. " +
                "as these apps are needed for the Windows 11 \"Experience\" and for other programs. If you try, you’ll see an error message saying the removal failed.");

                removeAppsList.Clear();
                InitializeAppsSystem();
                InitializeApps();
            }
            else
            {
                removeAppsList.Clear(); InitializeApps();
            }
        }

        private async void btnUninstall_Click(object sender, System.EventArgs e)
        {
            string selectedApps = string.Empty;
            string successList = string.Empty;
            string failedList = string.Empty;

            foreach (string app in listRemove.Items)
            {
                selectedApps += app + Environment.NewLine;
            }
            if (MessageBox.Show("Do you want to uninstall all apps in bin?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                removeAppsList.Clear();
                removeAppsListAutoDetected.Clear();
                removeAppsFailedList.Clear();
                rtbStatus.Visible = true;
                rtbStatus.Clear();
                listRemove.Visible = false;
                btnUninstall.Enabled = false;

                foreach (string app in listRemove.Items)
                {
                    rtbStatus.Text += Environment.NewLine.Trim() + "Uninstalling " + app.ToString();

                    await Task.Run(() => RemoveApps(app));
                }

                foreach (var str in removeAppsList)
                {
                    successList += "-" + str + Environment.NewLine;
                }

                foreach (var str in removeAppsFailedList)
                {
                    failedList += "-" + str + Environment.NewLine;
                }

                // Summary removal process
                string message = string.Format("Summary:\n{0} app(s) has been selected for removal.\n{1} app(s) has been removed.",
                    removeAppsList.Count + removeAppsFailedList.Count, removeAppsList.Count) + Environment.NewLine + Environment.NewLine;

                if (removeAppsList.Count != 0)
                {
                    message += "The folowing app(s) have been removed successfully:" + Environment.NewLine + successList + Environment.NewLine;
                }

                if (removeAppsFailedList.Count != 0)
                {
                    message += "The following app(s) could not be removed: " + Environment.NewLine + failedList;
                    message += Environment.NewLine + "Note, however, this app won't allow you to remove a few of the most important built-in apps, like Microsoft Edge, .NET framework, UI.Xaml etc. " +
                                                     "as these apps are needed for the Windows 11 Experience and for other programs. If you try, you’ll see an error message saying the removal failed.";
                }

                btnRefresh.PerformClick();

                btnUninstall.Enabled = true;
                rtbStatus.Text = message + Environment.NewLine;
                rtbStatus.Text += Environment.NewLine + listApps.Items.Count + " apps are left.\n";
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listApps.Items.Clear();

            foreach (string str in removeAppsList)
            {
                if (str.IndexOf(textSearch.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    listApps.Items.Add(str);
                }
            }
        }

        private void btnMeatballMenu_Click(object sender, EventArgs e)
             => this.contextKebapMenu.Show(Cursor.Position.X, Cursor.Position.Y);

        private void textSearch_Click(object sender, EventArgs e)
               => textSearch.Text = "";

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.pnlForm.Controls.Clear();
            if (mainForm.INavPage != null) mainForm.pnlForm.Controls.Add(mainForm.INavPage);
        }

        private void btnAppOptions_Click(object sender, EventArgs e)
        {
            listApps.Items.Clear();
            listRemove.Items.Clear();
            removeAppsList.Clear();
            removeAppsListAutoDetected.Clear();

            InitializeAppsSystem();
            InitializeApps();
        }

        private void lblAppsBinOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => menuAppsImport.PerformClick();

        private void menuAppsImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = HelperTool.Utils.Data.DataRootDir;

            if (f.ShowDialog() == DialogResult.OK)

            {
                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    listRemove.Items.Clear();

                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listRemove.Items.Add(line);
                        RefreshApps();
                        string compare = listApps.Items.ToString();
                        foreach (string item in listRemove.Items) if (item.Any(compare.Contains)) listApps.Items.Remove(item);
                    }

                    RefreshApps();

                    MessageBox.Show("We've synced your import list with the apps in Recycle bin.\n" +
                        "Please note, that some of these apps may not be installed on your system.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void menuAppsExport_Click(object sender, EventArgs e)
        {
            if (listRemove.Items.Count == 0)
            {
                MessageBox.Show("No apps in Recycle bin found.");
                return;
            }

            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "my-bloatware-list";
            s.Filter = "Text File | *.txt";

            if (s.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(s.OpenFile());
                for (int i = 0; i < listRemove.Items.Count; i++)
                {
                    writer.WriteLine(listRemove.Items[i].ToString());
                }

                writer.Dispose();
                writer.Close();
            }
        }

        private void menuAppsRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will remove all pre-installed apps for the logged in user, except the Microsoft Store. Do you wish to continue?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                using (PowerShell script = PowerShell.Create())
                {
                    this.Enabled = false;
                    script.AddScript("Get-appxprovisionedpackage –online | where-object {$_.packagename –notlike “*store*”} | Remove-AppxProvisionedPackage –online");
                    script.AddScript("Get-AppxPackage | where-object {$_.name –notlike “*store*”} | Remove-AppxPackage");

                    try
                    {
                        script.Invoke();
                        this.Enabled = true;
                        RefreshApps();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }
    }
}