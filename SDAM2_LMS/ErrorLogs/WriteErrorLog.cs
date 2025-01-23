using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SDAM2_LMS.ErrorLog
{
    internal class WriteErrorLog
    {
        public WriteErrorLog(Exception exception)
        {
            this.WriteToLogFile(exception);
        }

        public void WriteToLogFile(Exception exception)
        {
            try
            {
                string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ErrorLogs");
                string fileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}_Error.txt";

                string filePath = Path.Combine(logDirectory, fileName);
                File.WriteAllText(filePath, exception.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while writing to the log: " + ex.Message);
            }
        }
    }
}
