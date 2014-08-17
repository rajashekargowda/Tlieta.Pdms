using System;
using System.Collections.Generic;
using System.Linq;


namespace Tlieta.Pdms.DB
{
    public class VisitData : BaseData
    {
        public List<PatientVisit> GetVisits(int patientid)
        {
            List<PatientVisit> visits = new List<PatientVisit>();
            try
            {
                visits = (from v in entities.PatientVisits
                          where v.PatientId == patientid
                          select v).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
            return visits;
        }

        public bool AddVisit(PatientVisit model, List<PatientLabData> labmodel, List<PatientImagingData> imagingmodel, List<Prescription> presriptionmodel)
        {
            int _visitid = 0;
            try
            {
                entities.PatientVisits.Add(model);
                entities.SaveChanges();
                _visitid = model.VisitId;
            }
            catch (Exception x)
            {
                throw x;
            }

            if (_visitid != 0)
            {
                //add Lab Data
                foreach (PatientLabData data in labmodel)
                {
                    data.UniqueId = 0;
                    data.VisitId = _visitid;
                    entities.PatientLabDatas.Add(data);
                }
                //add Imaging data
                foreach (PatientImagingData data in imagingmodel)
                {
                    data.UniqueId = 0;
                    data.VisitId = _visitid;
                    entities.PatientImagingDatas.Add(data);
                }
                //add Prescription data
                foreach (Prescription data in presriptionmodel)
                {
                    data.UniqueId = 0;
                    data.VisitId = _visitid;
                    entities.Prescriptions.Add(data);
                }

                //save db
                entities.SaveChanges();
            }
            else
            {
                throw new Exception("Error adding vist");
            }

            return true;
        }

        public PatientVisit GetVisitById(int visitid)
        {
            try
            {
                PatientVisit visit = entities.PatientVisits.Find(visitid);
                return visit;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public List<PatientLabData> GetLabData(int visitid)
        {
            List<PatientLabData> data = new List<PatientLabData>();
            try
            {
                data = (from v in entities.PatientLabDatas
                          where v.VisitId == visitid
                          select v).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
            return data;
        }

        public List<PatientImagingData> GetImagingData(int visitid)
        {
            List<PatientImagingData> data = new List<PatientImagingData>();
            try
            {
                data = (from v in entities.PatientImagingDatas
                        where v.VisitId == visitid
                        select v).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
            return data;
        }

        public List<Prescription> GetPrescriptionData(int visitid)
        {
            List<Prescription> data = new List<Prescription>();
            try
            {
                data = (from v in entities.Prescriptions
                        where v.VisitId == visitid
                        select v).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
            return data;
        }
    }
}
