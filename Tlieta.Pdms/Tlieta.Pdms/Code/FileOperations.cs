using System;
using System.Diagnostics;
using System.IO;

namespace Tlieta.Pdms.Code
{
    public static class FileOperations
    {
        public static void OpenFolder(string foldername)
        {
            try
            {
                Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = foldername,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        public static FileInfo[] GetFilesinFolder(string folder)
        {
            try
            {
                DirectoryInfo mydir = new DirectoryInfo(folder);
                FileInfo[] f = mydir.GetFiles();
                return f;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return null;
            }
        }

        public static bool CreateDirectory(string folder)
        {
            try
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                return true;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }

        public static bool DeleteDirectory(string folder)
        {
            DirectoryInfo d = null;
            try
            {
                d = new DirectoryInfo(folder);
                d.Delete(true);
                return true;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }

        public static bool CopyFile(string sourcefile, string destination)
        {
            FileInfo f = null;
            try
            {
                if (!Directory.Exists(destination))
                {
                    Directory.CreateDirectory(destination);
                }

                f = new FileInfo(sourcefile);
                f.CopyTo(destination + "\\" + f.Name);
                return true;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }

        public static bool MoveFile(string sourcefile, string destination)
        {
            FileInfo f = null;
            try
            {
                if (!Directory.Exists(destination))
                {
                    Directory.CreateDirectory(destination);
                }

                f = new FileInfo(sourcefile);
                f.MoveTo(destination + "\\" + f.Name);
                return true;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }

        public static bool DeleteFile(string file)
        {
            FileInfo f = null;
            try
            {
                f = new FileInfo(file);
                f.Delete();
                return true;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }
    }
}
