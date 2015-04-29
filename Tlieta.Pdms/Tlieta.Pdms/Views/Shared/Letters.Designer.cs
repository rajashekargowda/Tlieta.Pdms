namespace Tlieta.Pdms.Views.Shared
{
    partial class Letters
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
            this.docLetters = new Telerik.WinControls.RichTextBox.RadRichTextBox();
            this.btnRequest = new Telerik.WinControls.UI.RadButton();
            this.btnThanksReferral = new Telerik.WinControls.UI.RadButton();
            this.btnReferral = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLetters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThanksReferral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReferral)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(1164, 34);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 22);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.ThemeName = "TelerikMetroBlue";
            // 
            // docLetters
            // 
            this.docLetters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.docLetters.HyperlinkToolTipFormatString = null;
            this.docLetters.LayoutMode = Telerik.WinControls.RichTextBox.Model.DocumentLayoutMode.Paged;
            this.docLetters.Location = new System.Drawing.Point(261, 34);
            this.docLetters.Name = "docLetters";
            this.docLetters.Size = new System.Drawing.Size(876, 548);
            this.docLetters.TabIndex = 7;
            this.docLetters.ThemeName = "TelerikMetroBlue";
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRequest.Location = new System.Drawing.Point(18, 121);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(199, 22);
            this.btnRequest.TabIndex = 12;
            this.btnRequest.Text = "MRI/CT/USG Request";
            this.btnRequest.ThemeName = "TelerikMetroBlue";
            // 
            // btnThanksReferral
            // 
            this.btnThanksReferral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThanksReferral.Location = new System.Drawing.Point(18, 78);
            this.btnThanksReferral.Name = "btnThanksReferral";
            this.btnThanksReferral.Size = new System.Drawing.Size(199, 22);
            this.btnThanksReferral.TabIndex = 11;
            this.btnThanksReferral.Text = "Thanks for Referral";
            this.btnThanksReferral.ThemeName = "TelerikMetroBlue";
            // 
            // btnReferral
            // 
            this.btnReferral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReferral.Location = new System.Drawing.Point(18, 34);
            this.btnReferral.Name = "btnReferral";
            this.btnReferral.Size = new System.Drawing.Size(199, 22);
            this.btnReferral.TabIndex = 10;
            this.btnReferral.Text = "Referral";
            this.btnReferral.ThemeName = "TelerikMetroBlue";
            // 
            // Letters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnThanksReferral);
            this.Controls.Add(this.btnReferral);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.docLetters);
            this.Name = "Letters";
            this.Size = new System.Drawing.Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLetters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThanksReferral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReferral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.RichTextBox.RadRichTextBox docLetters;
        private Telerik.WinControls.UI.RadButton btnRequest;
        private Telerik.WinControls.UI.RadButton btnThanksReferral;
        private Telerik.WinControls.UI.RadButton btnReferral;
    }
}
