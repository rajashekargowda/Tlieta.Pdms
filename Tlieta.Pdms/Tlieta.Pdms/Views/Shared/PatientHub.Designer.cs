namespace Tlieta.Pdms.Views.Shared
{
    partial class PatientHub
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
            this.PatientHubView = new Telerik.WinControls.UI.RadPageView();
            this.pageInfo = new Telerik.WinControls.UI.RadPageViewPage();
            this.pageSurgery = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.PatientHubView)).BeginInit();
            this.PatientHubView.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientHubView
            // 
            this.PatientHubView.Controls.Add(this.pageInfo);
            this.PatientHubView.Controls.Add(this.pageSurgery);
            this.PatientHubView.Location = new System.Drawing.Point(3, 3);
            this.PatientHubView.Name = "PatientHubView";
            this.PatientHubView.SelectedPage = this.pageSurgery;
            this.PatientHubView.Size = new System.Drawing.Size(1194, 594);
            this.PatientHubView.TabIndex = 0;
            this.PatientHubView.ThemeName = "TelerikMetro";
            this.PatientHubView.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            // 
            // pageInfo
            // 
            this.pageInfo.Location = new System.Drawing.Point(205, 4);
            this.pageInfo.Name = "pageInfo";
            this.pageInfo.Size = new System.Drawing.Size(985, 586);
            this.pageInfo.Text = "Patient Info";
            // 
            // pageSurgery
            // 
            this.pageSurgery.Location = new System.Drawing.Point(205, 4);
            this.pageSurgery.Name = "pageSurgery";
            this.pageSurgery.Size = new System.Drawing.Size(985, 586);
            this.pageSurgery.Text = "Surgery";
            // 
            // PatientHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.PatientHubView);
            this.Name = "PatientHub";
            this.Size = new System.Drawing.Size(1200, 600);
            ((System.ComponentModel.ISupportInitialize)(this.PatientHubView)).EndInit();
            this.PatientHubView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView PatientHubView;
        private Telerik.WinControls.UI.RadPageViewPage pageInfo;
        private Telerik.WinControls.UI.RadPageViewPage pageSurgery;

    }
}
