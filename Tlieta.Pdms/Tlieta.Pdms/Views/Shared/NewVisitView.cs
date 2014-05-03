using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tlieta.Pdms.DB;
using Telerik.WinControls.UI;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class NewVisitView : UserControl
    {
        int visitid = 0;

        public NewVisitView(int patientid)
        {
            InitializeComponent();

            InitializeData();
        }

        private void InitializeData()
        {
            //Clinical data
            PopulateData.PopulateComplaintTemplate(ddlComplaintTemplate);
            PopulateData.PopulateExaminationTemplate(ddlExaminationTemplate);

            //Lab Test
            PopulateData.PopulateLabInvestigation(ddllabTest);
            SetGridPreferences(LabDataGrid);
            datetimeLabTest.Value = DateTime.Now;

            //Imaging
            PopulateData.PopulateImaging(ddlImagingTest);
            datetimeImagingTest.Value = DateTime.Now;

            //Diagnosis
            datetimeFollowUp.Value = DateTime.Now.Add(new TimeSpan(7, 0, 0, 0));
        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            string template = "";
            int id = Convert.ToInt32(ddlComplaintTemplate.SelectedValue.ToString());
            if (id == 0)
            {
                MessageBox.Show("Select template");
            }
            else
            {
                template = new TemplateData().GetComplaintTemplateById(id).ComplaintTemplateText;
            }
            txtComplaint.Text = txtComplaint.Text + " " + template;
        }

        private void btnAddComplaintTemplate_Click(object sender, EventArgs e)
        {
            string templatename = txtComplaintTemplate.Text.Trim();
            string templatetext = txtComplaintText.Text.Trim();
            if (templatename == "" || templatetext == "")
            {
                MessageBox.Show("Enter template name and data");
            }
            else
            {
                new TemplateData().AddComplaintTemplate(new ComplaintTemplate()
                {
                    ComplaintTemplateId = 0,
                    ComplaintTemplateName = templatename,
                    ComplaintTemplateText = templatetext,
                    CreatedOn = DateTime.Now
                });
                PopulateData.PopulateComplaintTemplate(ddlComplaintTemplate);
                txtComplaintTemplate.Text = "";
                txtComplaintText.Text = "";
            }
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            string template = "";
            int id = Convert.ToInt32(ddlExaminationTemplate.SelectedValue.ToString());
            if (id == 0)
            {
                MessageBox.Show("Select template");
            }
            else
            {
                template = new TemplateData().GetExaminationTemplateById(id).ExaminationTemplateText;
            }
            txtExamination.Text = txtExamination.Text + " " + template;
        }

        private void btnExaminationTemplate_Click(object sender, EventArgs e)
        {
            string templatename = txtExaminationTemplate.Text.Trim();
            string templatetext = txtExaminationText.Text.Trim();
            if (templatename == "" || templatetext == "")
            {
                MessageBox.Show("Enter template name and data");
            }
            else
            {
                new TemplateData().AddExaminationTemplate(new ExaminationTemplate()
                {
                    ExaminationTemplateId = 0,
                    ExaminationTemplateName = templatename,
                    ExaminationTemplateText = templatetext,
                    CreatedOn = DateTime.Now
                });
                PopulateData.PopulateExaminationTemplate(ddlExaminationTemplate);
                txtExaminationTemplate.Text = "";
                txtExaminationText.Text = "";
            }
        }

        private void btnSaveClinical_Click(object sender, EventArgs e)
        {
            string complaint = txtComplaint.Text.Trim();
            string examination = txtExamination.Text.Trim();
            if (complaint == "" || examination == "")
            {
                MessageBox.Show("Enter new template");
            }
            else
            {
            }
        }

        private void chkFollowUp_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (chkFollowUp.Checked)
            {
                datetimeFollowUp.Visible = true;
            }
            else
            {
                datetimeFollowUp.Visible = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnAddLabTest_Click(object sender, EventArgs e)
        {

        }

        private void SetGridPreferences(RadGridView grid) 
        {
            grid.ShowGroupPanel = false;
            grid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill; 
        }
    }
}
