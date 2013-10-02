using System.Configuration;
using System.IO;

namespace Tlieta.Pdms.Views.Shared
{
    static class DataFolder
    {
        static string path = ConfigurationSettings.AppSettings["DataPath"].ToString();
        static string chartspath = ConfigurationSettings.AppSettings["ChartPath"].ToString();

        public static void CreatePatientDataFolders(int patient)
        {
            Directory.CreateDirectory(path + patient.ToString() + "\\Videos");
            Directory.CreateDirectory(path + patient.ToString() + "\\Photos");
        }

        public static string GetVideoFolder(string patient)
        {
            return path + patient.ToString() + "\\Videos";
        }

        public static string GetPhotoFolder(string patient)
        {
            return path + patient.ToString() + "\\Photos";
        }

        public static string GetChartsFolder()
        {
            if (!Directory.Exists(chartspath))
            {
                Directory.CreateDirectory(chartspath);
            }
            return chartspath;
        }
    }
}
