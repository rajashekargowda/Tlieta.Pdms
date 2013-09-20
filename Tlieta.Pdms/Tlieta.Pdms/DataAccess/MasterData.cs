using System.Data;
using Tlieta.DataAccess;
namespace Tlieta.Pdms.DataAccess
{
    public class MasterData
    {
        DataSet _ds = null;

        public DataTable GetHospitals()
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetHospitals");
                if (_ds != null && _ds.Tables[0].Rows.Count > 0)
                {
                    return _ds.Tables[0];
                }
                else { return null; }
            }
        }

        public bool AddHospital(string hospitalname, string location)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(2);
                    db.AddParameters(0, "@Name", hospitalname);
                    db.AddParameters(1, "@Location", location);
                    db.ExecuteNonQuery(CommandType.StoredProcedure, "spAddHospital");

                    return true;
                }
            }
            catch { return false; }
        }

        public DataTable GetOperations()
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetOperations");
                if (_ds != null && _ds.Tables[0].Rows.Count > 0)
                {
                    return _ds.Tables[0];
                }
                else { return null; }
            }
        }

        public bool AddOperation(string operationname)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(1);
                    db.AddParameters(0, "@OperationName", operationname);
                    db.ExecuteNonQuery(CommandType.StoredProcedure, "spAddOperation");

                    return true;
                }
            }
            catch { return false; }
        }

        public DataTable GetImplants()
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetImplants");
                if (_ds != null && _ds.Tables[0].Rows.Count > 0)
                {
                    return _ds.Tables[0];
                }
                else { return null; }
            }
        }

        public bool AddImplant(string implantname)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(1);
                    db.AddParameters(0, "@ImplantName", implantname);
                    db.ExecuteNonQuery(CommandType.StoredProcedure, "spAddImplant");

                    return true;
                }
            }
            catch { return false; }
        }

        public DataTable GetGraftSizes()
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetGraftSizes");
                if (_ds != null && _ds.Tables[0].Rows.Count > 0)
                {
                    return _ds.Tables[0];
                }
                else { return null; }
            }
        }

        public bool AddGraftSize(decimal graftsizevalue)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(1);
                    db.AddParameters(0, "@GraftSizeValue", graftsizevalue);
                    db.ExecuteNonQuery(CommandType.StoredProcedure, "spAddGraftSize");

                    return true;
                }
            }
            catch { return false; }
        }

        public DataTable GetACLSubTypes()
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                _ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetACLSubTypes");
                if (_ds != null && _ds.Tables[0].Rows.Count > 0)
                {
                    return _ds.Tables[0];
                }
                else { return null; }
            }
        }

        public bool AddACLSubType(string aclsubtypename)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(1);
                    db.AddParameters(0, "@ACLSubTypeName", aclsubtypename);
                    db.ExecuteNonQuery(CommandType.StoredProcedure, "spAddACLSubType");

                    return true;
                }
            }
            catch { return false; }
        }
    }
}
