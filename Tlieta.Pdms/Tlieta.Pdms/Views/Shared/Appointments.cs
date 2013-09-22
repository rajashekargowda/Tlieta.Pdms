using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Tlieta.Pdms.DataAccess;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class Appointments : UserControl
    {
        public Appointments()
        {
            InitializeComponent();

            LoadSchedulerGrid();
        }

        private void LoadSchedulerGrid()
        {
            BindingList<Appointment> appointments = new SchedulerData().GetAppointments();

            // create and configure a scheduler binding source
            SchedulerBindingDataSource dataSource = new SchedulerBindingDataSource();
            // map the MyAppointment properties to the scheduler
            AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();
            appointmentMappingInfo.Start = "Start";
            appointmentMappingInfo.End = "End";
            appointmentMappingInfo.Summary = "Summary";
            appointmentMappingInfo.Description = "Description";
            appointmentMappingInfo.Location = "Location";
            appointmentMappingInfo.UniqueId = "Id";
            dataSource.EventProvider.Mapping = appointmentMappingInfo;
            // assign the generic List of CustomAppointment as the EventProvider data source
            dataSource.EventProvider.DataSource = appointments;
            this.radScheduler1.DataSource = dataSource;
        }

        private void radScheduler1_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            e.Cancel = true;
        }

        private void radScheduler1_AppointmentSelected(object sender, SchedulerAppointmentEventArgs e)
        {
            radDateStart.Value = e.Appointment.Start;
            radTimeStart.Value = e.Appointment.Start;
            radDateEnd.Value = e.Appointment.End;
            radTimeEnd.Value = e.Appointment.End;
            txtId.Text = e.Appointment.UniqueId.KeyValue.ToString();
            txtSummary.Text = e.Appointment.Summary;
            txtDescription.Text = e.Appointment.Description;
            txtLocation.Text = e.Appointment.Location;
        }

        private void radScheduler1_AppointmentDeleted(object sender, SchedulerAppointmentEventArgs e)
        {
            int id = Convert.ToInt32(e.Appointment.UniqueId.KeyValue);
            int result = new SchedulerData().DeleteSchedule(id);

            RefreshTexts();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            DateTime startdate = (DateTime)(radDateStart.DateTimePickerElement.Value);
            DateTime starttime = (DateTime)(radTimeStart.Value);
            DateTime start = new DateTime(startdate.Year, startdate.Month, startdate.Day, starttime.Hour, starttime.Minute, starttime.Second);

            DateTime enddate = (DateTime)(radDateEnd.DateTimePickerElement.Value);
            DateTime endtime = (DateTime)(radTimeEnd.Value);
            DateTime end = new DateTime(enddate.Year, enddate.Month, enddate.Day, endtime.Hour, endtime.Minute, endtime.Second);

            string summary = txtSummary.Text.Trim();

            if (start == DateTime.MinValue || end == DateTime.MinValue || summary == "")
            {
                MessageBox.Show("Enter all mandatory values");
                return;
            }
            else if (end < start)
            {
                MessageBox.Show("Start date should be less than or equal end date");
                return;
            }

            int result = new SchedulerData().AddSchedule(start, end, summary, txtDescription.Text, txtLocation.Text);

            LoadSchedulerGrid();
            RefreshTexts();
        }

        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {
            DateTime startdate = (DateTime)(radDateStart.DateTimePickerElement.Value);
            DateTime starttime = (DateTime)(radTimeStart.Value);
            DateTime start = new DateTime(startdate.Year, startdate.Month, startdate.Day, starttime.Hour, starttime.Minute, starttime.Second);

            DateTime enddate = (DateTime)(radDateEnd.DateTimePickerElement.Value);
            DateTime endtime = (DateTime)(radTimeEnd.Value);
            DateTime end = new DateTime(enddate.Year, enddate.Month, enddate.Day, endtime.Hour, endtime.Minute, endtime.Second);

            string summary = txtSummary.Text.Trim();
            int id = 0;
            try
            {
                id = Convert.ToInt32(txtId.Text.Trim());
            }
            catch { id = 0; }


            if (start == DateTime.MinValue || end == DateTime.MinValue || summary == "")
            {
                MessageBox.Show("Enter all mandatory values");
                return;
            }
            else if (end < start)
            {
                MessageBox.Show("Start date should be less than or equal end date");
                return;
            }
            else if (id == 0)
            {
                MessageBox.Show("Select appointment to update");
                return;
            }

            int result = new SchedulerData().UpdateSchedule(id, start, end, summary, txtDescription.Text, txtLocation.Text);

            LoadSchedulerGrid();
            RefreshTexts();
        }

        private void RefreshTexts()
        {
            txtId.Text = "";
            txtSummary.Text = "";
            txtDescription.Text = "";
            txtLocation.Text = "";
        }
    }
}
