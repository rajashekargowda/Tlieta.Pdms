namespace Tlieta.Pdms.Views.Shared
{
    partial class PrintPhoto
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
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark1 = new Telerik.WinControls.UI.RadPrintWatermark();
            this.listPhotos = new Telerik.WinControls.UI.RadListControl();
            this.btnInsert = new Telerik.WinControls.UI.RadButton();
            this.docPrintPhoto = new Telerik.WinControls.RichTextBox.RadRichTextBox();
            this.radPrintPhotos = new Telerik.WinControls.UI.RadPrintDocument();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.listPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docPrintPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
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
            this.listPhotos.Size = new System.Drawing.Size(238, 538);
            this.listPhotos.TabIndex = 1;
            this.listPhotos.ThemeName = "TelerikMetro";
            this.listPhotos.ItemDataBound += new Telerik.WinControls.UI.ListItemDataBoundEventHandler(this.listPhotos_ItemDataBound);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1155, 40);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 22);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.ThemeName = "TelerikMetro";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // docPrintPhoto
            // 
            this.docPrintPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.docPrintPhoto.HyperlinkToolTipFormatString = null;
            this.docPrintPhoto.LayoutMode = Telerik.WinControls.RichTextBox.Model.DocumentLayoutMode.Paged;
            this.docPrintPhoto.Location = new System.Drawing.Point(284, 40);
            this.docPrintPhoto.Name = "docPrintPhoto";
            this.docPrintPhoto.Size = new System.Drawing.Size(865, 538);
            this.docPrintPhoto.TabIndex = 5;
            // 
            // radPrintPhotos
            // 
            this.radPrintPhotos.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPrintPhotos.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPrintPhotos.RightHeader = "Dr. Mahesh Krishnan";
            radPrintWatermark1.DrawInFront = true;
            radPrintWatermark1.Font = new System.Drawing.Font("Microsoft Sans Serif", 144F);
            this.radPrintPhotos.Watermark = radPrintWatermark1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1155, 116);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 22);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.ThemeName = "TelerikMetro";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1155, 78);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 22);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ThemeName = "TelerikMetro";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PrintPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.docPrintPhoto);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.listPhotos);
            this.Name = "PrintPhoto";
            this.Size = new System.Drawing.Size(1300, 600);
            this.Load += new System.EventHandler(this.PrintPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docPrintPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl listPhotos;
        private Telerik.WinControls.UI.RadButton btnInsert;
        private Telerik.WinControls.RichTextBox.RadRichTextBox docPrintPhoto;
        private Telerik.WinControls.UI.RadPrintDocument radPrintPhotos;
        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.UI.RadButton btnRefresh;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
