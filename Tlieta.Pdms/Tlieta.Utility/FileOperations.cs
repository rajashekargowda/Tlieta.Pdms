using System;
using System.Diagnostics;
using System.IO;

namespace Tlieta.Utility
{
    public static class FileOperations
    {
        public static void OpenFolder(string foldername)
        {
            Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = foldername,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        public static FileInfo[] GetFilesinFolder(string folder)
        {
            DirectoryInfo mydir = new DirectoryInfo(folder);
            FileInfo[] f = mydir.GetFiles();
            return f;
        }

        public static bool CreateDirectory(string folder)
        {
            try
            {
                if (! Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                return true;
            }
            catch { return false; }
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
            catch { return false; }
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
            catch { return false; }
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
            catch { return false; }
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
            catch { return false; }
        }
    }
}