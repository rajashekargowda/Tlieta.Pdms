using System;
using System.ComponentModel;
using System.Data;
using Tlieta.DataAccess;
using Tlieta.Pdms.Views.Shared;

namespace Tlieta.Pdms.DataAccess
{
    public class AppointmentData
    {
        DataSet _ds = null;

        public DataTable GetAppointments(DateTime from, DateTime to)
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                db.CreateParameters(2);
                db.AddParameters(0, "@FromDate", from);
                db.AddParameters(1, "@ToDate", to);
                _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetAppointments");
                if (_ds != null && _ds.Tables[0].Rows.Count > 0)
                {
                    return _ds.Tables[0];
                }
                else { return null; }
            }
        }

        public int AddSchedule(DateTime start, string name, string id, string mobile, string email)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(5);
                    db.AddParameters(0, "@AppointmentDate", start);
                    db.AddParameters(1, "@Name", name);
                    db.AddParameters(2, "@PatientId", id);
                    db.AddParameters(3, "@Mobile", mobile);
                    db.AddParameters(4, "@Email", email);
                    return db.ExecuteNonQuery(CommandType.StoredProcedure, "spAddAppointment");
                }
            }
            catch { return 0; }
        }

        public int UpdateSchedule(int id, DateTime start, string name, string patientid, string mobile, string email)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(6);
                    db.AddParameters(0, "@AppointmentId", id);
                    db.AddParameters(1, "@AppointmentDate", start);
                    db.AddParameters(2, "@Name", name);
                    db.AddParameters(3, "@PatientId", patientid);
                    db.AddParameters(4, "@Mobile", mobile);
                    db.AddParameters(5, "@Email", email);
                    return db.ExecuteNonQuery(CommandType.StoredProcedure, "spUpdateAppointment");
                }
            }
            catch { return 0; }
        }

        public int DeleteSchedule(int id)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(1);
                    db.AddParameters(0, "@AppointmentId", id);
                    return db.ExecuteNonQuery(CommandType.StoredProcedure, "spDeleteAppointment");
                }
            }
            catch { return 0; }
        }
    }
}
