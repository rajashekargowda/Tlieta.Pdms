using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.IO;
using Telerik.WinControls.RichTextBox.FormatProviders;
using Telerik.WinControls.RichTextBox.FileFormats.OpenXml.Docx;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using Tlieta.Pdms.Properties;
using Tlieta.Pdms.DB;
using Tlieta.Pdms.Code;
using System.Collections.Generic;
using Telerik.WinControls.RichTextBox.FileFormats.Html;
using Telerik.WinControls.RichTextBox.Model;
using System.Text;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class VisitHistoryView : UserControl
    {
        private int _patientid = 0;
        public VisitHistoryView(int patientid)
        {
            InitializeComponent();
            _patientid = patientid;
        }

        private void VisitHistoryView_Load(object sender, EventArgs e)
        {
            PopulateVisitList();
            //PrepareDocument();
        }

        private void PopulateVisitList()
        {
            listVisits.Items.Clear();
            List<PatientVisit> visits = new VisitData().GetVisits(_patientid);

            if (visits != null)
            {
                foreach (PatientVisit s in visits)
                {
                    RadListDataItem item = new RadListDataItem();
                    item.Value = s.VisitId;
                    item.Text = s.CreatedOn.ToShortDateString();
                    listVisits.Items.Add(item);
                }
            }
        }

        private void PrepareDocument()
        {
            Patient patient = new PatientData().GetPatientById(_patientid);

            StringBuilder content = new StringBuilder();
            content.Append("<p>");
            content.Append("<b>Patient Name : </b>" + patient.FirstName.ToUpper() + " " + patient.LastName.ToUpper());
            content.Append("<br/>");
            content.Append("<b>Patient Id : </b>" + _patientid.ToString());
            content.Append("<br/>");
            content.Append("<b>Age : </b>" + Utility.GetAgeFromDob(patient.DOB).ToString());
            content.Append("<br/>");
            content.Append("<b>Address : </b>" + patient.Address.ToUpper());
            content.Append("<br/>");
            content.Append("<b>Hospital : </b>");
            content.Append("<br/>");
            content.Append("<b>IP Number : </b>");
            content.Append("<br/>");
            content.Append("<b>Date : </b>");
            content.Append("<br/>");
            content.Append("</p>");


            HtmlFormatProvider provider = new HtmlFormatProvider();
            Telerik.WinControls.RichTextBox.Model.RadDocument document = provider.Import(content.ToString());
            this.docPrintVisit.Document = document;

            this.docPrintVisit.InsertImage((Bitmap)Resources.letterhead);
            docPrintVisit.InsertLineBreak();
            docPrintVisit.InsertLineBreak();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            IDocumentFormatProvider provider = new DocxFormatProvider();
            using (Stream output = (Stream)File.Open("print.docx", FileMode.Create)) { provider.Export(this.docPrintVisit.Document, output); }

            try
            {
                ProcessStartInfo info = new ProcessStartInfo("print.docx");
                info.Verb = "PrintTo";
                info.CreateNoWindow = true;
                info.ErrorDialog = false;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(info);
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateVisitList();
        }

        private void listVisits_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listVisits.SelectedIndex != -1)
            {
                RadListDataItem item = listVisits.SelectedItem;

                LoadPrescription(Convert.ToInt32(item.Value.ToString()));
            }
        }

        private void LoadPrescription(int visitid)
        {

            Patient patient = new PatientData().GetPatientById(_patientid);

            StringBuilder content = new StringBuilder();
            content.Append("<p>");
            content.Append("<b>Patient Name : </b>" + patient.FirstName.ToUpper() + " " + patient.LastName.ToUpper());
            content.Append("<br/>");
            content.Append("<b>Patient Id : </b>" + _patientid.ToString());
            content.Append("<br/>");
            content.Append("<b>Age : </b>" + Utility.GetAgeFromDob(patient.DOB).ToString());
            content.Append("<br/>");
            content.Append("<b>Address : </b>" + patient.Address.ToUpper());
            content.Append("<br/>");
            content.Append("<b>Hospital : </b>");
            content.Append("<br/>");
            content.Append("<b>IP Number : </b>");
            content.Append("<br/>");
            content.Append("<b>Date : </b>");
            content.Append("<br/>");
            content.Append("</p>");

            VisitData db = new VisitData();

            PatientVisit visit = db.GetVisitById(visitid);
            if (visit != null)
            {
                content.Append("<p>");

                content.Append("<br/>");
                content.Append("<b>Presenting complaint and relevant history : </b>");
                content.Append("<br/>");
                content.Append(visit.ComplaintHistory);
                content.Append("<br/>");

                content.Append("<br/>");
                content.Append("<b>Clinical findings : </b>");
                content.Append("<br/>");
                content.Append(visit.ExaminationNotes);
                content.Append("<br/>");

                content = AddLabData(db.GetLabData(visitid), content);

                AddImagingData(db.GetImagingData(visitid), content);

                content.Append("<br/>");
                content.Append("<b>Diagnosis : </b>");
                content.Append("<br/>");
                content.Append(visit.Diagnosis);
                content.Append("<br/>");

                AddPrescriptionData(db.GetPrescriptionData(visitid), content);

                content.Append("<br/>");
                content.Append("<b>Other Advise : </b>");
                content.Append("<br/>");
                content.Append(visit.OtherAdvise);
                content.Append("<br/>");

                content.Append("<br/>");
                content.Append("<b>Follow Up Date : </b>");
                content.Append("<br/>");
                if (visit.IsFolowUpRequired)
                {
                    content.Append(visit.FollowUpDate.ToShortDateString());
                }
                content.Append("<br/>");

                content.Append("</p>");
            }

            HtmlFormatProvider provider = new HtmlFormatProvider();
            Telerik.WinControls.RichTextBox.Model.RadDocument document = provider.Import(content.ToString());
            this.docPrintVisit.Document = document;

            this.docPrintVisit.InsertImage((Bitmap)Resources.letterhead);
            docPrintVisit.InsertLineBreak();
            docPrintVisit.InsertLineBreak();
        }

        private StringBuilder AddPrescriptionData(List<Prescription> list, StringBuilder content)
        {
            if (list.Count > 0)
            {
                content.Append("<p>");

                content.Append("<b>Prescription : </b>");
                content.Append("<br/>");
                content.Append("<table border='1' cellpadding='5'>");
                content.Append("<tr>");
                content.Append("<td><b>&nbsp;Drug</b></td><td><b>&nbsp;Dosage</b></td><td><b>&nbsp;Duration (days)</b></td><td><b>&nbsp;Instructions</b></td>");
                content.Append("</tr>");
                foreach (Prescription data in list)
                {
                    content.Append("<tr>");
                    content.Append("<td>&nbsp;"); content.Append(data.DrugName); content.Append("</td>");
                    content.Append("<td>&nbsp;"); content.Append(data.Dosage); content.Append("</td>");
                    content.Append("<td>&nbsp;"); content.Append(data.Duration); content.Append("</td>");
                    content.Append("<td>&nbsp;"); content.Append(data.Instructions); content.Append("</td>");
                    content.Append("</tr>");
                }
                content.Append("</table>");

                content.Append("<p>");
                content.Append("<br/>");
            }

            return content;
        }

        private StringBuilder AddImagingData(List<PatientImagingData> list, StringBuilder content)
        {
            if (list.Count > 0)
            {
                content.Append("<p>");

                content.Append("<b>Imaging : </b>");
                content.Append("<br/>");
                content.Append("<table border='1' cellpadding='5'>");
                content.Append("<tr>");
                content.Append("<td><b>&nbsp;Imaging</b></td><td><b>&nbsp;Finding</b></td><td><b>&nbsp;Date</b></td>");
                content.Append("</tr>");
                foreach (PatientImagingData data in list)
                {
                    content.Append("<tr>");
                    content.Append("<td>&nbsp;"); content.Append(data.ImagingName); content.Append("</td>");
                    content.Append("<td>&nbsp;"); content.Append(data.Findings); content.Append("</td>");
                    content.Append("<td>&nbsp;"); content.Append(data.TestDate.ToShortDateString()); content.Append("</td>");
                    content.Append("</tr>");
                }
                content.Append("</table>");

                content.Append("<p>");
                content.Append("<br/>");
            }

            return content;
        }

        private StringBuilder AddLabData(List<PatientLabData> list, StringBuilder content)
        {
            if (list.Count > 0)
            {
                content.Append("<p>");

                content.Append("<b>Lab Data : </b>");
                content.Append("<br/>");
                content.Append("<table border='1' cellpadding='5'>");
                content.Append("<tr>");
                content.Append("<td><b>&nbsp;Lab Test</b></td><td><b>&nbsp;Result</b></td><td><b>&nbsp;Date</b></td>");
                content.Append("</tr>");
                foreach (PatientLabData data in list)
                {
                    content.Append("<tr>");
                    content.Append("<td>&nbsp;"); content.Append(data.LabTestName); content.Append("</td>");
                    content.Append("<td>&nbsp;"); content.Append(data.Results); content.Append("</td>");
                    content.Append("<td>&nbsp;"); content.Append(data.TestDate.ToShortDateString()); content.Append("</td>");
                    content.Append("</tr>");
                }
                content.Append("</table>");

                content.Append("<p>");
                content.Append("<br/>");
            }

            return content;
        }

        private void AddLabData(int visitid)
        {
            //List<Patien

            //Telerik.WinControls.RichTextBox.Model.Table table = new Telerik.WinControls.RichTextBox.Model.Table();
            //Telerik.WinControls.RichTextBox.Model.TableRow tablerow = new Telerik.WinControls.RichTextBox.Model.TableRow();
            //tablerow.Cells.Add(new Telerik.WinControls.RichTextBox.Model.TableCell().
            //docPrintVisit.InsertTable(
        }

        private void listVisits_ItemDataBound(object sender, ListItemDataBoundEventArgs args)
        {
            args.NewItem.Height = 100;
        }
    }
}
