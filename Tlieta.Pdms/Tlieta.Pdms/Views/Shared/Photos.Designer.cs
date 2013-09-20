namespace Tlieta.Pdms.Views.Shared
{
    partial class Photos
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
            this.listPhotos = new Telerik.WinControls.UI.RadListControl();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.browsePhoto = new Telerik.WinControls.UI.RadBrowseEditor();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnOpenFolder = new Telerik.WinControls.UI.RadButton();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.panelPhotoView = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.listPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browsePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPhotoView)).BeginInit();
            this.SuspendLayout();
            // 
            // listPhotos
            // 
            this.listPhotos.AutoScroll = true;
            this.listPhotos.AutoSizeItems = true;
            this.listPhotos.CaseSensitiveSort = true;
            this.listPhotos.EnableKineticScrolling = true;
            this.listPhotos.ItemHeight = 50;
            this.listPhotos.Location = new System.Drawing.Point(40, 40);
            this.listPhotos.Name = "listPhotos";
            this.listPhotos.Size = new System.Drawing.Size(239, 467);
            this.listPhotos.TabIndex = 0;
            this.listPhotos.ThemeName = "TelerikMetro";
            this.listPhotos.SelectedValueChanged += new System.EventHandler(this.listPhotos_SelectedValueChanged);
            this.listPhotos.ItemDataBound += new Telerik.WinControls.UI.ListItemDataBoundEventHandler(this.listPhotos_ItemDataBound);
            // 
            // browsePhoto
            // 
            this.browsePhoto.Location = new System.Drawing.Point(40, 513);
            this.browsePhoto.Name = "browsePhoto";
            this.browsePhoto.Size = new System.Drawing.Size(239, 22);
            this.browsePhoto.TabIndex = 3;
            this.browsePhoto.ThemeName = "ControlDefault";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 541);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 22);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.ThemeName = "TelerikMetro";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(102, 541);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(94, 22);
            this.btnOpenFolder.TabIndex = 5;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.ThemeName = "TelerikMetro";
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(202, 541);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 22);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ThemeName = "TelerikMetro";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelPhotoView
            // 
            this.panelPhotoView.AutoScroll = true;
            this.panelPhotoView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPhotoView.Location = new System.Drawing.Point(286, 40);
            this.panelPhotoView.Name = "panelPhotoView";
            this.panelPhotoView.Size = new System.Drawing.Size(999, 523);
            this.panelPhotoView.TabIndex = 7;
            this.panelPhotoView.ThemeName = "TelerikMetro";
            // 
            // Photos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panelPhotoView);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.browsePhoto);
            this.Controls.Add(this.listPhotos);
            this.Name = "Photos";
            this.Size = new System.Drawing.Size(1300, 600);
            this.Load += new System.EventHandler(this.Photos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browsePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPhotoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl listPhotos;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadBrowseEditor browsePhoto;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnOpenFolder;
        private Telerik.WinControls.UI.RadButton btnRefresh;
        private Telerik.WinControls.UI.RadPanel panelPhotoView;
    }
}
