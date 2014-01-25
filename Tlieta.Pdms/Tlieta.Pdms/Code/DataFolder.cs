using System;
using System.Configuration;
using System.IO;
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.Views.Shared
{
    static class DataFolder
    {
        static string path = ConfigurationSettings.AppSettings["DataPath"].ToString();
        static string chartspath = ConfigurationSettings.AppSettings["ChartPath"].ToString();

        public static void CreatePatientDataFolders(int patient)
        {
            try
            {
                Directory.CreateDirectory(path + patient.ToString() + "\\Videos");
                Directory.CreateDirectory(path + patient.ToString() + "\\Photos");
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        public static string GetVideoFolder(string patient)
        {
            try
            {
                return path + patient.ToString() + "\\Videos";
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return "";
            }
        }

        public static string GetPhotoFolder(string patient)
        {
            try
            {
                return path + patient.ToString() + "\\Photos";
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return "";
            }
        }

        public static string GetChartsFolder()
        {
            try
            {
                if (!Directory.Exists(chartspath))
                {
                    Directory.CreateDirectory(chartspath);
                }
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
            return chartspath;
        }
    }
}
