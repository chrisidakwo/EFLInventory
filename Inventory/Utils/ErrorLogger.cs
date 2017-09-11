using Inventory.Helpers;
using System;
using System.IO;

namespace Inventory.Utils {
    public static class ErrorLogger {
        public static void LogException(Exception ex, string username, string proceedure) {
            try {
                var log = (string.Format("****************************** {0} ******************************", DateTime.Now.ToString()));
                log += Environment.NewLine;
                log += "Active User: " + username;
                log += Environment.NewLine;
                log += "Proceedure: " + proceedure;
                log += Environment.NewLine;
                log += "\nException Summary:";
                log += Environment.NewLine;
                log += ex.InnerException.Message;
                log += Environment.NewLine;
                if (ex.InnerException != null) {
                    log += Environment.NewLine;
                    log += "INNER EXCEPTION TYPE: ";
                    log += Environment.NewLine;
                    log += ex.InnerException.GetType().ToString();
                    log += Environment.NewLine;
                    log += "EXCEPTION DETAILS: ";
                    log += Environment.NewLine;
                    log += ex.InnerException.ToString();
                    log += Environment.NewLine;
                    log += "SOURCE: ";
                    log += Environment.NewLine;
                    log += ex.InnerException.Source;
                    log += Environment.NewLine;
                    log += "TARGET SITE: ";
                    log += Environment.NewLine;
                    log += ex.InnerException.TargetSite;
                }

                log += Environment.NewLine;
                log += Environment.NewLine;
                log += Environment.NewLine;

                Write(log);
            } catch (Exception) {
            }
        }

        private static void Write(string log) {
            string logPath = @"EFLInventory\Error Log\";
            string logFile = "ErrorLog.txt";

            var SaveFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), logPath);
            IOHelpers.CreateFolder(SaveFolder);

            var path = Path.Combine(SaveFolder, logFile);
            if (!File.Exists(path)) {
                var fs = File.Create(path);
                fs.Close();
                fs.Dispose();
            }

            using (StreamWriter file = new StreamWriter(path, true))
                file.WriteLine(log);
        }
    }
}