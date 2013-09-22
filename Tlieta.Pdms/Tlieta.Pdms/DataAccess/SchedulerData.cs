using System;
using System.ComponentModel;
using System.Data;
using Tlieta.DataAccess;
using Tlieta.Pdms.Views.Shared;

namespace Tlieta.Pdms.DataAccess
{
    public class SchedulerData
    {
        DataSet _ds = null;

        public BindingList<Appointment> GetAppointments()
        {
            BindingList<Appointment> appointments = new BindingList<Appointment>();

            using (DBManager db = new DBManager())
            {
                db.Open();
                using (IDataReader reader = db.ExecuteReader(CommandType.StoredProcedure, "spGetSchedules"))
                {
                    while (reader.Read())
                    {
                        Appointment myAppointment = new Appointment(
                                                            Convert.ToInt32(reader["Id"].ToString()),
                                                            Convert.ToDateTime(reader["Start"].ToString()),
                                                            Convert.ToDateTime(reader["End"].ToString()),
                                                            reader["Summary"].ToString(),
                                                            reader["Description"].ToString(),
                                                            reader["Location"].ToString()
                                                            );
                        appointments.Add(myAppointment);
                    }
                }
            }

            return appointments;
        }

        public int AddSchedule(DateTime start, DateTime end, string summary, string description, string location)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(5);
                    db.AddParameters(0, "@Start", start);
                    db.AddParameters(1, "@End", end);
                    db.AddParameters(2, "@Summary", summary);
                    db.AddParameters(3, "@Description", description);
                    db.AddParameters(4, "@Location", location);
                    return db.ExecuteNonQuery(CommandType.StoredProcedure, "spAddSchedules");
                }
            }
            catch { return 0; }
        }

        public int UpdateSchedule(int id, DateTime start, DateTime end, string summary, string description, string location)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(6);
                    db.AddParameters(0, "@Id", id);
                    db.AddParameters(1, "@Start", start);
                    db.AddParameters(2, "@End", end);
                    db.AddParameters(3, "@Summary", summary);
                    db.AddParameters(4, "@Description", description);
                    db.AddParameters(5, "@Location", location);
                    return db.ExecuteNonQuery(CommandType.StoredProcedure, "spUpdateSchedules");
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
                    db.AddParameters(0, "@Id", id);
                    return db.ExecuteNonQuery(CommandType.StoredProcedure, "spDeleteSchedules");
                }
            }
            catch { return 0; }
        }
    }
}
