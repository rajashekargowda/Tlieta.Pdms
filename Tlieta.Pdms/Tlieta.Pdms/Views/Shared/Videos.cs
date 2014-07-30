using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Telerik.WinControls.UI;
using System.Diagnostics;
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class Videos : UserControl
    {
        private string _patientid = "";
        private int _currentselectedindex;
        private int _newselectedindex;
        public Videos(string patientid)
        {
            InitializeComponent();
            _patientid = patientid;

            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = false;
        }

        private void Videos_Load(object sender, EventArgs e)
        {
            PopulateVideoList();
        }

        private void PopulateVideoList()
        {
            listVideos.Items.Clear();
            FileInfo[] fi = FileOperations.GetFilesinFolder(DataFolder.GetVideoFolder(_patientid));
            if (fi != null)
            {
                foreach (FileInfo f in fi)
                {
                    RadListDataItem item = new RadListDataItem();
                    item.Text = f.Name;
                    item.Value = f.FullName;
                    listVideos.Items.Add(item);
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentMedia != null)
            {
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused || axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    btnPlay.Text = "Pause";
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    btnPlay.Text = "Play";
                }
            }
            else
            {
                if (listVideos.SelectedItem != null)
                {
                    axWindowsMediaPlayer1.URL = listVideos.SelectedItem.Value.ToString(); btnPlay.Text = "Pause";
                    timer1.Enabled = true;
                }
                else { MessageBox.Show("Select a video to play"); }
            }            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            btnPlay.Text = "Play";
        }

        private void listVideos_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.URL = listVideos.SelectedItem.Value.ToString(); btnPlay.Text = "Pause";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackVideo.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
            trackVideo.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
        }

        private void trackVideo_MouseUp(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackVideo.Value;
            timer1.Enabled = true;
        }

        private void trackVideo_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(axWindowsMediaPlayer1.URL))
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                btnPlay.Text = "Play";
                System.Drawing.Image ret = null;
                try
                {
                    Bitmap bitmap = new Bitmap(axWindowsMediaPlayer1.Width, axWindowsMediaPlayer1.Height);
                    {
                        Graphics g = Graphics.FromImage(bitmap);
                        {
                            Graphics gg = axWindowsMediaPlayer1.CreateGraphics();
                            {
                                this.BringToFront();
                                g.CopyFromScreen(
                                axWindowsMediaPlayer1.PointToScreen(
                                new System.Drawing.Point()).X,
                                axWindowsMediaPlayer1.PointToScreen(
                                new System.Drawing.Point()).Y,
                                0, 0,
                                new System.Drawing.Size(
                                axWindowsMediaPlayer1.Width,
                                axWindowsMediaPlayer1.Height)
                                 );
                            }
                        }
                    }
                    
                    //////
                    saveFileDialog1.Filter = "Image Files (*.jpg)|*.*";
                    saveFileDialog1.InitialDirectory = Path.GetFullPath( DataFolder.GetPhotoFolder(_patientid));
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            ret = System.Drawing.Image.FromStream(ms);
                            string path = saveFileDialog1.FileName + ".jpg";
                            ret.Save(path);
                        }
                    }                   
                }
                catch { }

                axWindowsMediaPlayer1.Ctlcontrols.play();
                btnPlay.Text = "Pause";
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            string path = DataFolder.GetVideoFolder(_patientid);
            FileOperations.OpenFolder(path);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo f = new FileInfo(browseVideo.Value);
                string ext = f.Extension.ToLower();
                //if (ext == ".avi" || ext == ".mp4" || ext == ".mpg")
                //{
                    FileOperations.CopyFile(f.FullName, DataFolder.GetVideoFolder(_patientid));
                //}
            }
            catch { return; }

            PopulateVideoList();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.URL = openVideo.Value;
                axWindowsMediaPlayer1.URL = listVideos.SelectedItem.Value.ToString();
                btnPlay.Text = "Pause";
                timer1.Enabled = true;
            }
            catch { }
        }
    }
}
