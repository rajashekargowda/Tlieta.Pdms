using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tlieta.Pdms.DataAccess;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class NewVisitView : UserControl
    {
        public NewVisitView(int patientid)
        {
            InitializeComponent();

            PopulateData.PopulateComplaintTemplate(ddlComplaintTemplate);
            PopulateData.PopulateExaminationTemplate(ddlExaminationTemplate);
        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            string template = "";
            if (ddlComplaintTemplate.SelectedValue.ToString() == "0")
            {
                template = txtComplaintTemplate.Text.Trim();
                if (template == "")
                {
                    MessageBox.Show("Enter new template");
                }
                else
                {
                    new TemplateData().AddComplaintTemplate(new ComplaintTemplate()
                    {
                        ComplaintTemplateId = 0,
                        ComplaintTemplateText = template,
                        CreatedOn = DateTime.Now
                    });
                    PopulateData.PopulateComplaintTemplate(ddlComplaintTemplate);
                    txtComplaintTemplate.Text = "";
                }
            }
            else
            {
                template = ddlComplaintTemplate.SelectedItem.Text;
            }
            txtComplaint.Text = txtComplaint.Text + " " + template;
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            string template = "";
            if (ddlExaminationTemplate.SelectedValue.ToString() == "0")
            {
                template = txtExaminationTemplate.Text.Trim();
                if (template == "")
                {
                    MessageBox.Show("Enter new template");
                }
                else
                {
                    new TemplateData().AddExaminationTemplate(new ExaminationTemplate()
                    {
                        ExaminationTemplateId = 0,
                        ExaminationTemplateText = template,
                        CreatedOn = DateTime.Now
                    });
                    PopulateData.PopulateExaminationTemplate(ddlExaminationTemplate);
                    txtExaminationTemplate.Text = "";
                }
            }
            else
            {
                template = ddlExaminationTemplate.SelectedItem.Text;
            }
            txtExamination.Text = txtExamination.Text + " " + template;
        }
    }
}
