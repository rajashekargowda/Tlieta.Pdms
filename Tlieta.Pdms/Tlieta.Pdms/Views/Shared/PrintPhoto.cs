using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.IO;
using Telerik.WinControls.RichTextBox.FormatProviders;
using Telerik.WinControls.RichTextBox.FileFormats.OpenXml.Docx;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using Tlieta.Pdms.Properties;
using Tlieta.Pdms.DataAccess;
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class PrintPhoto : UserControl
    {
        private string _patientid = "";
        public PrintPhoto(string patientid)
        {
            InitializeComponent();

            _patientid = patientid;
        }

        private void PrintPhoto_Load(object sender, EventArgs e)
        {
            PopulatePhotoList();
            PrepareDocument();
        }

        private void PrepareDocument()
        {
            this.docPrintPhoto.InsertImage((Bitmap)Resources.letterpadheader);

            Patient patient = new PatientData().GetPatientById(Convert.ToInt32(_patientid));
            docPrintPhoto.Insert("Patient Name : " + patient.FirstName.ToUpper() + " " + patient.LastName.ToUpper());
            docPrintPhoto.InsertLineBreak();
            docPrintPhoto.Insert("Patient Id : " + _patientid);
            docPrintPhoto.InsertLineBreak();
            docPrintPhoto.Insert("Age : " + patient.Age.ToString());
            docPrintPhoto.InsertLineBreak();
            docPrintPhoto.Insert("Address : " + patient.Address.ToUpper());
            docPrintPhoto.InsertLineBreak();
            docPrintPhoto.Insert("Hospital : ");
            docPrintPhoto.InsertLineBreak();
            docPrintPhoto.Insert("IP Number : ");
            docPrintPhoto.InsertLineBreak();
            docPrintPhoto.Insert("Surgery : ");
            docPrintPhoto.InsertLineBreak();
            docPrintPhoto.Insert("Date of Surgery : ");
            docPrintPhoto.InsertLineBreak();
        }

        private Telerik.WinControls.RichTextBox.Model.Span HeaderCell(string p)
        {
            Telerik.WinControls.RichTextBox.Model.Span span = new Telerik.WinControls.RichTextBox.Model.Span();
            span.FontStyle = Telerik.WinControls.RichTextBox.TextStyle.Bold;
            span.FontSize = 15;
            span.Text = p;
            return span;
        }

        private Telerik.WinControls.RichTextBox.Model.Span ValueCell(string p)
        {
            Telerik.WinControls.RichTextBox.Model.Span span = new Telerik.WinControls.RichTextBox.Model.Span();
            span.FontStyle = Telerik.WinControls.RichTextBox.TextStyle.Italic;
            span.FontSize = 15;
            span.Text = p;
            return span;
        }

        private void PopulatePhotoList()
        {
            listPhotos.Items.Clear();
            FileInfo[] fi = FileOperations.GetFilesinFolder(DataFolder.GetPhotoFolder(_patientid));
            foreach (FileInfo f in fi)
            {
                RadListDataItem item = new RadListDataItem();
                item.Value = f.FullName;
                item.Text = f.Name.Split('.').GetValue(0).ToString();
                item.TextAlignment = ContentAlignment.BottomCenter;
                item.Image = GetResizedImage(Image.FromFile(f.FullName));
                item.TextImageRelation = TextImageRelation.ImageAboveText;
                listPhotos.Items.Add(item);
            }
        }

        public static Image GetResizedImage(Image img)
        {
            Bitmap b = new Bitmap(212, 126);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, 0, 0, 212, 126);
            g.Dispose();

            try
            {
                return (Image)b.Clone();
            }
            finally
            {
                b.Dispose();
                b = null;
                g = null;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                docPrintPhoto.InsertLineBreak();
                docPrintPhoto.InsertLineBreak();
                RadListDataItem item = listPhotos.SelectedItem;
                docPrintPhoto.Insert(item.Text);
                docPrintPhoto.InsertImage((Bitmap)Bitmap.FromFile(item.Value.ToString()));
            }
            catch { return; }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            IDocumentFormatProvider provider = new DocxFormatProvider();
            //IDocumentFormatProvider pdfprovider = new PdfFormatProvider();
            using (Stream output = (Stream)File.Open("print.docx", FileMode.Create)) { provider.Export(this.docPrintPhoto.Document, output); }

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulatePhotoList();
        }

        private void listPhotos_ItemDataBound(object sender, ListItemDataBoundEventArgs args)
        {
            args.NewItem.Height = 126;
        }
    }
}
 
