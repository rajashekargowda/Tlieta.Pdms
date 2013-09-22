using System;
using System.Configuration;
using System.Data;
using Tlieta.DataAccess;

namespace Tlieta.Pdms.DataAccess
{
    public class ContactData
    {
        private DataSet ds = null;

        public DataTable GetContacts()
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetContacts");

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

        public int AddContact(string name, string address, string mobile, string email, string company, string designation)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(6);
                    db.AddParameters(0, "@ContactName", name);
                    db.AddParameters(1, "@Address", address);
                    db.AddParameters(2, "@Mobile", mobile);
                    db.AddParameters(3, "@Email", email);
                    db.AddParameters(4, "@Company", company);
                    db.AddParameters(5, "@Designation", designation);
                    return db.ExecuteNonQuery(CommandType.StoredProcedure, "spAddContacts");
                }
            }
            catch { return 0; }
        }

        public int UpdateContact(int id, string name, string address, string mobile, string email, string company, string designation)
        {
            try
            {
                using (DBManager db = new DBManager())
                {
                    db.Open();
                    db.CreateParameters(7);
                    db.AddParameters(0, "@ContactId", id);
                    db.AddParameters(1, "@ContactName", name);
                    db.AddParameters(2, "@Address", address);
                    db.AddParameters(3, "@Mobile", mobile);
                    db.AddParameters(4, "@Email", email);
                    db.AddParameters(5, "@Company", company);
                    db.AddParameters(6, "@Designation", designation);
                    return db.ExecuteNonQuery(CommandType.StoredProcedure, "spUpdateContacts");
                }
            }
            catch { return 0; }
        }

    }
}
