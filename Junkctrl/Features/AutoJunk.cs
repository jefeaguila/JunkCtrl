using Junkctrl;
using System.Linq;
using System.Management.Automation;
using System.Text.RegularExpressions;

namespace Features.Feature.Apps
{
    internal class AutoJunk : FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private readonly PowerShell powerShell = PowerShell.Create();

        public override string ID()
        {
            return "Built-in community scan for junk apps";
        }

        public override string Info()
        {
            return "This option will scan a dynamic signature file for bloatware and compare it with your installed apps. " +
                "The apps listed here are labeled as bloatware by the community. " +
                "Of course, it is up to you whether you actually delete these apps.";
        }

        public override bool CheckFeature()
        {
            var apps = BloatwareList.GetList();

            powerShell.Commands.Clear();
            powerShell.AddCommand("get-appxpackage");
            powerShell.AddCommand("Select").AddParameter("property", "name");

            bool foundMatches = false; // Flag variable to track if matches are found

            foreach (PSObject result in powerShell.Invoke())
            {
                string current = result.Properties["Name"].Value.ToString();

                if (apps.Contains(Regex.Replace(current, "(@{Name=)|(})", "")))
                {
                    logger.Log((Regex.Replace(current, "(@{Name=)|(})", "")));
                    foundMatches = true; // Set the flag to true when a match is found
                }
            }

            if (!foundMatches)
            {
                logger.Log("Your system is free of junk.");
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