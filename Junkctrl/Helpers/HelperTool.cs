using Junkctrl;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace HelperTool
{
    internal class Utils

    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        public static class Uri
        {
            public const string URL_ASSEMBLY = "https://raw.githubusercontent.com/builtbybel/JunkCtrl/main/Junkctrl/Properties/AssemblyInfo.cs";
            public const string URL_TWITTER = "https://twitter.com/builtbybel";
            public const string URL_DONATE = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=donate@builtbybel.com&lc=US&item_name=%20Builtbybel&no_note=0&cn=&currency_code=USD&bn=PP-DonationsBF:btn_donateCC_LG.gif:NonHosted";
            public const string URL_GITREPO = "https://github.com/builtbybel/Junkctrl";
            public const string URL_ABOUTAPP = "https://www.builtbybel.com/blog/about-junkctrl";
            public const string URL_GITLATEST = URL_GITREPO + "/releases/latest";
        }

        public static class Data
        {
            public static string DataRootDir = Application.StartupPath +
                                                @"\app\";

            public static string PluginsDir = Application.StartupPath +
                                               @"\plugins\";
        }

        // Create data directory if non present
        public static void CreateDataDir()
        {
            bool dirExists = Directory.Exists(@"app");
            if (!dirExists)
                Directory.CreateDirectory(@"app");
        }

        public static void CheckForUpdates()
        {
            if (IsInet() == true)
            {
                try
                {
                    string assemblyInfo = new WebClient().DownloadString(Utils.Uri.URL_ASSEMBLY);

                    var readVersion = assemblyInfo.Split('\n');
                    var infoVersion = readVersion.Where(t => t.Contains("[assembly: AssemblyFileVersion"));
                    var latestVersion = "";
                    foreach (var item in infoVersion)
                    {
                        latestVersion = item.Substring(item.IndexOf('(') + 2, item.LastIndexOf(')') - item.IndexOf('(') - 3);
                    }

                    if (latestVersion ==
                        Program.GetCurrentVersionTostring())                      // Up-to-date
                    {
                        MessageBox.Show($"No new updates available.");
                    }

                    if (latestVersion !=                                        // Update available
                          Program.GetCurrentVersionTostring())

                    {
                        if (MessageBox.Show($"App version {latestVersion} available.\nDo you want to open the Download page?", "App update available", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            Process.Start(HelperTool.Utils.Uri.URL_GITLATEST);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Checking for App updates failed.\n{ex.Message}");
                }
            }
            else if (IsInet() == false)
            {
                MessageBox.Show($"Problem on Internet connection: Checking for App updates failed");
            }
        }

        // Check Inet
        public static bool IsInet()
        {
            try
            {
                using (var CheckInternet = new WebClient())
                using (CheckInternet.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}