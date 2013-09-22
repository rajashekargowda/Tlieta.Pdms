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
            this.patientlookupTile = new Telerik.WinControls.UI.RadTileElement();
            this.logBookTile = new Telerik.WinControls.UI.RadTileElement();
            this.practiceManagementGroup = new Telerik.WinControls.UI.TileGroupElement();
            this.radTileAppointments = new Telerik.WinControls.UI.RadTileElement();
            this.radTileDaybook = new Telerik.WinControls.UI.RadTileElement();
            this.radTileCertificates = new Telerik.WinControls.UI.RadTileElement();
            this.radTileContacts = new Telerik.WinControls.UI.RadTileElement();
            this.radTileLetters = new Telerik.WinControls.UI.RadTileElement();
            this.settingsGroup = new Telerik.WinControls.UI.TileGroupElement();
            this.settingsTile = new Telerik.WinControls.UI.RadTileElement();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanorama1
            // 
            this.radPanorama1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanorama1.Groups.AddRange(new Telerik.WinControls.RadItem[] {
            this.applicationsGroup,
            this.practiceManagementGroup,
            this.settingsGroup});
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
            this.patientlookupTile,
            this.logBookTile});
            this.applicationsGroup.Margin = new System.Windows.Forms.Padding(120, 200, 65, 0);
            this.applicationsGroup.Name = "applicationsGroup";
            this.applicationsGroup.RowsCount = 2;
            this.applicationsGroup.Text = "Patient Management";
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
            this.logBookTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(129)))), ((int)(((byte)(190)))));
            this.logBookTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.logBookTile.Column = 1;
            this.logBookTile.DrawBorder = true;
            this.logBookTile.Image = global::Tlieta.Pdms.Properties.Resources.report48;
            this.logBookTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.logBookTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logBookTile.Name = "logBookTile";
            this.logBookTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.logBookTile.Row = 1;
            this.logBookTile.Text = "Log Book";
            this.logBookTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.logBookTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.logBookTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.logBookTile.Click += new System.EventHandler(this.logBookTile_Click);
            // 
            // practiceManagementGroup
            // 
            this.practiceManagementGroup.AccessibleDescription = "practiceManagement";
            this.practiceManagementGroup.AccessibleName = "practiceManagement";
            this.practiceManagementGroup.CellSize = new System.Drawing.Size(155, 155);
            this.practiceManagementGroup.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.practiceManagementGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.practiceManagementGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radTileAppointments,
            this.radTileDaybook,
            this.radTileCertificates,
            this.radTileContacts,
            this.radTileLetters});
            this.practiceManagementGroup.Margin = new System.Windows.Forms.Padding(120, 200, 65, 0);
            this.practiceManagementGroup.Name = "practiceManagementGroup";
            this.practiceManagementGroup.RowsCount = 2;
            this.practiceManagementGroup.Text = "Practice Management";
            this.practiceManagementGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radTileAppointments
            // 
            this.radTileAppointments.AccessibleDescription = "radTileAppointments";
            this.radTileAppointments.AccessibleName = "radTileAppointments";
            this.radTileAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.radTileAppointments.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(124)))), ((int)(((byte)(137)))));
            this.radTileAppointments.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(174)))), ((int)(((byte)(187)))));
            this.radTileAppointments.CellPadding = new System.Windows.Forms.Padding(5);
            this.radTileAppointments.ColSpan = 2;
            this.radTileAppointments.DrawBorder = true;
            this.radTileAppointments.GradientAngle = 0F;
            this.radTileAppointments.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.radTileAppointments.Image = global::Tlieta.Pdms.Properties.Resources.appointments;
            this.radTileAppointments.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.radTileAppointments.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radTileAppointments.Name = "radTileAppointments";
            this.radTileAppointments.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.radTileAppointments.Text = "Appointments";
            this.radTileAppointments.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radTileAppointments.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radTileAppointments.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radTileAppointments.Click += new System.EventHandler(this.radTileAppointments_Click);
            // 
            // radTileDaybook
            // 
            this.radTileDaybook.AccessibleDescription = "radTileDaybook";
            this.radTileDaybook.AccessibleName = "radTileDaybook";
            this.radTileDaybook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(53)))), ((int)(((byte)(1)))));
            this.radTileDaybook.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(154)))), ((int)(((byte)(7)))));
            this.radTileDaybook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(112)))), ((int)(((byte)(9)))));
            this.radTileDaybook.CellPadding = new System.Windows.Forms.Padding(5);
            this.radTileDaybook.ColSpan = 2;
            this.radTileDaybook.Column = 2;
            this.radTileDaybook.DrawBorder = true;
            this.radTileDaybook.GradientAngle = 0F;
            this.radTileDaybook.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.radTileDaybook.Image = global::Tlieta.Pdms.Properties.Resources.finance;
            this.radTileDaybook.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.radTileDaybook.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radTileDaybook.Name = "radTileDaybook";
            this.radTileDaybook.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.radTileDaybook.Text = "Income/Expense Daybook";
            this.radTileDaybook.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radTileDaybook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radTileDaybook.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radTileDaybook.Click += new System.EventHandler(this.radTileDaybook_Click);
            // 
            // radTileCertificates
            // 
            this.radTileCertificates.AccessibleDescription = "radTileCertificates";
            this.radTileCertificates.AccessibleName = "radTileCertificates";
            this.radTileCertificates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.radTileCertificates.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radTileCertificates.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(114)))), ((int)(((byte)(51)))));
            this.radTileCertificates.CellPadding = new System.Windows.Forms.Padding(5);
            this.radTileCertificates.DrawBorder = true;
            this.radTileCertificates.GradientAngle = 0F;
            this.radTileCertificates.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.radTileCertificates.Image = global::Tlieta.Pdms.Properties.Resources.certificate;
            this.radTileCertificates.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.radTileCertificates.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radTileCertificates.Name = "radTileCertificates";
            this.radTileCertificates.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.radTileCertificates.Row = 1;
            this.radTileCertificates.Column = 0;
            this.radTileCertificates.Text = "Certificates";
            this.radTileCertificates.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radTileCertificates.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radTileCertificates.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radTileCertificates.Click += new System.EventHandler(this.radTileCertificates_Click);
            // 
            // radTileContacts
            // 
            this.radTileContacts.AccessibleDescription = "radTileContacts";
            this.radTileContacts.AccessibleName = "radTileContacts";
            this.radTileContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(1)))), ((int)(((byte)(17)))));
            this.radTileContacts.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(5)))), ((int)(((byte)(46)))));
            this.radTileContacts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(114)))), ((int)(((byte)(51)))));
            this.radTileContacts.CellPadding = new System.Windows.Forms.Padding(5);
            this.radTileContacts.Column = 1;
            this.radTileContacts.DrawBorder = true;
            this.radTileContacts.GradientAngle = 0F;
            this.radTileContacts.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.radTileContacts.Image = global::Tlieta.Pdms.Properties.Resources.contacts;
            this.radTileContacts.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.radTileContacts.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radTileContacts.Name = "radTileContacts";
            this.radTileContacts.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.radTileContacts.Row = 1;
            this.radTileContacts.Text = "Contacts";
            this.radTileContacts.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radTileContacts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radTileContacts.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radTileContacts.Click += new System.EventHandler(this.radTileContacts_Click);
            // 
            // radTileLetters
            // 
            this.radTileLetters.AccessibleDescription = "radTileLetters";
            this.radTileLetters.AccessibleName = "radTileLetters";
            this.radTileLetters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(65)))));
            this.radTileLetters.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(5)))), ((int)(((byte)(115)))));
            this.radTileLetters.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(16)))), ((int)(((byte)(202)))));
            this.radTileLetters.CellPadding = new System.Windows.Forms.Padding(5);
            this.radTileLetters.Column = 2;
            this.radTileLetters.DrawBorder = true;
            this.radTileLetters.GradientAngle = 0F;
            this.radTileLetters.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.radTileLetters.Image = global::Tlieta.Pdms.Properties.Resources.letters;
            this.radTileLetters.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.radTileLetters.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radTileLetters.Name = "radTileLetters";
            this.radTileLetters.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.radTileLetters.Row = 1;
            this.radTileLetters.Text = "Letters";
            this.radTileLetters.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radTileLetters.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radTileLetters.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radTileLetters.Click += new System.EventHandler(this.radTileLetters_Click);
            // 
            // settingsGroup
            // 
            this.settingsGroup.AccessibleDescription = "settingsGroup";
            this.settingsGroup.AccessibleName = "settingsGroup";
            this.settingsGroup.CellSize = new System.Drawing.Size(155, 155);
            this.settingsGroup.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.settingsGroup.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.settingsTile});
            this.settingsGroup.Margin = new System.Windows.Forms.Padding(120, 200, 65, 0);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.RowsCount = 2;
            this.settingsGroup.Text = "Settings";
            this.settingsGroup.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // settingsTile
            // 
            this.settingsTile.AccessibleDescription = "settingsTile";
            this.settingsTile.AccessibleName = "settingsTile";
            this.settingsTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(209)))));
            this.settingsTile.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(219)))));
            this.settingsTile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(180)))), ((int)(((byte)(218)))));
            this.settingsTile.CellPadding = new System.Windows.Forms.Padding(5);
            this.settingsTile.DrawBorder = true;
            this.settingsTile.GradientAngle = 0F;
            this.settingsTile.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            this.settingsTile.Image = ((System.Drawing.Image)(resources.GetObject("settingsTile.Image")));
            this.settingsTile.ImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.settingsTile.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsTile.Name = "settingsTile";
            this.settingsTile.Padding = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.settingsTile.Text = "Settings";
            this.settingsTile.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.settingsTile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.settingsTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.settingsTile.Click += new System.EventHandler(this.settingsTile_Click);
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
        private TileGroupElement practiceManagementGroup;
        private TileGroupElement settingsGroup;
        private RadTileElement addPatientTile;
        private RadTileElement patientlookupTile;
        private RadTileElement settingsTile;
        private RadTileElement statisticsTile;
        private RadTileElement logBookTile;
        private RadTileElement radTileAppointments;
        private RadTileElement radTileDaybook;
        private RadTileElement radTileCertificates;
        private RadTileElement radTileContacts;
        private RadTileElement radTileLetters;
    }
}