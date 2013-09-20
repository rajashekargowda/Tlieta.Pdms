namespace Tlieta.Pdms.Views.Shared
{
    partial class Videos
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Videos));
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listVideos = new Telerik.WinControls.UI.RadListControl();
            this.panelVideoView = new Telerik.WinControls.UI.RadPanel();
            this.trackVideo = new System.Windows.Forms.TrackBar();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.browseVideo = new Telerik.WinControls.UI.RadBrowseEditor();
            this.btnOpenFolder = new Telerik.WinControls.UI.RadButton();
            this.btnPlay = new Telerik.WinControls.UI.RadButton();
            this.btnStop = new Telerik.WinControls.UI.RadButton();
            this.btnCapture = new Telerik.WinControls.UI.RadButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOpen = new Telerik.WinControls.UI.RadButton();
            this.openVideo = new Telerik.WinControls.UI.RadBrowseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVideos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelVideoView)).BeginInit();
            this.panelVideoView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(848, 466);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // listVideos
            // 
            this.listVideos.AutoScroll = true;
            this.listVideos.CaseSensitiveSort = true;
            this.listVideos.EnableKineticScrolling = true;
            this.listVideos.ItemHeight = 50;
            this.listVideos.Location = new System.Drawing.Point(40, 40);
            this.listVideos.Name = "listVideos";
            this.listVideos.Size = new System.Drawing.Size(178, 443);
            this.listVideos.TabIndex = 1;
            this.listVideos.ThemeName = "TelerikMetro";
            this.listVideos.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.listVideos_SelectedIndexChanged);
            // 
            // panelVideoView
            // 
            this.panelVideoView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelVideoView.Controls.Add(this.trackVideo);
            this.panelVideoView.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelVideoView.Location = new System.Drawing.Point(224, 40);
            this.panelVideoView.Name = "panelVideoView";
            this.panelVideoView.Size = new System.Drawing.Size(854, 523);
            this.panelVideoView.TabIndex = 2;
            this.panelVideoView.ThemeName = "TelerikMetro";
            // 
            // trackVideo
            // 
            this.trackVideo.Location = new System.Drawing.Point(3, 475);
            this.trackVideo.Name = "trackVideo";
            this.trackVideo.Size = new System.Drawing.Size(848, 45);
            this.trackVideo.TabIndex = 1;
            this.trackVideo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackVideo_MouseDown);
            this.trackVideo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackVideo_MouseUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 541);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 22);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.ThemeName = "TelerikMetro";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // browseVideo
            // 
            this.browseVideo.Location = new System.Drawing.Point(40, 499);
            this.browseVideo.Name = "browseVideo";
            this.browseVideo.Size = new System.Drawing.Size(178, 22);
            this.browseVideo.TabIndex = 5;
            this.browseVideo.ThemeName = "TelerikMetro";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(124, 541);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(94, 22);
            this.btnOpenFolder.TabIndex = 4;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.ThemeName = "TelerikMetro";
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(1084, 40);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(78, 22);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.ThemeName = "TelerikMetro";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1084, 81);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(78, 22);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.ThemeName = "TelerikMetro";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(1084, 121);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(78, 22);
            this.btnCapture.TabIndex = 9;
            this.btnCapture.Text = "Capture";
            this.btnCapture.ThemeName = "TelerikMetro";
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1084, 224);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(113, 22);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "Play from file";
            this.btnOpen.ThemeName = "TelerikMetro";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openVideo
            // 
            this.openVideo.Location = new System.Drawing.Point(1084, 196);
            this.openVideo.Name = "openVideo";
            this.openVideo.Size = new System.Drawing.Size(178, 22);
            this.openVideo.TabIndex = 6;
            this.openVideo.ThemeName = "TelerikMetro";
            // 
            // Videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.openVideo);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.browseVideo);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.panelVideoView);
            this.Controls.Add(this.listVideos);
            this.Name = "Videos";
            this.Size = new System.Drawing.Size(1300, 600);
            this.Load += new System.EventHandler(this.Videos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVideos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelVideoView)).EndInit();
            this.panelVideoView.ResumeLayout(false);
            this.panelVideoView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Telerik.WinControls.UI.RadListControl listVideos;
        private Telerik.WinControls.UI.RadPanel panelVideoView;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadBrowseEditor browseVideo;
        private Telerik.WinControls.UI.RadButton btnOpenFolder;
        private Telerik.WinControls.UI.RadButton btnPlay;
        private Telerik.WinControls.UI.RadButton btnStop;
        private Telerik.WinControls.UI.RadButton btnCapture;
        private System.Windows.Forms.TrackBar trackVideo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Telerik.WinControls.UI.RadButton btnOpen;
        private Telerik.WinControls.UI.RadBrowseEditor openVideo;
    }
}
