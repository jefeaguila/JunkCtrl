using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Junkctrl
{
    internal class ErrorHelper
    {
        private static CheckedListBox target = null;
        private static ErrorHelper instance; // Single instance of ErrorHelper
        private List<string> logList = new List<string>(); // Add a List<string> to store log messages

        // Errorlogger to target richLog
        public void SetTarget(CheckedListBox listBox)
        {
            target = listBox;
        }

        public void Log(string format, params object[] args)
        {
            format += "\r\n";

            try
            {
                target.Invoke(new Action(() =>
                {
                    string logMessage = string.Format(format, args);
                    target.Items.Add(logMessage);
                    logList.Add(logMessage); // Add the log message to the logList
                }));
            }
            catch { }
        }

        // Get the single instance of ErrorHelper
        public static ErrorHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ErrorHelper();
                }
                return instance;
            }
        }

        public List<string> GetLogList()
        {
            return logList; // Return the logList
        }
    }
}