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
using Tlieta.Pdms.DB;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class NewVisitView : UserControl
    {
        int _uniqueid = 1;
        int _patiendid;
        List<PatientLabData> labdatalist;
        List<PatientImagingData> imagingdatalist;
        List<Prescription> prescriptionlist;

        public NewVisitView(int patientid)
        {
            _patiendid = patientid;

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
            PopulateData.PopulateDrug(ddlDrug);
            PopulateData.PopulateDosage(ddlDosage);
            SetGridPreferences(PrescriptionGrid);
            datetimeFollowUp.Value = DateTime.Now.Add(new TimeSpan(7, 0, 0, 0));

            if (labdatalist == null) { labdatalist = new List<PatientLabData>(); }
            if (imagingdatalist == null) { imagingdatalist = new List<PatientImagingData>(); }
            if (prescriptionlist == null) { prescriptionlist = new List<Prescription>(); }
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
            ddlComplaintTemplate.SelectedValue = 0;
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
            ddlExaminationTemplate.SelectedValue = 0;
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
            RefreshVisit();
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
                UniqueId = _uniqueid,
                LabTestId = labtest,
                LabTestName = ddllabTest.SelectedItem.Text,
                Results = result,
                TestDate = datetimeLabTest.Value,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
            };

            labdatalist.Add(data);
            _uniqueid = _uniqueid + 1;

            BindLabData();

            txtLabResults.Text = "";
            ddllabTest.SelectedValue = 0;
            datetimeLabTest.Value = DateTime.Now;
        }

        private void BindLabData()
        {
            //LabDataGrid.ClearSelection();
            LabDataGrid.DataSource = (from labdata in labdatalist
                                      select new { labdata.UniqueId, labdata.LabTestName, labdata.Results, labdata.TestDate });
            LabDataGrid.Columns[0].IsVisible = false;
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
                UniqueId = _uniqueid,
                ImagingId = imaging,
                ImagingName = ddlImagingTest.SelectedItem.Text,
                Findings = result,
                TestDate = datetimeImagingTest.Value,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
            };

            imagingdatalist.Add(data);
            _uniqueid = _uniqueid + 1;

            BindImagingData();

            txtImagingFindings.Text = "";
            ddlImagingTest.SelectedValue = 0;
            datetimeImagingTest.Value = DateTime.Now;
        }

        private void BindImagingData()
        {
            //ImagingGrid.ClearSelection();
            ImagingGrid.DataSource = (from imagingdata in imagingdatalist
                                      select new { imagingdata.UniqueId, imagingdata.ImagingName, imagingdata.Findings, imagingdata.TestDate });
            ImagingGrid.Columns[0].IsVisible = false;
            ImagingGrid.Refresh();
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            int brand = Convert.ToInt32(ddlDrug.SelectedValue);
            int dosage = Convert.ToInt32(ddlDosage.SelectedValue);
            string duration = txtDuration.Text.Trim();
            string units = txtUnit.Text.Trim();

            if (brand == 0)
            {
                MessageBox.Show("Select drug");
                return;
            }
            else if (dosage == 0)
            {
                MessageBox.Show("Select dosage");
                return;
            }
            else if (duration == "")
            {
                MessageBox.Show("Enter duration");
                return;
            }
            else if (units == "")
            {
                MessageBox.Show("Enter units");
                return;
            }

            Prescription data = new Prescription()
            {
                UniqueId = _uniqueid,
                DrugId = brand,
                DrugName = ddlDrug.SelectedItem.Text,
                DosageFrequencyId = dosage,
                Dosage = ddlDosage.SelectedItem.Text,
                Duration = duration,
                Units = units,
                Instructions = txtInstructions.Text.Trim(),
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
            };

            prescriptionlist.Add(data);
            _uniqueid = _uniqueid + 1;

            BindPrescriptionData();

            txtInstructions.Text = "";
            txtCompany.Text = "";
            txtContents.Text = "";
            txtFormulation.Text = "";
            txtDuration.Text = "";
            txtUnit.Text = "";
            ddlDosage.SelectedValue = 0;
            ddlDrug.SelectedValue = 0;

        }

        private void BindPrescriptionData()
        {
            PrescriptionGrid.ClearSelection();
            PrescriptionGrid.DataSource = (from prescription in prescriptionlist
                                           select new { prescription.UniqueId, prescription.DrugName, prescription.Dosage, prescription.Duration, prescription.Units, prescription.Instructions });

            PrescriptionGrid.Columns[0].IsVisible = false;
            PrescriptionGrid.Refresh();
        }

        private void btnAddNewVisit_Click(object sender, EventArgs e)
        {
            int _visitid = 0;
            VisitData db = new VisitData();
            try
            {
                PatientVisit visit = new PatientVisit()
                {
                    PatientId = _patiendid,
                    ComplaintHistory = txtComplaint.Text.Trim(),
                    ExaminationNotes = txtExamination.Text.Trim(),
                    Diagnosis = txtDiagnosis.Text.Trim(),
                    OtherAdvise = txtOtherAdvise.Text.Trim(),
                    IsFolowUpRequired = chkFollowUp.Checked,
                    FollowUpDate = datetimeFollowUp.Value,
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now
                };

                bool result = db.AddVisit(visit, labdatalist, imagingdatalist, prescriptionlist);

                if (result)
                {
                    RefreshVisit();
                    MessageBox.Show("Visit added successfully. Please print results from [Previous Visits] section");
                }
                else
                {
                    MessageBox.Show("Error adding visit : Please contact support");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error adding visit. Please try again.");
                return;
            }
        }

        private void SetGridPreferences(RadGridView grid)
        {
            grid.ShowGroupPanel = false;
            grid.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private void ddlDrug_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ddlDrug.SelectedItem != null && ddlDrug.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                int brandid = 0;
                try
                {
                    brandid = (int)ddlDrug.SelectedItem.Value;
                }
                catch { brandid = ((Drug)ddlDrug.SelectedItem.Value).BrandId; }

                if (brandid != 0)
                {
                    try
                    {
                        Drug _drug = new DrugData().GetDrugById(brandid);
                        txtCompany.Text = _drug.Company;
                        txtContents.Text = _drug.DrugContent;
                        txtFormulation.Text = _drug.Formulation;
                        txtInstructions.Text = txtInstructions.Text + " " + _drug.Instructions;
                    }
                    catch { }

                }
                else
                {
                    txtCompany.Text = "";
                    txtContents.Text = "";
                    txtFormulation.Text = "";
                }
            }
        }

        private void RefreshVisit()
        {
            txtComplaint.Text = "";
            txtExamination.Text = "";
            txtDiagnosis.Text = "";
            txtOtherAdvise.Text = "";
            chkFollowUp.Checked = false;
            datetimeFollowUp.Value = DateTime.Now;

            labdatalist.Clear();
            LabDataGrid.DataSource = null;
            LabDataGrid.Refresh();

            imagingdatalist.Clear();
            ImagingGrid.DataSource = null;
            ImagingGrid.Refresh();

            prescriptionlist.Clear();
            PrescriptionGrid.DataSource = null;
            PrescriptionGrid.Refresh();
        }

        private void btnDeleteLab_Click(object sender, EventArgs e)
        {
            if (this.LabDataGrid.SelectedRows.Count > 0)
            {
                int uniqueid = Convert.ToInt32(this.LabDataGrid.CurrentRow.Cells[0].Value);
                labdatalist = labdatalist.Where(l => l.UniqueId != uniqueid).ToList();
                BindLabData();
            }
        }

        private void btnDeleteImaging_Click(object sender, EventArgs e)
        {
            if (this.ImagingGrid.SelectedRows.Count > 0)
            {
                int uniqueid = Convert.ToInt32(this.ImagingGrid.CurrentRow.Cells[0].Value);
                imagingdatalist = imagingdatalist.Where(l => l.UniqueId != uniqueid).ToList();
                BindImagingData();
            }
        }

        private void btnDeletePrescription_Click(object sender, EventArgs e)
        {
            if (this.PrescriptionGrid.SelectedRows.Count > 0)
            {
                int uniqueid = Convert.ToInt32(this.PrescriptionGrid.CurrentRow.Cells[0].Value);
                prescriptionlist = prescriptionlist.Where(l => l.UniqueId != uniqueid).ToList();
                BindPrescriptionData();
            }
        }
    }
}
