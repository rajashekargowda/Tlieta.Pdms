using System.Collections.Generic;
using System.Linq;

namespace Tlieta.Pdms.DataAccess
{
    public class TemplateData
    {
        PDMSDataEntities entities = new PDMSDataEntities();

        public List<ComplaintTemplate> GetComplaintTemplate()
        {
            List<ComplaintTemplate> complaint = new List<ComplaintTemplate>();
            try
            {
                complaint = (from c in entities.ComplaintTemplates select c).ToList();
            }
            catch { }
            return complaint;
        }

        public bool AddComplaintTemplate(ComplaintTemplate model)
        {
            try
            {
                entities.ComplaintTemplates.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public List<ExaminationTemplate> GetExaminationTemplate()
        {
            List<ExaminationTemplate> examination = new List<ExaminationTemplate>();
            try
            {
                examination = (from c in entities.ExaminationTemplates select c).ToList();
            }
            catch { }
            return examination;
        }

        public bool AddExaminationTemplate(ExaminationTemplate model)
        {
            try
            {
                entities.ExaminationTemplates.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
