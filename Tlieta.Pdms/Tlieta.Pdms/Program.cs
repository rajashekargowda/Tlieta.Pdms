using System;
using System.Windows.Forms;
using Tlieta.Pdms.DataAccess;

namespace Tlieta.Pdms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            string serialkey = new SharedData().GetSerialKey();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(serialkey));

            //string machineid = FingerPrint.Value();
            //if (serialkey != machineid)
            //{
            //    MessageBox.Show("This machine is not registered");
            //    Application.Exit();
            //}
            //else
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new Form1(serialkey));
            //}
        }
    }
}
