using Junkctrl;
using System;
using System.IO;
using System.Linq;
using System.Management.Automation;

namespace Features.Feature.Apps
{
    internal class PrivateJunk : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private readonly PowerShell powerShell = PowerShell.Create();

        public override string ID()
        {
            return "Built-in private scan for junk apps";
        }

        public override string Info()
        {
            return "This option will search a static signature file for junk \"badApps\" located in the \"data\" data directory of Junkctrl. " +
                "The file is a plain text file that can be modified with any text editor. " +
                "It contains the app names and corresponding PowerShell commands for removal. So you have full control.";
        }

        public override bool CheckFeature()
        {
            try
            {
                string bloatyFilePath = Path.Combine(HelperTool.Utils.Data.DataRootDir, "badApps.txt");
                if (!File.Exists(bloatyFilePath))
                {
                    logger.Log("[!] Could not find private signature file \"badApps.txt\" in " + HelperTool.Utils.Data.DataRootDir);
                    return false; // Indicate failure
                }

                string[] num = File.ReadAllLines(bloatyFilePath);

                using (PowerShell powerShell = PowerShell.Create())
                {
                    powerShell.AddCommand("get-appxpackage")
                        .AddCommand("Select").AddParameter("property", "name");

                 //   bool foundMatch = false;

                    foreach (string line in num)
                    {
                        string[] package = line.Split(':');
                        string appx = package[0].Trim();

                        //bool matchFound = false;
                        foreach (PSObject result in powerShell.Invoke())
                        {
                            string current = result.ToString(); // Get the current app

                            if (current.Contains(appx))
                            {
                                logger.Log(appx);
                              //  foundMatch = true;
                                break;
                            }
                        }

                       /* if (!matchFound)
                        {
                            logger.Log("The appx \"" + appx + "\" was not found.");
                        }*/
                    }
                    /*if (!foundMatch)
                        {
                         logger.Log("[!] Your private scan is free of junk.");
                        }
                       }
                        */
                }
            }
            catch (Exception ex)
            {
                logger.Log("[!] An error occurred: " + ex.Message);
                return false; // Indicate failure
            }

            return true;
        }


        public override bool DoFeature()
        {
            return true;
        }

        public override bool UndoFeature()
        {
            return false;
        }
    }
}