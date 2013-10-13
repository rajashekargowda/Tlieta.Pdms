using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Tlieta.DataAccess;

namespace Tlieta.Pdms.DataAccess
{
    public class MasterData
    {
        DataSet _ds = null;
        PDMSDataEntities entities = new PDMSDataEntities();

        public List<Hospital> GetHospitals()
        {
            try
            {
                return (from h in entities.Hospitals select h).ToList();
            }
            catch { return null; }
        }

        public bool AddHospital(Hospital hospital)
        {
            try
            {
                entities.Hospitals.Add(hospital);
                entities.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public List<Operation> GetOperations()
        {
            try
            {
                return (from o in entities.Operations select o).ToList();
            }
            catch { return null; }
        }

        public bool AddOperation(Operation operation)
        {
            try
            {
                entities.Operations.Add(operation);
                entities.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
