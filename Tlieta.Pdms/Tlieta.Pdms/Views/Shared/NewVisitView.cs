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

        List<PatientLabData> labdatalist;
        List<PatientImagingData> imagingdatalist;

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
            SetGridPreferences(ImagingGrid);
            datetimeImagingTest.Value = DateTime.Now;

            //Diagnosis
            datetimeFollowUp.Value = DateTime.Now.Add(new TimeSpan(7, 0, 0, 0));

            if (labdatalist == null) { labdatalist = new List<PatientLabData>(); }
            if (imagingdatalist == null) { imagingdatalist = new List<PatientImagingData>(); }
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
            int labtest = Convert.ToInt32(ddllabTest.SelectedValue);
            string result = txtLabResults.Text.Trim();

            if (labtest == 0)
            {
                MessageBox.Show("Select a lab test");
                return;
            } else if (result == "")
            {
                MessageBox.Show("Enter results");
                return;
            }

            PatientLabData data = new PatientLabData()
            {
                LabTestId = labtest,
                LabTestName = ddllabTest.SelectedItem.Text,
                Results = result,
                TestDate = datetimeLabTest.Value,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
            };

            labdatalist.Add(data);

            //LabDataGrid.DataSource = null;
            LabDataGrid.ClearSelection();
            LabDataGrid.DataSource = (from labdata in labdatalist
                                      select new { labdata.LabTestName, labdata.Results, labdata.TestDate });
            LabDataGrid.Refresh();
        }

        private void btnAddImaging_Click(object sender, EventArgs e)
        {
            int imaging = Convert.ToInt32(ddlImagingTest.SelectedValue);
            string result = txtImagingFindings.Text.Trim();

            if (imaging == 0)
            {
                MessageBox.Show("Select an imaging");
                return;
            }
            else if (result == "")
            {
                MessageBox.Show("Enter findings");
                return;
            }

            PatientImagingData data = new PatientImagingData()
            {
                ImagingId = imaging,
                ImagingName = ddlImagingTest.SelectedItem.Text,
                Findings = result,
                TestDate = datetimeLabTest.Value,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
            };

            imagingdatalist.Add(data);

            //ImagingGrid.DataSource = null;
            ImagingGrid.ClearSelection();
            ImagingGrid.DataSource = (from imagingdata in imagingdatalist
                                      select new { imagingdata.ImagingName, imagingdata.Findings, imagingdata.TestDate });
            ImagingGrid.Refresh();
        }

        private void btnAddNewVisit_Click(object sender, EventArgs e)
        {

        }

        private void SetGridPreferences(RadGridView grid)
        {
            grid.ShowGroupPanel = false;
            grid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }
    }
}
