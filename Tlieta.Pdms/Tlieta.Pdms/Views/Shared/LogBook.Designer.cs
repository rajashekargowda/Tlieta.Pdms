namespace Tlieta.Pdms.Views.Shared
{
    partial class LogBook
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
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark2 = new Telerik.WinControls.UI.RadPrintWatermark();
            this.SearchGrid = new Telerik.WinControls.UI.RadGridView();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.ddlHospital = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.radLabel17 = new Telerik.WinControls.UI.RadLabel();
            this.ddlOpertaion = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radPrintDocument1 = new Telerik.WinControls.UI.RadPrintDocument();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlOpertaion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchGrid
            // 
            this.SearchGrid.AutoScroll = true;
            this.SearchGrid.Location = new System.Drawing.Point(20, 105);
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
            this.SearchGrid.Size = new System.Drawing.Size(857, 480);
            this.SearchGrid.TabIndex = 33;
            this.SearchGrid.Text = "radGridView1";
            this.SearchGrid.ThemeName = "TelerikMetro";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(509, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 24);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.ThemeName = "TelerikMetro";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ddlHospital
            // 
            this.ddlHospital.DropDownAnimationEnabled = true;
            this.ddlHospital.Location = new System.Drawing.Point(240, 63);
            this.ddlHospital.Name = "ddlHospital";
            this.ddlHospital.ShowImageInEditorArea = true;
            this.ddlHospital.Size = new System.Drawing.Size(200, 20);
            this.ddlHospital.TabIndex = 31;
            this.ddlHospital.ThemeName = "TelerikMetro";
            // 
            // radLabel11
            // 
            this.radLabel11.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.radLabel11.Location = new System.Drawing.Point(240, 33);
            this.radLabel11.Name = "radLabel11";
            this.radLabel11.Size = new System.Drawing.Size(106, 24);
            this.radLabel11.TabIndex = 30;
            this.radLabel11.Text = "Hospital/Clinic";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(901, 105);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(102, 24);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "Print";
            this.btnPrint.ThemeName = "TelerikMetro";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // radLabel17
            // 
            this.radLabel17.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.radLabel17.ForeColor = System.Drawing.Color.Red;
            this.radLabel17.Location = new System.Drawing.Point(145, 33);
            this.radLabel17.Name = "radLabel17";
            this.radLabel17.Size = new System.Drawing.Size(14, 24);
            this.radLabel17.TabIndex = 36;
            this.radLabel17.Text = "*";
            // 
            // ddlOpertaion
            // 
            this.ddlOpertaion.DropDownAnimationEnabled = true;
            this.ddlOpertaion.Location = new System.Drawing.Point(20, 63);
            this.ddlOpertaion.Name = "ddlOpertaion";
            this.ddlOpertaion.ShowImageInEditorArea = true;
            this.ddlOpertaion.Size = new System.Drawing.Size(200, 20);
            this.ddlOpertaion.TabIndex = 35;
            this.ddlOpertaion.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.radLabel1.Location = new System.Drawing.Point(20, 33);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(119, 24);
            this.radLabel1.TabIndex = 34;
            this.radLabel1.Text = "Operation name";
            // 
            // radPrintDocument1
            // 
            this.radPrintDocument1.AssociatedObject = this.SearchGrid;
            this.radPrintDocument1.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPrintDocument1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radPrintWatermark2.DrawInFront = true;
            radPrintWatermark2.Font = new System.Drawing.Font("Microsoft Sans Serif", 144F);
            this.radPrintDocument1.Watermark = radPrintWatermark2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(901, 63);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 24);
            this.btnRefresh.TabIndex = 88;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ThemeName = "TelerikMetro";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // LogBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.radLabel17);
            this.Controls.Add(this.ddlOpertaion);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.SearchGrid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ddlHospital);
            this.Controls.Add(this.radLabel11);
            this.Name = "LogBook";
            this.Size = new System.Drawing.Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlOpertaion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView SearchGrid;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadDropDownList ddlHospital;
        private Telerik.WinControls.UI.RadLabel radLabel11;
        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.UI.RadLabel radLabel17;
        private Telerik.WinControls.UI.RadDropDownList ddlOpertaion;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument1;
        private Telerik.WinControls.UI.RadButton btnRefresh;
    }
}
