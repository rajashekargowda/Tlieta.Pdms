﻿namespace Tlieta.Pdms.Views.Shared
{
    partial class BillingView
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
            this.txtAmount = new Telerik.WinControls.UI.RadSpinEditor();
            this.btnReset = new Telerik.WinControls.UI.RadButton();
            this.txtNotes = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.chkDebit = new Telerik.WinControls.UI.RadCheckBox();
            this.chkCredit = new Telerik.WinControls.UI.RadCheckBox();
            this.ToDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.FromDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.FinanceGrid = new Telerik.WinControls.UI.RadGridView();
            this.btnDeleteBilling = new Telerik.WinControls.UI.RadButton();
            this.txtBillingId = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnUpdateBilling = new Telerik.WinControls.UI.RadButton();
            this.btnAddBilling = new Telerik.WinControls.UI.RadButton();
            this.txtBillNumber = new Telerik.WinControls.UI.RadTextBox();
            this.radBillDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radPrintDocument1 = new Telerik.WinControls.UI.RadPrintDocument();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDebit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinanceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinanceGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBillDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(32, 240);
            this.txtAmount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            // 
            // 
            // 
            this.txtAmount.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.txtAmount.Size = new System.Drawing.Size(263, 22);
            this.txtAmount.TabIndex = 136;
            this.txtAmount.TabStop = false;
            this.txtAmount.ThemeName = "TelerikMetroBlue";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(266, 423);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(71, 32);
            this.btnReset.TabIndex = 135;
            this.btnReset.Text = "Reset";
            this.btnReset.ThemeName = "TelerikMetroBlue";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.AutoSize = false;
            this.txtNotes.Location = new System.Drawing.Point(32, 310);
            this.txtNotes.MaxLength = 400;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(263, 83);
            this.txtNotes.TabIndex = 134;
            this.txtNotes.TabStop = false;
            // 
            // radLabel13
            // 
            this.radLabel13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel13.Location = new System.Drawing.Point(32, 283);
            this.radLabel13.Name = "radLabel13";
            this.radLabel13.Size = new System.Drawing.Size(43, 21);
            this.radLabel13.TabIndex = 133;
            this.radLabel13.Text = "Notes";
            // 
            // chkDebit
            // 
            this.chkDebit.Location = new System.Drawing.Point(94, 215);
            this.chkDebit.Name = "chkDebit";
            this.chkDebit.Size = new System.Drawing.Size(53, 19);
            this.chkDebit.TabIndex = 132;
            this.chkDebit.Text = "Debit";
            this.chkDebit.ThemeName = "TelerikMetroBlue";
            this.chkDebit.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkDebit_ToggleStateChanged);
            // 
            // chkCredit
            // 
            this.chkCredit.Location = new System.Drawing.Point(32, 214);
            this.chkCredit.Name = "chkCredit";
            this.chkCredit.Size = new System.Drawing.Size(56, 19);
            this.chkCredit.TabIndex = 131;
            this.chkCredit.Text = "Credit";
            this.chkCredit.ThemeName = "TelerikMetroBlue";
            this.chkCredit.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkCredit_ToggleStateChanged);
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(611, 46);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(150, 22);
            this.ToDate.TabIndex = 130;
            this.ToDate.TabStop = false;
            this.ToDate.Text = "22 September 2013";
            this.ToDate.ThemeName = "TelerikMetroBlue";
            this.ToDate.Value = new System.DateTime(2013, 9, 22, 15, 32, 29, 443);
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(572, 46);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(33, 21);
            this.radLabel5.TabIndex = 129;
            this.radLabel5.Text = "To : ";
            // 
            // FromDate
            // 
            this.FromDate.Location = new System.Drawing.Point(402, 46);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(150, 22);
            this.FromDate.TabIndex = 128;
            this.FromDate.TabStop = false;
            this.FromDate.Text = "22 September 2013";
            this.FromDate.ThemeName = "TelerikMetroBlue";
            this.FromDate.Value = new System.DateTime(2013, 9, 22, 15, 32, 29, 443);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(347, 46);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(49, 21);
            this.radLabel3.TabIndex = 127;
            this.radLabel3.Text = "From : ";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(955, 46);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(102, 24);
            this.btnPrint.TabIndex = 126;
            this.btnPrint.Text = "Print";
            this.btnPrint.ThemeName = "TelerikMetroBlue";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(800, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 24);
            this.btnSearch.TabIndex = 125;
            this.btnSearch.Text = "Search";
            this.btnSearch.ThemeName = "TelerikMetroBlue";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FinanceGrid
            // 
            this.FinanceGrid.AutoScroll = true;
            this.FinanceGrid.Location = new System.Drawing.Point(347, 89);
            // 
            // FinanceGrid
            // 
            this.FinanceGrid.MasterTemplate.AllowAddNewRow = false;
            this.FinanceGrid.MasterTemplate.AllowCellContextMenu = false;
            this.FinanceGrid.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.FinanceGrid.MasterTemplate.AllowDeleteRow = false;
            this.FinanceGrid.MasterTemplate.AllowDragToGroup = false;
            this.FinanceGrid.MasterTemplate.AllowEditRow = false;
            this.FinanceGrid.MasterTemplate.EnableAlternatingRowColor = true;
            this.FinanceGrid.Name = "FinanceGrid";
            this.FinanceGrid.ReadOnly = true;
            this.FinanceGrid.ShowGroupPanel = false;
            this.FinanceGrid.ShowItemToolTips = false;
            this.FinanceGrid.Size = new System.Drawing.Size(921, 467);
            this.FinanceGrid.TabIndex = 124;
            this.FinanceGrid.Text = "radGridView1";
            this.FinanceGrid.ThemeName = "TelerikMetroBlue";
            this.FinanceGrid.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.FinanceGrid_CellDoubleClick);
            // 
            // btnDeleteBilling
            // 
            this.btnDeleteBilling.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteBilling.Location = new System.Drawing.Point(189, 423);
            this.btnDeleteBilling.Name = "btnDeleteBilling";
            this.btnDeleteBilling.Size = new System.Drawing.Size(71, 32);
            this.btnDeleteBilling.TabIndex = 121;
            this.btnDeleteBilling.Text = "Delete";
            this.btnDeleteBilling.ThemeName = "TelerikMetroBlue";
            this.btnDeleteBilling.Click += new System.EventHandler(this.btnDeleteBilling_Click);
            // 
            // txtBillingId
            // 
            this.txtBillingId.Location = new System.Drawing.Point(32, 533);
            this.txtBillingId.MaxLength = 30;
            this.txtBillingId.Name = "txtBillingId";
            this.txtBillingId.Size = new System.Drawing.Size(263, 20);
            this.txtBillingId.TabIndex = 123;
            this.txtBillingId.TabStop = false;
            this.txtBillingId.ThemeName = "TelerikMetro";
            this.txtBillingId.Visible = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(32, 187);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(56, 21);
            this.radLabel2.TabIndex = 122;
            this.radLabel2.Text = "Amount";
            // 
            // btnUpdateBilling
            // 
            this.btnUpdateBilling.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateBilling.Location = new System.Drawing.Point(111, 423);
            this.btnUpdateBilling.Name = "btnUpdateBilling";
            this.btnUpdateBilling.Size = new System.Drawing.Size(71, 32);
            this.btnUpdateBilling.TabIndex = 120;
            this.btnUpdateBilling.Text = "Update";
            this.btnUpdateBilling.ThemeName = "TelerikMetroBlue";
            this.btnUpdateBilling.Click += new System.EventHandler(this.btnUpdateBilling_Click);
            // 
            // btnAddBilling
            // 
            this.btnAddBilling.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddBilling.Location = new System.Drawing.Point(32, 423);
            this.btnAddBilling.Name = "btnAddBilling";
            this.btnAddBilling.Size = new System.Drawing.Size(72, 32);
            this.btnAddBilling.TabIndex = 119;
            this.btnAddBilling.Text = "Add";
            this.btnAddBilling.ThemeName = "TelerikMetroBlue";
            this.btnAddBilling.Click += new System.EventHandler(this.btnAddBilling_Click);
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Location = new System.Drawing.Point(32, 143);
            this.txtBillNumber.MaxLength = 30;
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(263, 20);
            this.txtBillNumber.TabIndex = 118;
            this.txtBillNumber.TabStop = false;
            // 
            // radBillDate
            // 
            this.radBillDate.Location = new System.Drawing.Point(32, 73);
            this.radBillDate.Name = "radBillDate";
            this.radBillDate.Size = new System.Drawing.Size(150, 22);
            this.radBillDate.TabIndex = 116;
            this.radBillDate.TabStop = false;
            this.radBillDate.Text = "22 September 2013";
            this.radBillDate.ThemeName = "TelerikMetroBlue";
            this.radBillDate.Value = new System.DateTime(2013, 9, 22, 15, 32, 29, 443);
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(32, 45);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(57, 21);
            this.radLabel6.TabIndex = 115;
            this.radLabel6.Text = "Bill Date";
            // 
            // radPrintDocument1
            // 
            this.radPrintDocument1.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPrintDocument1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPrintDocument1.Watermark = radPrintWatermark1;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(32, 116);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(78, 21);
            this.radLabel4.TabIndex = 117;
            this.radLabel4.Text = "Bill Number";
            // 
            // BillingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.radLabel13);
            this.Controls.Add(this.chkDebit);
            this.Controls.Add(this.chkCredit);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.FinanceGrid);
            this.Controls.Add(this.btnDeleteBilling);
            this.Controls.Add(this.txtBillingId);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btnUpdateBilling);
            this.Controls.Add(this.btnAddBilling);
            this.Controls.Add(this.txtBillNumber);
            this.Controls.Add(this.radBillDate);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel4);
            this.Name = "BillingView";
            this.Size = new System.Drawing.Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDebit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinanceGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinanceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillingId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBillDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadSpinEditor txtAmount;
        private Telerik.WinControls.UI.RadButton btnReset;
        private Telerik.WinControls.UI.RadTextBox txtNotes;
        private Telerik.WinControls.UI.RadLabel radLabel13;
        private Telerik.WinControls.UI.RadCheckBox chkDebit;
        private Telerik.WinControls.UI.RadCheckBox chkCredit;
        private Telerik.WinControls.UI.RadDateTimePicker ToDate;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDateTimePicker FromDate;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadGridView FinanceGrid;
        private Telerik.WinControls.UI.RadButton btnDeleteBilling;
        private Telerik.WinControls.UI.RadTextBox txtBillingId;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnUpdateBilling;
        private Telerik.WinControls.UI.RadButton btnAddBilling;
        private Telerik.WinControls.UI.RadTextBox txtBillNumber;
        private Telerik.WinControls.UI.RadDateTimePicker radBillDate;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
    }
}
