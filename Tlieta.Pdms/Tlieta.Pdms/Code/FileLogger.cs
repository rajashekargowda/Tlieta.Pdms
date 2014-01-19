using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Tlieta.Pdms.Properties;

namespace Tlieta.Pdms.Code
{
    public static class FileLogger
    {
        private static StreamWriter sw = null;
        static string logfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Resources.LogFile);
        /// <summary>
        /// Write the log entry to
        /// customized text-based text file
        /// </summary>
        /// <param name="objException"></param>
        /// <returns>false if the problem persists</returns>
        public static bool LogError(Exception oEx)
        {
            try
            {
                if (File.Exists(logfile))
                {
                    string strException = string.Empty;
                    sw = new StreamWriter(logfile, true);
                    sw.WriteLine("-------------------------------------------------------------------");
                    sw.WriteLine("Source        : " + oEx.Source.ToString().Trim());
                    sw.WriteLine("Method        : " + oEx.TargetSite.Name.ToString());
                    sw.WriteLine("Date        : " + DateTime.Now.ToLongTimeString());
                    sw.WriteLine("Time        : " + DateTime.Now.ToShortDateString());
                    sw.WriteLine("Computer    : " + Dns.GetHostName().ToString());
                    sw.WriteLine("Error        : " + oEx.Message.ToString().Trim());
                    sw.WriteLine("Stack Trace    : " + oEx.StackTrace.ToString().Trim());
                    sw.WriteLine("-------------------------------------------------------------------");
                    sw.Flush();
                    sw.Close();
                }
                else
                {
                    File.Create(logfile);
                    LogError(oEx);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
