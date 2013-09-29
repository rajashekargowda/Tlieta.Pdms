using System;
using System.Data;
using System.Windows.Forms;
using Tlieta.Pdms.DataAccess;
using Telerik.WinControls.Themes;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class Appointment : UserControl
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime from = GetDateFromControl(FromDate);
                DateTime to = GetDateFromControl(ToDate);

                DataTable dt = new AppointmentData().GetAppointments(from, to);

                AppointmentsGrid.DataSource = dt;
                //SearchGrid.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
                AppointmentsGrid.ClearSelection();

                //SearchGrid.Columns[0].Width = 170;
                //SearchGrid.Columns[1].Width = 120;
                //SearchGrid.Columns[2].Width = 50;
                //SearchGrid.Columns[3].Width = 50;


                AppointmentsGrid.Columns[0].AllowFiltering = false;
                AppointmentsGrid.Columns[1].AllowFiltering = false;
                AppointmentsGrid.Columns[2].AllowFiltering = false;
                AppointmentsGrid.Columns[3].AllowFiltering = false;
            }
            catch { }

        }

        private DateTime GetDateFromControl(Telerik.WinControls.UI.RadDateTimePicker date)
        {
            try
            {
                return (DateTime)(date.DateTimePickerElement.Value);
            }
            catch { return DateTime.Now; }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.AppointmentsGrid.Print(true, this.radPrintDocument1);
        }
    }
}
