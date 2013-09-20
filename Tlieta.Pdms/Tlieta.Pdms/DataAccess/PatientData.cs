using System;
using System.Configuration;
using System.Data;
using Tlieta.DataAccess;
namespace Tlieta.Pdms.DataAccess
{
    public class PatientData
    {
        private DataSet ds = null;
        public PatientData()
        {
        }

        public int InsertPatient(string prefix, string firstname, string middlename, string lastname, string gender, string address, int age,
                                        string mobile, string phone, string email, int hospitalid)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(11);
                    db.AddParameters(0, "@Prefix", prefix);
                    db.AddParameters(1, "@FirstName", firstname);
                    db.AddParameters(2, "@MiddleName", middlename);
                    db.AddParameters(3, "@LastName", lastname);
                    db.AddParameters(4, "@Age", age);
                    db.AddParameters(5, "@Gender", gender);
                    db.AddParameters(6, "@Address", address);
                    db.AddParameters(7, "@Mobile", mobile);
                    db.AddParameters(8, "@HomePhone", phone);
                    db.AddParameters(9, "@Email", email);
                    db.AddParameters(10, "@HospitalId", hospitalid);
                    ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spAddPatient");
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        return Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    }
                    else { return 0; }
                }
            }
            catch { return 0; }
        }

        public bool UpdatePatient(int patientid, string prefix, string firstname, string middlename, string lastname, string gender, string address, int age,
                                        string mobile, string phone, string email, int hospitalid)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(12);
                    db.AddParameters(0, "@PatientId", patientid);
                    db.AddParameters(1, "@Prefix", prefix);
                    db.AddParameters(2, "@FirstName", firstname);
                    db.AddParameters(3, "@MiddleName", middlename);
                    db.AddParameters(4, "@LastName", lastname);
                    db.AddParameters(5, "@Age", age);
                    db.AddParameters(6, "@Gender", gender);
                    db.AddParameters(7, "@Address", address);
                    db.AddParameters(8, "@Mobile", mobile);
                    db.AddParameters(9, "@HomePhone", phone);
                    db.AddParameters(10, "@Email", email);
                    db.AddParameters(11, "@HospitalId", hospitalid);
                    db.ExecuteNonQuery(CommandType.StoredProcedure, "spUpdatePatient");
                }
            }
            catch { return false; }

            return true;
        }

        public DataTable GetSearchResult(string name, int hospitalId, int operationId)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(3);
                    db.AddParameters(0, "@PatientName", name);
                    db.AddParameters(1, "@HospitalId", hospitalId);
                    db.AddParameters(2, "@OperationId", operationId);
                    ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spSearchPatient");

                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        return ds.Tables[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch { return null; }
        }

        public DataTable GetPatientById(int patientId)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(1);
                    db.AddParameters(0, "@PatientId", patientId);
                    ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetPatient");

                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        return ds.Tables[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch { return null; }
        }

        public bool AddNotes(int patientid, string notes, string notename)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(3);
                    db.AddParameters(0, "@PatientId", patientid);
                    db.AddParameters(1, "@NoteContent", notes);
                    db.AddParameters(2, "@NoteName", notename);
                    db.ExecuteNonQuery(CommandType.StoredProcedure, "spAddNotes");

                    return true;
                }
            }
            catch { return false; }
        }

        public bool UpdateNotes(int noteid, string notes, string notename)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(3);
                    db.AddParameters(0, "@NoteId", noteid);
                    db.AddParameters(1, "@NoteContent", notes);
                    db.AddParameters(2, "@NoteName", notename);
                    db.ExecuteNonQuery(CommandType.StoredProcedure, "spUpdateNotes");

                    return true;
                }
            }
            catch { return false; }
        }

        public DataTable GetNotesForPatient(int patientid)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(1);
                    db.AddParameters(0, "@PatientId", patientid);
                    ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetNotesForPatient");

                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        return ds.Tables[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch { return null; }
        }
    }
}
