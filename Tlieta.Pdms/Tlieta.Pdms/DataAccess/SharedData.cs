using System.Data;
using Tlieta.DataAccess;
using Tlieta.Utility;

namespace Tlieta.Pdms.DataAccess
{
    public class SharedData
    {
        private DataSet ds = null;
        public SharedData()
        {
        }

        public string GetSerialKey()
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetSerialKey");
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        return ds.Tables[0].Rows[0][0].ToString();
                    }
                    else
                    {
                        string serialkey = FingerPrint.Value();
                        db.CreateParameters(1);
                        db.AddParameters(0, "@SerialKey", serialkey);
                        db.ExecuteNonQuery(CommandType.StoredProcedure, "spSetSerialKey");
                        return serialkey;
                    }
                }
            }
            catch { return ""; }
        }
    }
} 
