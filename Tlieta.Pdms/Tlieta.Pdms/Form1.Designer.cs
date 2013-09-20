using Telerik.WinControls.UI;
namespace Tlieta.Pdms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radPanorama1 = new Telerik.WinControls.UI.RadPanorama();
            this.applicationsGroup = new Telerik.WinControls.UI.TileGroupElement();
            this.addPatientTile = new Telerik.WinControls.UI.RadTileElement();
            this.statisticsTile = new Telerik.WinControls.UI.RadTileElement();
            this.settingsTile = new Telerik.WinControls.UI.RadTileElement();
            this.patientlookupTile = new Telerik.WinControls.UI.RadTileElement();
            this.logBookTile = new Telerik.WinControls.UI.RadTileElement();
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
            this.radPanorama1.Size = new System.Drawing.Size(1352, 734);
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
            this.addPatientTile,
            this.statisticsTile,
            this.settingsTile,
            this.patientlookupTile,
            this.logBookTile});
            this.applicationsGroup.Margin = new System.Windows.Forms.Padding(120, 200, 65, 0);
            this.applicationsGroup.Name = "applicationsGroup";
            this.applicationsGroup.RowsCount = 2;
            this.applicationsGroup.Text = "";
            this.applicationsGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // addPatientTile
            // 
            this.addPatientTile.AccessibleDescription = "addPatientTile";
            this.addPatientTile.AccessibleName = "addPatientTile";
            this.addPatientTile.BackgroundImage = global::Tlieta.Pdms.Properties.Resources.magnifier_bg;
            this.addPatientTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(64)))), ((int)(((byte)(172)))));
            this.addPatientTile.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(64)))), ((int)(((byte)(172)))));
            this.addPatientTile.BorderColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(197)))));
            this.addPatientTile.BorderColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(197)))));
            this.addPatientTile.BorderGradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.addPatientTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.addPatientTile.DrawBorder = true;
            this.addPatientTile.Image = global::Tlieta.Pdms.Properties.Resources.add_user;
            this.addPatientTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.addPatientTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addPatientTile.Name = "addPatientTile";
            this.addPatientTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.addPatientTile.Text = "New Patient";
            this.addPatientTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.addPatientTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addPatientTile.TextWrap = true;
            this.addPatientTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.addPatientTile.Click += new System.EventHandler(this.addPatientTile_Click);
            // 
            // statisticsTile
            // 
            this.statisticsTile.AccessibleDescription = "statisticsTile";
            this.statisticsTile.AccessibleName = "statisticsTile";
            this.statisticsTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(118)))));
            this.statisticsTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.statisticsTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(135)))), ((int)(((byte)(145)))));
            this.statisticsTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.statisticsTile.DrawBorder = true;
            this.statisticsTile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticsTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.statisticsTile.Image = global::Tlieta.Pdms.Properties.Resources.chart;
            this.statisticsTile.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.statisticsTile.Name = "statisticsTile";
            this.statisticsTile.Padding = new System.Windows.Forms.Padding(17, 17, 17, 8);
            this.statisticsTile.Row = 1;
            this.statisticsTile.Column = 0;
            this.statisticsTile.Text = "Statistics";
            this.statisticsTile.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.statisticsTile.TextWrap = true;
            this.statisticsTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.statisticsTile.Click += new System.EventHandler(this.statisticsTile_Click);
            // 
            // settingsTile
            // 
            this.settingsTile.AccessibleDescription = "settingsTile";
            this.settingsTile.AccessibleName = "settingsTile";
            this.settingsTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.settingsTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(219)))));
            this.settingsTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.settingsTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.settingsTile.Column = 1;
            this.settingsTile.DrawBorder = true;
            this.settingsTile.GradientAngle = 0F;
            this.settingsTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.settingsTile.Image = ((System.Drawing.Image)(resources.GetObject("settingsTile.Image")));
            this.settingsTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.settingsTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsTile.Name = "settingsTile";
            this.settingsTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.settingsTile.Row = 1;
            this.settingsTile.Text = "Settings";
            this.settingsTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.settingsTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.settingsTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.settingsTile.Click += new System.EventHandler(this.settingsTile_Click);
            // 
            // patientlookupTile
            // 
            this.patientlookupTile.AccessibleDescription = "patientlookupTile";
            this.patientlookupTile.AccessibleName = "patientlookupTile";
            this.patientlookupTile.BackgroundImage = global::Tlieta.Pdms.Properties.Resources.qsf_bg;
            this.patientlookupTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(129)))), ((int)(((byte)(190)))));
            this.patientlookupTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.patientlookupTile.ColSpan = 2;
            this.patientlookupTile.Column = 1;
            this.patientlookupTile.DrawBorder = true;
            this.patientlookupTile.Image = global::Tlieta.Pdms.Properties.Resources.search_laptop;
            this.patientlookupTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.patientlookupTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.patientlookupTile.Name = "patientlookupTile";
            this.patientlookupTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.patientlookupTile.Text = "Patient LookUp";
            this.patientlookupTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.patientlookupTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.patientlookupTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.patientlookupTile.Click += new System.EventHandler(this.patientlookupTile_Click);
            // 
            // logBookTile
            // 
            this.logBookTile.AccessibleDescription = "Log Book";
            this.logBookTile.AccessibleName = "Log Book";
            this.logBookTile.Column = 2;
            this.logBookTile.Name = "logBookTile";
            this.logBookTile.Row = 1;
            this.logBookTile.Text = "Log Book";
            this.logBookTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.logBookTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(129)))), ((int)(((byte)(190)))));
            this.logBookTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.logBookTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.logBookTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.logBookTile.DrawBorder = true;
            this.logBookTile.Image = global::Tlieta.Pdms.Properties.Resources.report48;
            this.logBookTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.logBookTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logBookTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.logBookTile.Click += new System.EventHandler(this.logBookTile_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1352, 734);
            this.Controls.Add(this.radPanorama1);
            this.Icon = global::Tlieta.Pdms.Properties.Resources.icon;
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDMS";
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadPanorama radPanorama1;
        private TileGroupElement applicationsGroup;
        private RadTileElement addPatientTile;
        private RadTileElement patientlookupTile;
        private RadTileElement settingsTile;
        private RadTileElement statisticsTile;
        private RadTileElement logBookTile;
    }
}