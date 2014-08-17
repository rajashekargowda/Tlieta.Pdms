using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tlieta.Pdms.DB;

namespace Tlieta.Pdms.DB
{
    public class DrugData : BaseData
    {
        public List<Drug> GetDrugs()
        {
            try
            {
                List<Drug> drugs = new List<Drug>();
                try
                {
                    drugs = (from c in entities.Drugs select c).OrderBy(x => x.BrandName).ToList();
                }
                catch { }
                return drugs;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public Drug GetDrugById(int brandid)
        {
            try
            {
                Drug drug = entities.Drugs.Find(brandid);
                return drug;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool Add(Drug model)
        {
            try
            {
                entities.Drugs.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool Update(Drug model)
        {
            try
            {
                Drug drug = entities.Drugs.Where(x => x.BrandId == model.BrandId).SingleOrDefault();
                if (drug != null)
                {
                    entities.Entry(drug).CurrentValues.SetValues(model);
                    entities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                var result = entities.Drugs.Where(x => x.BrandId == Id);
                if (result.Count() > 0)
                {
                    Drug drug = result.First();
                    entities.Drugs.Remove(drug);
                    entities.SaveChanges();
                }
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
    }
}