namespace Tlieta.Pdms.Views.Shared
{
    partial class Appointments
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
            Telerik.WinControls.UI.DateTimeInterval dateTimeInterval1 = new Telerik.WinControls.UI.DateTimeInterval();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.radLabel14 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radDateStart = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radTimeStart = new Telerik.WinControls.UI.RadTimePicker();
            this.radTimeEnd = new Telerik.WinControls.UI.RadTimePicker();
            this.radDateEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtSummary = new Telerik.WinControls.UI.RadTextBox();
            this.txtLocation = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.btnAddSchedule = new Telerik.WinControls.UI.RadButton();
            this.btnUpdateSchedule = new Telerik.WinControls.UI.RadButton();
            this.txtId = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.SuspendLayout();
            // 
            // radScheduler1
            // 
            dateTimeInterval1.End = new System.DateTime(((long)(0)));
            dateTimeInterval1.Start = new System.DateTime(((long)(0)));
            this.radScheduler1.AccessibleInterval = dateTimeInterval1;
            this.radScheduler1.AllowAppointmentCreateInline = false;
            this.radScheduler1.AllowAppointmentMove = false;
            this.radScheduler1.AllowAppointmentResize = false;
            this.radScheduler1.AppointmentTitleFormat = null;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-GB");
            this.radScheduler1.DataSource = null;
            this.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.radScheduler1.HeaderFormat = "dd dddd";
            this.radScheduler1.Location = new System.Drawing.Point(308, 104);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2013, 9, 27, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2013, 9, 22, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.Size = new System.Drawing.Size(989, 493);
            this.radScheduler1.TabIndex = 0;
            this.radScheduler1.Text = "radScheduler1";
            this.radScheduler1.ThemeName = "TelerikMetro";
            this.radScheduler1.AppointmentDeleted += new System.EventHandler<Telerik.WinControls.UI.SchedulerAppointmentEventArgs>(this.radScheduler1_AppointmentDeleted);
            this.radScheduler1.AppointmentSelected += new System.EventHandler<Telerik.WinControls.UI.SchedulerAppointmentEventArgs>(this.radScheduler1_AppointmentSelected);
            this.radScheduler1.AppointmentEditDialogShowing += new System.EventHandler<Telerik.WinControls.UI.AppointmentEditDialogShowingEventArgs>(this.radScheduler1_AppointmentEditDialogShowing);
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
            this.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd";
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(308, 3);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(989, 77);
            this.radSchedulerNavigator1.TabIndex = 1;
            this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.ThemeName = "TelerikMetro";
            // 
            // radLabel14
            // 
            this.radLabel14.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.radLabel14.ForeColor = System.Drawing.Color.Red;
            this.radLabel14.Location = new System.Drawing.Point(55, 23);
            this.radLabel14.Name = "radLabel14";
            this.radLabel14.Size = new System.Drawing.Size(14, 24);
            this.radLabel14.TabIndex = 26;
            this.radLabel14.Text = "*";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(14, 26);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(35, 21);
            this.radLabel6.TabIndex = 25;
            this.radLabel6.Text = "Start";
            // 
            // radDateStart
            // 
            this.radDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.radDateStart.Location = new System.Drawing.Point(14, 54);
            this.radDateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateStart.MinDate = new System.DateTime(((long)(0)));
            this.radDateStart.Name = "radDateStart";
            this.radDateStart.NullableValue = new System.DateTime(2013, 9, 22, 15, 32, 29, 443);
            this.radDateStart.NullDate = new System.DateTime(((long)(0)));
            this.radDateStart.Size = new System.Drawing.Size(150, 20);
            this.radDateStart.TabIndex = 27;
            this.radDateStart.TabStop = false;
            this.radDateStart.Text = "22 September 2013";
            this.radDateStart.ThemeName = "TelerikMetro";
            this.radDateStart.Value = new System.DateTime(2013, 9, 22, 15, 32, 29, 443);
            // 
            // radTimeStart
            // 
            this.radTimeStart.ClockPosition = Telerik.WinControls.UI.ClockPosition.HideClock;
            this.radTimeStart.HeadersHeight = 19;
            this.radTimeStart.Location = new System.Drawing.Point(171, 54);
            this.radTimeStart.Name = "radTimeStart";
            this.radTimeStart.Size = new System.Drawing.Size(106, 20);
            this.radTimeStart.TabIndex = 28;
            this.radTimeStart.TabStop = false;
            this.radTimeStart.ThemeName = "TelerikMetro";
            this.radTimeStart.Value = new System.DateTime(2013, 9, 22, 15, 35, 26, 0);
            // 
            // radTimeEnd
            // 
            this.radTimeEnd.ClockPosition = Telerik.WinControls.UI.ClockPosition.HideClock;
            this.radTimeEnd.HeadersHeight = 19;
            this.radTimeEnd.Location = new System.Drawing.Point(171, 122);
            this.radTimeEnd.Name = "radTimeEnd";
            this.radTimeEnd.Size = new System.Drawing.Size(106, 20);
            this.radTimeEnd.TabIndex = 32;
            this.radTimeEnd.TabStop = false;
            this.radTimeEnd.ThemeName = "TelerikMetro";
            this.radTimeEnd.Value = new System.DateTime(2013, 9, 22, 15, 35, 26, 0);
            // 
            // radDateEnd
            // 
            this.radDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.radDateEnd.Location = new System.Drawing.Point(14, 122);
            this.radDateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateEnd.MinDate = new System.DateTime(((long)(0)));
            this.radDateEnd.Name = "radDateEnd";
            this.radDateEnd.NullableValue = new System.DateTime(2013, 9, 22, 15, 32, 29, 443);
            this.radDateEnd.NullDate = new System.DateTime(((long)(0)));
            this.radDateEnd.Size = new System.Drawing.Size(150, 20);
            this.radDateEnd.TabIndex = 31;
            this.radDateEnd.TabStop = false;
            this.radDateEnd.Text = "22 September 2013";
            this.radDateEnd.ThemeName = "TelerikMetro";
            this.radDateEnd.Value = new System.DateTime(2013, 9, 22, 15, 32, 29, 443);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.radLabel1.ForeColor = System.Drawing.Color.Red;
            this.radLabel1.Location = new System.Drawing.Point(55, 91);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(14, 24);
            this.radLabel1.TabIndex = 30;
            this.radLabel1.Text = "*";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(14, 94);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(30, 21);
            this.radLabel2.TabIndex = 29;
            this.radLabel2.Text = "End";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.radLabel3.ForeColor = System.Drawing.Color.Red;
            this.radLabel3.Location = new System.Drawing.Point(84, 164);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(14, 24);
            this.radLabel3.TabIndex = 34;
            this.radLabel3.Text = "*";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(14, 167);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(52, 21);
            this.radLabel4.TabIndex = 33;
            this.radLabel4.Text = "Subject";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(14, 194);
            this.txtSummary.MaxLength = 30;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(263, 20);
            this.txtSummary.TabIndex = 49;
            this.txtSummary.TabStop = false;
            this.txtSummary.ThemeName = "TelerikMetro";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(14, 379);
            this.txtLocation.MaxLength = 30;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(263, 20);
            this.txtLocation.TabIndex = 52;
            this.txtLocation.TabStop = false;
            this.txtLocation.ThemeName = "TelerikMetro";
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel7.Location = new System.Drawing.Point(14, 352);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(59, 21);
            this.radLabel7.TabIndex = 50;
            this.radLabel7.Text = "Location";
            // 
            // radLabel9
            // 
            this.radLabel9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel9.Location = new System.Drawing.Point(14, 237);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(76, 21);
            this.radLabel9.TabIndex = 53;
            this.radLabel9.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(14, 264);
            this.txtDescription.MaxLength = 400;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            // 
            // 
            // 
            this.txtDescription.RootElement.StretchVertically = true;
            this.txtDescription.Size = new System.Drawing.Size(263, 67);
            this.txtDescription.TabIndex = 55;
            this.txtDescription.TabStop = false;
            this.txtDescription.ThemeName = "TelerikMetro";
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddSchedule.Location = new System.Drawing.Point(18, 447);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(72, 32);
            this.btnAddSchedule.TabIndex = 56;
            this.btnAddSchedule.Text = "Add";
            this.btnAddSchedule.ThemeName = "TelerikMetro";
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnUpdateSchedule
            // 
            this.btnUpdateSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateSchedule.Location = new System.Drawing.Point(96, 447);
            this.btnUpdateSchedule.Name = "btnUpdateSchedule";
            this.btnUpdateSchedule.Size = new System.Drawing.Size(71, 32);
            this.btnUpdateSchedule.TabIndex = 57;
            this.btnUpdateSchedule.Text = "Update";
            this.btnUpdateSchedule.ThemeName = "TelerikMetro";
            this.btnUpdateSchedule.Click += new System.EventHandler(this.btnUpdateSchedule_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(14, 559);
            this.txtId.MaxLength = 100;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(263, 20);
            this.txtId.TabIndex = 59;
            this.txtId.TabStop = false;
            this.txtId.ThemeName = "TelerikMetro";
            this.txtId.Visible = false;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnUpdateSchedule);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radTimeEnd);
            this.Controls.Add(this.radDateEnd);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radTimeStart);
            this.Controls.Add(this.radDateStart);
            this.Controls.Add(this.radLabel14);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radSchedulerNavigator1);
            this.Controls.Add(this.radScheduler1);
            this.Name = "Appointments";
            this.Size = new System.Drawing.Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadLabel radLabel14;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadDateTimePicker radDateStart;
        private Telerik.WinControls.UI.RadTimePicker radTimeStart;
        private Telerik.WinControls.UI.RadDateTimePicker radDateEnd;
        private Telerik.WinControls.UI.RadTimePicker radTimeEnd;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtSummary;
        private Telerik.WinControls.UI.RadTextBox txtLocation;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadTextBox txtDescription;
        private Telerik.WinControls.UI.RadButton btnAddSchedule;
        private Telerik.WinControls.UI.RadButton btnUpdateSchedule;
        private Telerik.WinControls.UI.RadTextBox txtId;
    }
}
