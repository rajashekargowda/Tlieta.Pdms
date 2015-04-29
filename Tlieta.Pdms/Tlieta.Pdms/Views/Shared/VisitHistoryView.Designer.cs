namespace Tlieta.Pdms.Views.Shared
{
    partial class VisitHistoryView
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
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.docPrintVisit = new Telerik.WinControls.RichTextBox.RadRichTextBox();
            this.radPrintPhotos = new Telerik.WinControls.UI.RadPrintDocument();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.listVisits = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docPrintVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(1151, 35);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 22);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.ThemeName = "TelerikMetroBlue";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // docPrintVisit
            // 
            this.docPrintVisit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.docPrintVisit.HyperlinkToolTipFormatString = null;
            this.docPrintVisit.LayoutMode = Telerik.WinControls.RichTextBox.Model.DocumentLayoutMode.Paged;
            this.docPrintVisit.Location = new System.Drawing.Point(280, 35);
            this.docPrintVisit.Name = "docPrintVisit";
            this.docPrintVisit.Size = new System.Drawing.Size(865, 538);
            this.docPrintVisit.TabIndex = 10;
            this.docPrintVisit.ThemeName = "TelerikMetroBlue";
            // 
            // radPrintPhotos
            // 
            this.radPrintPhotos.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPrintPhotos.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPrintPhotos.Watermark = radPrintWatermark1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(1151, 76);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 22);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ThemeName = "TelerikMetroBlue";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listVisits
            // 
            this.listVisits.AutoScroll = true;
            this.listVisits.EnableKineticScrolling = true;
            this.listVisits.ItemHeight = 50;
            this.listVisits.Location = new System.Drawing.Point(43, 35);
            this.listVisits.Name = "listVisits";
            this.listVisits.Size = new System.Drawing.Size(205, 538);
            this.listVisits.TabIndex = 41;
            this.listVisits.ThemeName = "TelerikMetroBlue";
            this.listVisits.SelectedValueChanged += new System.EventHandler(this.listVisits_SelectedValueChanged);
            // 
            // VisitHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.listVisits);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.docPrintVisit);
            this.Name = "VisitHistoryView";
            this.Size = new System.Drawing.Size(1300, 600);
            this.Load += new System.EventHandler(this.VisitHistoryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docPrintVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVisits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.RichTextBox.RadRichTextBox docPrintVisit;
        private Telerik.WinControls.UI.RadPrintDocument radPrintPhotos;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Telerik.WinControls.UI.RadButton btnRefresh;
        private Telerik.WinControls.UI.RadListControl listVisits;

    }
}
