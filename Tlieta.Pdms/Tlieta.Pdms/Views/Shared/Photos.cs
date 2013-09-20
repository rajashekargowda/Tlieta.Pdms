using System;
using System.Drawing;
using System.Windows.Forms;
using Tlieta.Utility;
using Telerik.WinControls.UI;
using System.IO;
using System.Drawing.Drawing2D;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class Photos : UserControl
    {
        private string _patientid = "";
        public Photos(string patientid)
        {
            InitializeComponent();

            _patientid = patientid;
        }

        private void Photos_Load(object sender, EventArgs e)
        {
            PopulatePhotoList();
        }

        private void PopulatePhotoList()
        {
            listPhotos.Items.Clear();
            FileInfo[] fi = FileOperations.GetFilesinFolder(DataFolder.GetPhotoFolder(_patientid));
            foreach (FileInfo f in fi)
            {
                RadListDataItem item = new RadListDataItem();
                item.Value = f.FullName;
                item.Text = f.Name;
                item.TextAlignment = ContentAlignment.BottomCenter;
                item.Image = GetResizedImage(Image.FromFile(f.FullName));
                item.TextImageRelation = TextImageRelation.ImageAboveText;
                listPhotos.Items.Add(item);
            }

            if (listPhotos.Items.Count > 0)
            {
                panelPhotoView.BackgroundImage = Image.FromFile(listPhotos.Items[0].Value.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo f = new FileInfo(browsePhoto.Value);
                string ext = f.Extension.ToLower();
                if (ext == ".jpg" || ext == ".bmp" || ext == ".png")
                {
                    FileOperations.CopyFile(f.FullName, DataFolder.GetPhotoFolder(_patientid));
                }
            }
            catch { return; }

            PopulatePhotoList();
        }

        private void listPhotos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listPhotos.SelectedIndex != -1)
            {
                RadListDataItem item = listPhotos.SelectedItem;
                panelPhotoView.BackgroundImage = Image.FromFile(item.Value.ToString());
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            string path = DataFolder.GetPhotoFolder(_patientid);
            FileOperations.OpenFolder(path);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulatePhotoList();
        }

        private void listPhotos_ItemDataBound(object sender, ListItemDataBoundEventArgs args)
        {
            args.NewItem.Height = 126;
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
    }
}



































































































