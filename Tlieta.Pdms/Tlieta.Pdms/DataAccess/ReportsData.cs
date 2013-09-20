using System;
using System.Data;
using Tlieta.DataAccess;

namespace Tlieta.Pdms.DataAccess
{
    public class ReportsData
    {
        DataSet _ds = null;

        public DataTable ReportSurgeriesByHospital()
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spReportSurgeriesByHospital");
                if (_ds != null && _ds.Tables[0].Rows.Count > 0)
                {
                    return _ds.Tables[0];
                }
                else { return null; }
            }
        }

        public DataTable ReportOperationsCount()
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spReportOperationsCount");
                if (_ds != null && _ds.Tables[0].Rows.Count > 0)
                {
                    return _ds.Tables[0];
                }
                else { return null; }
            }
        }

        public DataTable ReportMonthlyOperations(int operation, string year)
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                db.CreateParameters(2);
                db.AddParameters(0, "@operation", operation);
                db.AddParameters(1, "@year", year);
                _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spReportMonthlyOperations");
                if (_ds != null && _ds.Tables[0].Rows.Count > 0)
                {
                    return GetMonthlyData( _ds.Tables[0]);
                }
                else { return null; }
            }
        }

        public DataTable GetMonthlyData(DataTable dtInput)
        {
            DataTable dt = new DataTable("Monthly");
            dt.Columns.Add("Count", typeof(int));
            dt.Columns.Add("Month", typeof(string));

            DataRow dr = dtInput.Rows[0];
            foreach (DataColumn dc in dtInput.Columns)
            {
                DataRow drv = dt.NewRow();
                drv[0] = dr[dc]; drv[1] = dc.ColumnName; dt.Rows.Add(drv);
            }
            return dt;
        }

        public DataTable GetReportLogBook(int operation, int hospital)
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                db.CreateParameters(2);
                db.AddParameters(0, "@HospitalId", hospital);
                db.AddParameters(1, "@OperationId", operation);
                _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spReportLogBook");
                if (_ds != null && _ds.Tables[0].Rows.Count > 0)
                {
                    return _ds.Tables[0];
                }
                else { return null; }
            }
        }
    }
}
