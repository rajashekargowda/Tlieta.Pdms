using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tlieta.Pdms.DataAccess;
using Telerik.Charting;
using Telerik.WinControls.UI;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            ddlYear.DataSource = GetYearTable();
            ddlYear.ValueMember = "Year";
            ddlYear.DisplayMember = "Year";
            ddlYear.FindItemExact(DateTime.Now.Year.ToString(), true).Selected = true;
            PopulateData.PopulateOperations(ddlOpertaion);
            PopulateData.SelectDropDownItem(ddlOpertaion, "0");

            LoadReportSurgeriesByHospital();
            LoadReportOperationsCount();
            LoadReportMonthlyOperations();
        }

        private DataTable GetYearTable()
        {
            DataTable dt = new DataTable("Year");
            dt.Columns.Add("Year", typeof(string));

            int currentyear = DateTime.Now.Year;
            for (int index = -2; index <= 2; index++)
            {
                DataRow drv = dt.NewRow();
                drv[0] = (currentyear + index).ToString() ; dt.Rows.Add(drv);
            }
            return dt;
        }

        private void LoadReportMonthlyOperations()
        {
            LoadChart(chartMonthlyOperations, new ReportsData().ReportMonthlyOperations(Convert.ToInt32(ddlOpertaion.SelectedValue.ToString()), ddlYear.SelectedItem.Text), "Month", "Count", "Month");
        }

        private void LoadReportOperationsCount()
        {
            LoadChart(chartOperationsCount, new ReportsData().ReportOperationsCount(), "Operation", "OperationCount", "Operation");
        }

        private void LoadReportSurgeriesByHospital()
        {
            LoadChart(chartSurgeryCount, new ReportsData().ReportSurgeriesByHospital(), "Hospital", "SurgeryCount", "Hospital");
        }

        private void LoadChart(RadChart chart, DataTable dt, string labelcolumn, string ycolumn, string seriesname)
        {
            if (dt != null)
            {
                chart.DataManager.DataSource = dt;
                //set the column in the datasource to be used for the labels    
                chart.DataManager.LabelsColumn = labelcolumn;
                chart.DataManager.ValuesYColumns = new string[] { ycolumn };
                //sets the labels so that there are no overlaps            
                chart.IntelligentLabelsEnabled = true;
                chart.DataBind();
                chart.Series[0].Name = seriesname;
                //the legend will display the labels of the items, instead of the name of the series             
                chart.Series[0].Appearance.LegendDisplayMode = Telerik.Charting.ChartSeriesLegendDisplayMode.Nothing;
                chart.Update();
            }
            else { chart.Clear(); chart.Update(); chart.Refresh(); }
        }

        private void btnRefreshChart1_Click(object sender, EventArgs e)
        {
            LoadReportSurgeriesByHospital();
        }

        private void btnChart1Pie_Click(object sender, EventArgs e)
        {
            ConvertToPie(chartSurgeryCount);
        }

        private void btnChart1Bar_Click(object sender, EventArgs e)
        {
            ConvertToBar(chartSurgeryCount);
        }

        private void btnRefreshChart2_Click(object sender, EventArgs e)
        {
            LoadReportOperationsCount();
        }

        private void btnCart2Pie_Click(object sender, EventArgs e)
        {
            ConvertToPie(chartOperationsCount);
        }

        private void btnChart2Bar_Click(object sender, EventArgs e)
        {
            ConvertToBar(chartOperationsCount);
        }

        private void btnChart3Line_Click(object sender, EventArgs e)
        {
            chartMonthlyOperations.Series[0].Type = Telerik.Charting.ChartSeriesType.Line;
            chartMonthlyOperations.Update();
            chartMonthlyOperations.Refresh();
        }

        private void btnChart3Pie_Click(object sender, EventArgs e)
        {
            ConvertToPie(chartMonthlyOperations);
        }

        private void ConvertToPie(RadChart chart)
        {
            chart.Series[0].Type = Telerik.Charting.ChartSeriesType.Pie;
            chart.Update();
            chart.Refresh();
        }

        private void ConvertToBar(RadChart chart)
        {
            chart.Series[0].Type = Telerik.Charting.ChartSeriesType.Bar;
            chart.Update();
            chart.Refresh();
        }

        private void ddlYear_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ddlOpertaion.SelectedItem != null && ddlOpertaion.SelectedValue.ToString() != "System.Data.DataRowView")
                LoadChart(chartMonthlyOperations, new ReportsData().ReportMonthlyOperations(Convert.ToInt32(ddlOpertaion.SelectedItem.Value.ToString()), ddlYear.SelectedItem.Text), "Month", "Count", "Month");
        }
            
        private void ddlOpertaion_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
                if (ddlOpertaion.SelectedItem != null && ddlOpertaion.SelectedValue.ToString() != "System.Data.DataRowView")
                LoadChart(chartMonthlyOperations, new ReportsData().ReportMonthlyOperations(Convert.ToInt32(ddlOpertaion.SelectedItem.Value.ToString()), ddlYear.SelectedItem.Text), "Month", "Count", "Month");
        }

        private void btnChart3Refresh_Click(object sender, EventArgs e)
        {
            LoadReportMonthlyOperations();
        }
        
    }
}
