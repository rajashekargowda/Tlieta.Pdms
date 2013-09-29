using System;
using System.Data;
using System.Windows.Forms;
using Tlieta.Pdms.DataAccess;
using Telerik.WinControls.Themes;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class LogBook : UserControl
    {
        public LogBook()
        {
            InitializeComponent();

            new TelerikMetroTheme();

            PopulateData.PopulateHospital(ddlHospital);
            PopulateData.PopulateOperations(ddlOpertaion);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlOpertaion.SelectedValue.ToString() != "0")
                {
                    DataTable dt = new ReportsData().GetReportLogBook(Convert.ToInt32(ddlOpertaion.SelectedValue.ToString()), Convert.ToInt32(ddlHospital.SelectedValue.ToString()));

                    SearchGrid.DataSource = dt;
                    //SearchGrid.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
                    SearchGrid.ClearSelection();


                    SearchGrid.Columns[0].Width = 30;
                    SearchGrid.Columns[1].Width = 120;
                    SearchGrid.Columns[2].Width = 50;
                    SearchGrid.Columns[3].Width = 50;
                    SearchGrid.Columns[4].Width = 120;
                    SearchGrid.Columns[5].Width = 120;
                    SearchGrid.Columns[6].Width = 170;
                    SearchGrid.Columns[7].Width = 170;


                    SearchGrid.Columns[0].AllowFiltering = false;
                    SearchGrid.Columns[1].AllowFiltering = false;
                    SearchGrid.Columns[2].AllowFiltering = false;
                    SearchGrid.Columns[3].AllowFiltering = false;
                    SearchGrid.Columns[6].AllowFiltering = false;
                    SearchGrid.Columns[7].AllowFiltering = false;
                }
                else
                {
                    MessageBox.Show("Select an operation name"); return;
                }
            }
            catch { }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.SearchGrid.Print(true, this.radPrintDocument1);
        }
    }
}
