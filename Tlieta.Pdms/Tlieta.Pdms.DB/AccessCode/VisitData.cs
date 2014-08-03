using System;
using System.Collections.Generic;
using System.Linq;


namespace Tlieta.Pdms.DB.AccessCode
{
    public class VisitData : BaseData
    {
        public List<PatientVisit> GetVisits(int patientid)
        {
            List<PatientVisit> visits = new List<PatientVisit>();
            try
            {
                visits = (from v in entities.PatientVisits
                          where v.PatientId = patientid
                          select v).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
            return visits;
        }

        public int AddVisit(PatientVisit model)
        {
            try
            {
                entities.PatientVisits.Add(model);
                entities.SaveChanges();
                return model.VisitId;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
    }
}
