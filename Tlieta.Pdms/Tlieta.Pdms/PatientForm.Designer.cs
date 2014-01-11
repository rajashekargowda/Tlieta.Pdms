using Telerik.WinControls.UI;
namespace Tlieta.Pdms
{
    partial class PatientForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.radPanorama1 = new Telerik.WinControls.UI.RadPanorama();
            this.applicationsGroup = new Telerik.WinControls.UI.TileGroupElement();
            this.patientinfoTile = new Telerik.WinControls.UI.RadTileElement();
            this.surgeryTile = new Telerik.WinControls.UI.RadTileElement();
            this.videoTile = new Telerik.WinControls.UI.RadTileElement();
            this.photoTile = new Telerik.WinControls.UI.RadTileElement();
            this.printphotoTile = new Telerik.WinControls.UI.RadTileElement();
            this.measurementTile = new Telerik.WinControls.UI.RadTileElement();
            this.newvisitTile = new Telerik.WinControls.UI.RadTileElement();
            this.visitsTile = new Telerik.WinControls.UI.RadTileElement();
            this.billingTile = new Telerik.WinControls.UI.RadTileElement();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanorama1
            // 
            this.radPanorama1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanorama1.Groups.AddRange(new Telerik.WinControls.RadItem[] {
            this.applicationsGroup});
            this.radPanorama1.Location = new System.Drawing.Point(0, 0);
            this.radPanorama1.Name = "radPanorama1";
            this.radPanorama1.PanelImage = ((System.Drawing.Image)(resources.GetObject("radPanorama1.PanelImage")));
            this.radPanorama1.PanelImageSize = new System.Drawing.Size(1024, 768);
            this.radPanorama1.RowsCount = 2;
            this.radPanorama1.ShowGroups = true;
            this.radPanorama1.Size = new System.Drawing.Size(1292, 716);
            this.radPanorama1.TabIndex = 0;
            this.radPanorama1.Text = "radTilePanel1";
            ((Telerik.WinControls.UI.RadPanoramaElement)(this.radPanorama1.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(23)))), ((int)(((byte)(117)))));
            // 
            // applicationsGroup
            // 
            this.applicationsGroup.AccessibleDescription = "Applications";
            this.applicationsGroup.AccessibleName = "Applications";
            this.applicationsGroup.CellSize = new System.Drawing.Size(155, 155);
            this.applicationsGroup.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applicationsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.applicationsGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.patientinfoTile,
            this.surgeryTile,
            this.videoTile,
            this.photoTile,
            this.printphotoTile,
            this.measurementTile,
            this.newvisitTile,
            this.visitsTile,
            this.billingTile});
            this.applicationsGroup.Margin = new System.Windows.Forms.Padding(120, 200, 65, 0);
            this.applicationsGroup.Name = "applicationsGroup";
            this.applicationsGroup.RowsCount = 2;
            this.applicationsGroup.Text = "";
            this.applicationsGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // patientinfoTile
            // 
            this.patientinfoTile.AccessibleDescription = "patientinfoTile";
            this.patientinfoTile.AccessibleName = "patientinfoTile";
            this.patientinfoTile.BackgroundImage = global::Tlieta.Pdms.Properties.Resources.magnifier_bg;
            this.patientinfoTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(64)))), ((int)(((byte)(172)))));
            this.patientinfoTile.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(64)))), ((int)(((byte)(172)))));
            this.patientinfoTile.BorderColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(197)))));
            this.patientinfoTile.BorderColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(197)))));
            this.patientinfoTile.BorderGradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.patientinfoTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.patientinfoTile.DrawBorder = true;
            this.patientinfoTile.Image = global::Tlieta.Pdms.Properties.Resources.doctor48;
            this.patientinfoTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.patientinfoTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.patientinfoTile.Name = "patientinfoTile";
            this.patientinfoTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.patientinfoTile.Text = "Patient Info";
            this.patientinfoTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.patientinfoTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.patientinfoTile.TextWrap = true;
            this.patientinfoTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.patientinfoTile.Click += new System.EventHandler(this.patientinfoTile_Click);
            // 
            // surgeryTile
            // 
            this.surgeryTile.AccessibleDescription = "surgeryTile";
            this.surgeryTile.AccessibleName = "surgeryTile";
            this.surgeryTile.BackgroundImage = global::Tlieta.Pdms.Properties.Resources.qsf_bg;
            this.surgeryTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(129)))), ((int)(((byte)(190)))));
            this.surgeryTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.surgeryTile.ColSpan = 2;
            this.surgeryTile.Column = 1;
            this.surgeryTile.DrawBorder = true;
            this.surgeryTile.Name = "surgeryTile";
            this.surgeryTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.surgeryTile.Text = "Surgery";
            this.surgeryTile.Image = global::Tlieta.Pdms.Properties.Resources.surgery48;
            this.surgeryTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.surgeryTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.surgeryTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.surgeryTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.surgeryTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.surgeryTile.Click += new System.EventHandler(this.surgeryTile_Click);
            // 
            // videoTile
            // 
            this.videoTile.AccessibleDescription = "videoTile";
            this.videoTile.AccessibleName = "videoTile";
            this.videoTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(118)))));
            this.videoTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.videoTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(135)))), ((int)(((byte)(145)))));
            this.videoTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.videoTile.Column = 3;
            this.videoTile.DrawBorder = true;
            this.videoTile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.videoTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.videoTile.Image = global::Tlieta.Pdms.Properties.Resources.video64;
            this.videoTile.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.videoTile.Name = "videoTile";
            this.videoTile.Padding = new System.Windows.Forms.Padding(17, 17, 17, 8);
            this.videoTile.Row = 1;
            this.videoTile.Text = "Videos";
            this.videoTile.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.videoTile.TextWrap = true;
            this.videoTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.videoTile.Click += new System.EventHandler(this.videoTile_Click);
            // 
            // photoTile
            // 
            this.photoTile.AccessibleDescription = "photoTile";
            this.photoTile.AccessibleName = "photoTile";
            this.photoTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(178)))), ((int)(((byte)(56)))));
            this.photoTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(211)))), ((int)(((byte)(25)))));
            this.photoTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(193)))), ((int)(((byte)(95)))));
            this.photoTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.photoTile.Column = 2;
            this.photoTile.DrawBorder = true;
            this.photoTile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.photoTile.Image = global::Tlieta.Pdms.Properties.Resources.photo64;
            this.photoTile.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.photoTile.Name = "photoTile";
            this.photoTile.Padding = new System.Windows.Forms.Padding(17, 17, 17, 8);
            this.photoTile.Row = 1;
            this.photoTile.Text = "Photos";
            this.photoTile.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.photoTile.TextWrap = true;
            this.photoTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.photoTile.Click += new System.EventHandler(this.photoTile_Click);
            // 
            // printphotoTile
            // 
            this.printphotoTile.AccessibleDescription = "printphotoTile";
            this.printphotoTile.AccessibleName = "printphotoTile";
            this.printphotoTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.printphotoTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(219)))));
            this.printphotoTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.printphotoTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.printphotoTile.Column = 4;
            this.printphotoTile.DrawBorder = true;
            this.printphotoTile.GradientAngle = 0F;
            this.printphotoTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.printphotoTile.Image = global::Tlieta.Pdms.Properties.Resources.printphoto48;
            this.printphotoTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.printphotoTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printphotoTile.Name = "printphotoTile";
            this.printphotoTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.printphotoTile.Row = 1;
            this.printphotoTile.Text = "Print Photo";
            this.printphotoTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.printphotoTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.printphotoTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.printphotoTile.Click += new System.EventHandler(this.printphotoTile_Click);
            // 
            // measurementTile
            // 
            this.measurementTile.AccessibleDescription = "Measurements & Vitals";
            this.measurementTile.AccessibleName = "Measurements & Vitals";
            this.measurementTile.ColSpan = 2;
            this.measurementTile.Name = "measurementTile";
            this.measurementTile.Column = 0;
            this.measurementTile.Row = 1;
            this.measurementTile.Text = "Measurements & Vitals";
            this.measurementTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.measurementTile.Image = global::Tlieta.Pdms.Properties.Resources.cardiology48;
            this.measurementTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.measurementTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.measurementTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.measurementTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.measurementTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.measurementTile.Click += new System.EventHandler(this.measurementTile_Click);
            // 
            // newvisitTile
            // 
            this.newvisitTile.AccessibleDescription = "Add New Visit";
            this.newvisitTile.AccessibleName = "Add New Visit";
            this.newvisitTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))));
            this.newvisitTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(53)))), ((int)(((byte)(115)))));
            this.newvisitTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(53)))), ((int)(((byte)(115)))));
            this.newvisitTile.ColSpan = 2;
            this.newvisitTile.Column = 3;
            this.newvisitTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.newvisitTile.Name = "newvisitTile";
            this.newvisitTile.Text = "Add New Visit";
            this.newvisitTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.newvisitTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.newvisitTile.Image = global::Tlieta.Pdms.Properties.Resources.ambulance48;
            this.newvisitTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.newvisitTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newvisitTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.newvisitTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // visitsTile
            // 
            this.visitsTile.AccessibleDescription = "Visits";
            this.visitsTile.AccessibleName = "Visits";
            this.visitsTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(4)))), ((int)(((byte)(80)))));
            this.visitsTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.visitsTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(33)))));
            this.visitsTile.Column = 5;
            this.visitsTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.visitsTile.Name = "visitsTile";
            this.visitsTile.Text = "Visits";
            this.visitsTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.visitsTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.visitsTile.Image = global::Tlieta.Pdms.Properties.Resources.medical_record48;
            this.visitsTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.visitsTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.visitsTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.visitsTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // billingTile
            // 
            this.billingTile.AccessibleDescription = "Billing";
            this.billingTile.AccessibleName = "Billing";
            this.billingTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(80)))), ((int)(((byte)(89)))));
            this.billingTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(80)))), ((int)(((byte)(89)))));
            this.billingTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(80)))), ((int)(((byte)(89)))));
            this.billingTile.Column = 5;
            this.billingTile.Name = "billingTile";
            this.billingTile.Row = 1;
            this.billingTile.Text = "Billing";
            this.billingTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.billingTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.billingTile.Image = global::Tlieta.Pdms.Properties.Resources.bill;
            this.billingTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.billingTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.billingTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.billingTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // PatientForm
            // 
            this.ClientSize = new System.Drawing.Size(1292, 716);
            this.Controls.Add(this.radPanorama1);
            this.Icon = global::Tlieta.Pdms.Properties.Resources.icon;
            this.Name = "PatientForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Hub";
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadPanorama radPanorama1;
        private TileGroupElement applicationsGroup;
        private RadTileElement patientinfoTile;
        private RadTileElement surgeryTile;
        private RadTileElement printphotoTile;
        private RadTileElement videoTile;
        private RadTileElement photoTile;
        private RadTileElement measurementTile;
        private RadTileElement newvisitTile;
        private RadTileElement visitsTile;
        private RadTileElement billingTile;
    }
}
