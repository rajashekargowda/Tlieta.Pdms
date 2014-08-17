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
using Tlieta.Pdms.DB;
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class Charts : UserControl
    {
        public Charts()
        {
            InitializeComponent();
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            PopulatePhotoList();
        }

        private void PopulatePhotoList()
        {
            listPhotos.Items.Clear();
            FileInfo[] fi = FileOperations.GetFilesinFolder(DataFolder.GetChartsFolder());
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
                //docPrintPhoto.InsertLineBreak();
                //docPrintPhoto.InsertLineBreak();
                RadListDataItem item = listPhotos.SelectedItem;
                docPrintPhoto.Insert(item.Text);
                docPrintPhoto.InsertImage((Bitmap)Bitmap.FromFile(item.Value.ToString()));
            }
            catch { return; }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            try
            {
                IDocumentFormatProvider provider = new DocxFormatProvider();
                //IDocumentFormatProvider pdfprovider = new PdfFormatProvider();
                using (Stream output = (Stream)File.Open("print.docx", FileMode.Create)) { provider.Export(this.docPrintPhoto.Document, output); }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo f = new FileInfo(browsePhoto.Value);
                string ext = f.Extension.ToLower();
                if (ext == ".jpg" || ext == ".bmp" || ext == ".png")
                {
                    FileOperations.CopyFile(f.FullName, DataFolder.GetChartsFolder());
                }
            }
            catch { return; }

            PopulatePhotoList();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            FileOperations.OpenFolder(DataFolder.GetChartsFolder());
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            PopulatePhotoList();
        }
    }
}
