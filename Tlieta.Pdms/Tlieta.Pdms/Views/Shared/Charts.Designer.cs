namespace Tlieta.Pdms.Views.Shared
{
    partial class Charts
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
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark3 = new Telerik.WinControls.UI.RadPrintWatermark();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.docPrintPhoto = new Telerik.WinControls.RichTextBox.RadRichTextBox();
            this.btnInsert = new Telerik.WinControls.UI.RadButton();
            this.listPhotos = new Telerik.WinControls.UI.RadListControl();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.radPrintDocument1 = new Telerik.WinControls.UI.RadPrintDocument();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.btnOpenFolder = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.browsePhoto = new Telerik.WinControls.UI.RadBrowseEditor();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docPrintPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browsePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1148, 68);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 22);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ThemeName = "TelerikMetro";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1148, 106);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 22);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.ThemeName = "TelerikMetro";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // docPrintPhoto
            // 
            this.docPrintPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.docPrintPhoto.HyperlinkToolTipFormatString = null;
            this.docPrintPhoto.LayoutMode = Telerik.WinControls.RichTextBox.Model.DocumentLayoutMode.Paged;
            this.docPrintPhoto.Location = new System.Drawing.Point(277, 30);
            this.docPrintPhoto.Name = "docPrintPhoto";
            this.docPrintPhoto.Size = new System.Drawing.Size(865, 538);
            this.docPrintPhoto.TabIndex = 10;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1148, 30);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 22);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.ThemeName = "TelerikMetro";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // listPhotos
            // 
            this.listPhotos.AutoScroll = true;
            this.listPhotos.AutoSizeItems = true;
            this.listPhotos.CaseSensitiveSort = true;
            this.listPhotos.EnableKineticScrolling = true;
            this.listPhotos.ItemHeight = 50;
            this.listPhotos.Location = new System.Drawing.Point(33, 30);
            this.listPhotos.Name = "listPhotos";
            this.listPhotos.Size = new System.Drawing.Size(238, 479);
            this.listPhotos.TabIndex = 6;
            this.listPhotos.ThemeName = "TelerikMetro";
            this.listPhotos.ItemDataBound += new Telerik.WinControls.UI.ListItemDataBoundEventHandler(this.listPhotos_ItemDataBound);
            // 
            // radPrintDocument1
            // 
            this.radPrintDocument1.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPrintDocument1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radPrintWatermark3.DrawInFront = true;
            radPrintWatermark3.Font = new System.Drawing.Font("Microsoft Sans Serif", 144F);
            this.radPrintDocument1.Watermark = radPrintWatermark3;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(195, 543);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(77, 22);
            this.radButton1.TabIndex = 14;
            this.radButton1.Text = "Refresh";
            this.radButton1.ThemeName = "TelerikMetro";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(95, 543);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(94, 22);
            this.btnOpenFolder.TabIndex = 13;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.ThemeName = "TelerikMetro";
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 543);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 22);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.ThemeName = "TelerikMetro";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // browsePhoto
            // 
            this.browsePhoto.Location = new System.Drawing.Point(33, 515);
            this.browsePhoto.Name = "browsePhoto";
            this.browsePhoto.Size = new System.Drawing.Size(239, 22);
            this.browsePhoto.TabIndex = 12;
            this.browsePhoto.ThemeName = "ControlDefault";
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.browsePhoto);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.docPrintPhoto);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.listPhotos);
            this.Name = "Charts";
            this.Size = new System.Drawing.Size(1300, 600);
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docPrintPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browsePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnRefresh;
        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.RichTextBox.RadRichTextBox docPrintPhoto;
        private Telerik.WinControls.UI.RadButton btnInsert;
        private Telerik.WinControls.UI.RadListControl listPhotos;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton btnOpenFolder;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadBrowseEditor browsePhoto;
    }
}
