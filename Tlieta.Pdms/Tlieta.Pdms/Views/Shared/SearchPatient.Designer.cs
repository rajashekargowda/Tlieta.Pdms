namespace Tlieta.Pdms.Views.Shared
{
    partial class SearchPatient
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
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.ddlHospital = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.SearchGrid = new Telerik.WinControls.UI.RadGridView();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(36, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 23);
            this.txtName.TabIndex = 8;
            this.txtName.TabStop = false;
            this.txtName.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(36, 39);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(48, 24);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Name";
            // 
            // ddlHospital
            // 
            this.ddlHospital.DropDownAnimationEnabled = true;
            this.ddlHospital.Location = new System.Drawing.Point(217, 69);
            this.ddlHospital.Name = "ddlHospital";
            this.ddlHospital.ShowImageInEditorArea = true;
            this.ddlHospital.Size = new System.Drawing.Size(200, 20);
            this.ddlHospital.TabIndex = 22;
            this.ddlHospital.ThemeName = "TelerikMetro";
            // 
            // radLabel11
            // 
            this.radLabel11.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.radLabel11.Location = new System.Drawing.Point(217, 39);
            this.radLabel11.Name = "radLabel11";
            this.radLabel11.Size = new System.Drawing.Size(106, 24);
            this.radLabel11.TabIndex = 21;
            this.radLabel11.Text = "Hospital/Clinic";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(442, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 24);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.ThemeName = "TelerikMetro";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchGrid
            // 
            this.SearchGrid.AutoScroll = true;
            this.SearchGrid.Location = new System.Drawing.Point(36, 123);
            // 
            // SearchGrid
            // 
            this.SearchGrid.MasterTemplate.AllowAddNewRow = false;
            this.SearchGrid.MasterTemplate.AllowCellContextMenu = false;
            this.SearchGrid.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.SearchGrid.MasterTemplate.AllowDeleteRow = false;
            this.SearchGrid.MasterTemplate.AllowDragToGroup = false;
            this.SearchGrid.MasterTemplate.AllowEditRow = false;
            this.SearchGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.SearchGrid.MasterTemplate.EnableFiltering = true;
            this.SearchGrid.Name = "SearchGrid";
            this.SearchGrid.ReadOnly = true;
            this.SearchGrid.ShowGroupPanel = false;
            this.SearchGrid.ShowItemToolTips = false;
            this.SearchGrid.Size = new System.Drawing.Size(1261, 474);
            this.SearchGrid.TabIndex = 27;
            this.SearchGrid.Text = "radGridView1";
            this.SearchGrid.ThemeName = "TelerikMetro";
            this.SearchGrid.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.SearchGrid_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(1205, 69);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 23);
            this.btnRefresh.TabIndex = 88;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ThemeName = "TelerikMetro";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.SearchGrid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ddlHospital);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radLabel11);
            this.Controls.Add(this.radLabel2);
            this.Name = "SearchPatient";
            this.Size = new System.Drawing.Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList ddlHospital;
        private Telerik.WinControls.UI.RadLabel radLabel11;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadGridView SearchGrid;
        private Telerik.WinControls.UI.RadButton btnRefresh;
    }
}
