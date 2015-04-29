namespace Tlieta.Pdms.Views.Shared
{
    partial class Certificates
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
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.docCertificate = new Telerik.WinControls.RichTextBox.RadRichTextBox();
            this.btnMedical = new Telerik.WinControls.UI.RadButton();
            this.btnFitness = new Telerik.WinControls.UI.RadButton();
            this.btnDisability = new Telerik.WinControls.UI.RadButton();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docCertificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMedical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFitness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDisability)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(1142, 42);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 22);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.ThemeName = "TelerikMetroBlue";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // docCertificate
            // 
            this.docCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.docCertificate.HyperlinkToolTipFormatString = null;
            this.docCertificate.LayoutMode = Telerik.WinControls.RichTextBox.Model.DocumentLayoutMode.Paged;
            this.docCertificate.Location = new System.Drawing.Point(238, 42);
            this.docCertificate.Name = "docCertificate";
            this.docCertificate.Size = new System.Drawing.Size(879, 542);
            this.docCertificate.TabIndex = 7;
            this.docCertificate.ThemeName = "TelerikMetroBlue";
            // 
            // btnMedical
            // 
            this.btnMedical.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMedical.Location = new System.Drawing.Point(20, 42);
            this.btnMedical.Name = "btnMedical";
            this.btnMedical.Size = new System.Drawing.Size(199, 22);
            this.btnMedical.TabIndex = 8;
            this.btnMedical.Text = "Medical Certificate";
            this.btnMedical.ThemeName = "TelerikMetroBlue";
            this.btnMedical.Click += new System.EventHandler(this.btnMedical_Click);
            // 
            // btnFitness
            // 
            this.btnFitness.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFitness.Location = new System.Drawing.Point(20, 86);
            this.btnFitness.Name = "btnFitness";
            this.btnFitness.Size = new System.Drawing.Size(199, 22);
            this.btnFitness.TabIndex = 9;
            this.btnFitness.Text = "Fitness Certificate";
            this.btnFitness.ThemeName = "TelerikMetroBlue";
            this.btnFitness.Click += new System.EventHandler(this.btnFitness_Click);
            // 
            // btnDisability
            // 
            this.btnDisability.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDisability.Location = new System.Drawing.Point(20, 129);
            this.btnDisability.Name = "btnDisability";
            this.btnDisability.Size = new System.Drawing.Size(199, 22);
            this.btnDisability.TabIndex = 9;
            this.btnDisability.Text = "Disability Certificate";
            this.btnDisability.ThemeName = "TelerikMetroBlue";
            // 
            // Certificates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnDisability);
            this.Controls.Add(this.btnFitness);
            this.Controls.Add(this.btnMedical);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.docCertificate);
            this.Name = "Certificates";
            this.Size = new System.Drawing.Size(1300, 600);
            this.Load += new System.EventHandler(this.Certificates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docCertificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMedical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFitness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDisability)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.RichTextBox.RadRichTextBox docCertificate;
        private Telerik.WinControls.UI.RadButton btnMedical;
        private Telerik.WinControls.UI.RadButton btnFitness;
        private Telerik.WinControls.UI.RadButton btnDisability;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
    }
}
