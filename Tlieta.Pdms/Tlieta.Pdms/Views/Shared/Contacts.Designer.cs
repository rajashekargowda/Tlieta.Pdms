namespace Tlieta.Pdms.Views.Shared
{
    partial class Contacts
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
            this.ContactsGrid = new Telerik.WinControls.UI.RadGridView();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtAddress = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.txtMobile = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.txtDesignation = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtCompany = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnUpdateSchedule = new Telerik.WinControls.UI.RadButton();
            this.btnAddSchedule = new Telerik.WinControls.UI.RadButton();
            this.txtContactId = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactId)).BeginInit();
            this.SuspendLayout();
            // 
            // ContactsGrid
            // 
            this.ContactsGrid.AutoScroll = true;
            this.ContactsGrid.Location = new System.Drawing.Point(330, 19);
            // 
            // ContactsGrid
            // 
            this.ContactsGrid.MasterTemplate.AllowAddNewRow = false;
            this.ContactsGrid.MasterTemplate.AllowCellContextMenu = false;
            this.ContactsGrid.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.ContactsGrid.MasterTemplate.AllowDeleteRow = false;
            this.ContactsGrid.MasterTemplate.AllowDragToGroup = false;
            this.ContactsGrid.MasterTemplate.AllowEditRow = false;
            this.ContactsGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.ContactsGrid.MasterTemplate.EnableFiltering = true;
            this.ContactsGrid.Name = "ContactsGrid";
            this.ContactsGrid.ReadOnly = true;
            this.ContactsGrid.ShowGroupPanel = false;
            this.ContactsGrid.ShowItemToolTips = false;
            this.ContactsGrid.Size = new System.Drawing.Size(951, 565);
            this.ContactsGrid.TabIndex = 28;
            this.ContactsGrid.Text = "radGridView1";
            this.ContactsGrid.ThemeName = "TelerikMetro";
            this.ContactsGrid.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.ContactsGrid_CellDoubleClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(18, 46);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 23);
            this.txtName.TabIndex = 52;
            this.txtName.TabStop = false;
            this.txtName.ThemeName = "TelerikMetro";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.radLabel3.ForeColor = System.Drawing.Color.Red;
            this.radLabel3.Location = new System.Drawing.Point(67, 16);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(14, 24);
            this.radLabel3.TabIndex = 51;
            this.radLabel3.Text = "*";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(18, 19);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(43, 21);
            this.radLabel4.TabIndex = 50;
            this.radLabel4.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(19, 116);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            // 
            // 
            // 
            this.txtAddress.RootElement.StretchVertically = true;
            this.txtAddress.Size = new System.Drawing.Size(262, 83);
            this.txtAddress.TabIndex = 54;
            this.txtAddress.TabStop = false;
            this.txtAddress.ThemeName = "TelerikMetro";
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel7.Location = new System.Drawing.Point(19, 85);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(56, 21);
            this.radLabel7.TabIndex = 53;
            this.radLabel7.Text = "Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(19, 313);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 23);
            this.txtEmail.TabIndex = 58;
            this.txtEmail.TabStop = false;
            this.txtEmail.ThemeName = "TelerikMetro";
            // 
            // radLabel10
            // 
            this.radLabel10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel10.Location = new System.Drawing.Point(19, 283);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(39, 21);
            this.radLabel10.TabIndex = 57;
            this.radLabel10.Text = "Email";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(18, 245);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(263, 23);
            this.txtMobile.TabIndex = 56;
            this.txtMobile.TabStop = false;
            this.txtMobile.ThemeName = "TelerikMetro";
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel8.Location = new System.Drawing.Point(18, 214);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(49, 21);
            this.radLabel8.TabIndex = 55;
            this.radLabel8.Text = "Mobile";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(19, 450);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(262, 23);
            this.txtDesignation.TabIndex = 62;
            this.txtDesignation.TabStop = false;
            this.txtDesignation.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(19, 420);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(80, 21);
            this.radLabel1.TabIndex = 61;
            this.radLabel1.Text = "Designation";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(18, 382);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(263, 23);
            this.txtCompany.TabIndex = 60;
            this.txtCompany.TabStop = false;
            this.txtCompany.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(18, 351);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(65, 21);
            this.radLabel2.TabIndex = 59;
            this.radLabel2.Text = "Company";
            // 
            // btnUpdateSchedule
            // 
            this.btnUpdateSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateSchedule.Location = new System.Drawing.Point(97, 507);
            this.btnUpdateSchedule.Name = "btnUpdateSchedule";
            this.btnUpdateSchedule.Size = new System.Drawing.Size(71, 32);
            this.btnUpdateSchedule.TabIndex = 64;
            this.btnUpdateSchedule.Text = "Update";
            this.btnUpdateSchedule.ThemeName = "TelerikMetro";
            this.btnUpdateSchedule.Click += new System.EventHandler(this.btnUpdateSchedule_Click);
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddSchedule.Location = new System.Drawing.Point(19, 507);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(72, 32);
            this.btnAddSchedule.TabIndex = 63;
            this.btnAddSchedule.Text = "Add";
            this.btnAddSchedule.ThemeName = "TelerikMetro";
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // txtContactId
            // 
            this.txtContactId.Location = new System.Drawing.Point(18, 561);
            this.txtContactId.Name = "txtContactId";
            this.txtContactId.Size = new System.Drawing.Size(262, 23);
            this.txtContactId.TabIndex = 65;
            this.txtContactId.TabStop = false;
            this.txtContactId.ThemeName = "TelerikMetro";
            this.txtContactId.Visible = false;
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.txtContactId);
            this.Controls.Add(this.btnUpdateSchedule);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.radLabel10);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.ContactsGrid);
            this.Name = "Contacts";
            this.Size = new System.Drawing.Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView ContactsGrid;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtAddress;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private Telerik.WinControls.UI.RadTextBox txtMobile;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadTextBox txtDesignation;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtCompany;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnUpdateSchedule;
        private Telerik.WinControls.UI.RadButton btnAddSchedule;
        private Telerik.WinControls.UI.RadTextBox txtContactId;
    }
}
