using System;
using System.Collections.Generic;
using System.Linq;
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.DataAccess
{
    public class TemplateData:BaseData
    {
        public List<ComplaintTemplate> GetComplaintTemplate()
        {
            List<ComplaintTemplate> complaint = new List<ComplaintTemplate>();
            try
            {
                complaint = (from c in entities.ComplaintTemplates select c).ToList();
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
            return complaint;
        }

        public ComplaintTemplate GetComplaintTemplateById(int id)
        {
            try
            {
                ComplaintTemplate template = entities.ComplaintTemplates.Find(id);
                return template;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return null;
            }
        }

        public bool AddComplaintTemplate(ComplaintTemplate model)
        {
            try
            {
                entities.ComplaintTemplates.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }

        public List<ExaminationTemplate> GetExaminationTemplate()
        {
            List<ExaminationTemplate> examination = new List<ExaminationTemplate>();
            try
            {
                examination = (from c in entities.ExaminationTemplates select c).ToList();
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
            return examination;
        }

        public ExaminationTemplate GetExaminationTemplateById(int id)
        {
            try
            {
                ExaminationTemplate template = entities.ExaminationTemplates.Find(id);
                return template;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return null;
            }
        }

        public bool AddExaminationTemplate(ExaminationTemplate model)
        {
            try
            {
                entities.ExaminationTemplates.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }
    }
}
