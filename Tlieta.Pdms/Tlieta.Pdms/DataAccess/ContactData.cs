using System;
using System.Collections.Generic;
using System.Linq;

namespace Tlieta.Pdms.DataAccess
{
    public class ContactData
    {
        PDMSDataEntities entities = new PDMSDataEntities();

        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                contacts = (from c in entities.Contacts select c).ToList();
            }
            catch { }
            return contacts;

            //try
            //{
            //    using (DBManager db = new DBManager())
            //    {
            //        db.Open();
            //        ds = db.ExecuteDataSet(CommandType.StoredProcedure, "spGetContacts");

            //        if (ds != null && ds.Tables[0].Rows.Count > 0)
            //        {
            //            return ds.Tables[0];
            //        }
            //        else
            //        {
            //            return null;
            //        }
            //    }
            //}
            //catch { return null; }
        }

        public bool AddContact(Contact model)
        {
            try
            {
                entities.Contacts.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch { return false; }

            //try
            //{
            //    using (DBManager db = new DBManager())
            //    {
            //        db.Open();
            //        db.CreateParameters(6);
            //        db.AddParameters(0, "@ContactName", name);
            //        db.AddParameters(1, "@Address", address);
            //        db.AddParameters(2, "@Mobile", mobile);
            //        db.AddParameters(3, "@Email", email);
            //        db.AddParameters(4, "@Company", company);
            //        db.AddParameters(5, "@Designation", designation);
            //        return db.ExecuteNonQuery(CommandType.StoredProcedure, "spAddContacts");
            //    }
            //}
            //catch { return 0; }
        }

        public bool UpdateContact(Contact model)
        {
            try
            {
                Contact contact = entities.Contacts.Where(x => x.ContactId == model.ContactId).SingleOrDefault();
                if (contact != null)
                {
                    entities.Entry(contact).CurrentValues.SetValues(model);
                    entities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }


            //try
            //{
            //    using (DBManager db = new DBManager())
            //    {
            //        db.Open();
            //        db.CreateParameters(7);
            //        db.AddParameters(0, "@ContactId", id);
            //        db.AddParameters(1, "@ContactName", name);
            //        db.AddParameters(2, "@Address", address);
            //        db.AddParameters(3, "@Mobile", mobile);
            //        db.AddParameters(4, "@Email", email);
            //        db.AddParameters(5, "@Company", company);
            //        db.AddParameters(6, "@Designation", designation);
            //        return db.ExecuteNonQuery(CommandType.StoredProcedure, "spUpdateContacts");
            //    }
            //}
            //catch { return 0; }
        }

    }
}
