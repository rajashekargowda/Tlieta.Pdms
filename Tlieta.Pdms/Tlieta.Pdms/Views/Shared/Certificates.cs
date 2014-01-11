using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.RichTextBox.FormatProviders;
using Telerik.WinControls.RichTextBox.FileFormats.OpenXml.Docx;
using System.IO;
using System.Diagnostics;
using Tlieta.Pdms.Properties;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class Certificates : UserControl
    {
        public Certificates()
        {
            InitializeComponent();
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            PrepareDocument((Bitmap)Resources.letterpadheader);
        }

        private void PrepareDocument(Bitmap image)
        {
            this.docCertificate.InsertImage(image);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            IDocumentFormatProvider provider = new DocxFormatProvider();
            using (Stream output = (Stream)File.Open("print.docx", FileMode.Create)) { provider.Export(this.docCertificate.Document, output); }
            try
            {
                ProcessStartInfo info = new ProcessStartInfo("print.docx");
                info.Verb = "PrintTo";
                info.CreateNoWindow = true;
                info.ErrorDialog = false;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(info);
            }
            catch { }
        }
    }
}
