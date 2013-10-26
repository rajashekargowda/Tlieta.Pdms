using System.Data;
using Tlieta.DataAccess;
using Tlieta.Utility;
using System.Linq;
using System.Collections.Generic;

namespace Tlieta.Pdms.DataAccess
{
    public class SharedData
    {
        private DataSet ds = null;
        PDMSDataEntities entities = new PDMSDataEntities();

        public SharedData()
        {
        }

        public string GetSerialKey()
        {
            try
            {
                string serialkey = "";
                List<Product> products = (from p in entities.Products select p).ToList();
                if (products.Count > 0)
                {
                    serialkey = products.First().ProductKey;
                }
                else
                {
                    serialkey = FingerPrint.Value();
                    entities.Products.Add(new Product()
                    {
                        ProductKey = serialkey
                    });
                    entities.SaveChanges();
                }
                return serialkey;

                //using (DBManager db = new DBManager())
                //{
                //    db.Open();
                //    ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetSerialKey");
                //    if (ds != null && ds.Tables[0].Rows.Count > 0)
                //    {
                //        return ds.Tables[0].Rows[0][0].ToString();
                //    }
                //    else
                //    {
                //        string serialkey = FingerPrint.Value();
                //        db.CreateParameters(1);
                //        db.AddParameters(0, "@SerialKey", serialkey);
                //        db.ExecuteNonQuery(CommandType.StoredProcedure, "spSetSerialKey");
                //        return serialkey;
                //    }
                //}
            }
            catch { return ""; }
        }
    }
} 
