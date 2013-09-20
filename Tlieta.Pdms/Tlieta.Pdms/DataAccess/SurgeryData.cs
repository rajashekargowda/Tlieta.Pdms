using System;
using System.Data;
using Tlieta.DataAccess;

namespace Tlieta.Pdms.DataAccess
{
    public class SurgeryData
    {
        DataSet _ds = null;

        public DataSet GetSurgeriesById(int surgeryid)
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                db.CreateParameters(1);
                db.AddParameters(0, "@SurgeryId", surgeryid);
                _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetSurgeriesById");
                if (_ds != null && _ds.Tables[0].Rows.Count > 0)
                {
                    return _ds;
                }
                else { return null; }
            }
        }

        public DataTable GetSurgeriesForPatient(int patientid)
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                db.CreateParameters(1);
                db.AddParameters(0, "@PatientId", patientid);
                _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetSurgeriesForPatient");
                if (_ds != null )
                {
                    return _ds.Tables[0];
                }
                else { return null; }
            }
        }

        public int AddSurgery(int patientid, DateTime surgerydate, int operationid, int aclsubsystem, int graftsize,
                                    int hospitalid, int implantid, string ipnumber, string notes)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(9);
                    db.AddParameters(0, "@PatientId", patientid);
                    db.AddParameters(1, "@SurgeryDate", surgerydate);
                    db.AddParameters(2, "@OperationId", operationid);
                    db.AddParameters(3, "@ACLSubTypeId", aclsubsystem);
                    db.AddParameters(4, "@GraftSizeId", graftsize);
                    db.AddParameters(5, "@HospitalId", hospitalid);
                    db.AddParameters(6, "@ImplantId", implantid);
                    db.AddParameters(7, "@IPNumber", ipnumber);
                    db.AddParameters(8, "@Notes", notes);
                    _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spAddSurgery");
                    if (_ds != null && _ds.Tables[0].Rows.Count > 0)
                    {
                        return Convert.ToInt32(_ds.Tables[0].Rows[0][0].ToString());
                    }
                    else { return 0; }
                }
            }
            catch { return 0; }
        }

        public bool AddSurgeryImplants(int surgeryid, int implantid)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(2);
                    db.AddParameters(0, "@SurgeryId", surgeryid);
                    db.AddParameters(1, "@ImplantId", implantid);
                    db.ExecuteNonQuery(CommandType.StoredProcedure, "spAddSurgeryImplants");

                    return true;
                }
            }
            catch { return false; }
        }

        public bool UpdateSurgery(int surgeryid, int patientid, DateTime surgerydate, int operationid, int aclsubsystem, int graftsize,
                                    int hospitalid, int implantid, string ipnumber, string notes)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(10);
                    db.AddParameters(0, "@SurgeryId", surgeryid);
                    db.AddParameters(1, "@PatientId", patientid);
                    db.AddParameters(2, "@SurgeryDate", surgerydate);
                    db.AddParameters(3, "@OperationId", operationid);
                    db.AddParameters(4, "@ACLSubTypeId", aclsubsystem);
                    db.AddParameters(5, "@GraftSizeId", graftsize);
                    db.AddParameters(6, "@HospitalId", hospitalid);
                    db.AddParameters(7, "@ImplantId", implantid);
                    db.AddParameters(8, "@IPNumber", ipnumber);
                    db.AddParameters(9, "@Notes", notes);
                    db.ExecuteNonQuery(CommandType.StoredProcedure, "spUpdateSurgery");

                    return true;
                }
            }
            catch { return false; }
        }
    }
}
