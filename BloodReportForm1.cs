
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace BloodReportManagement
{
    public partial class BloodReportForm1 : Form
    {
        private List<BloodReport> bloodReports = new List<BloodReport>();

        public BloodReportForm1()
        {
            InitializeComponent();
        }

        private void BloodReportForm1_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientID.Text) ||
                string.IsNullOrWhiteSpace(txtPatientName.Text) ||
                string.IsNullOrWhiteSpace(txtRbcCount.Text) ||
                string.IsNullOrWhiteSpace(txtWbcCount.Text) ||
                string.IsNullOrWhiteSpace(txtPlateletCount.Text) ||
                string.IsNullOrWhiteSpace(txtHemoglobin.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int patientID;
            if (!int.TryParse(txtPatientID.Text, out patientID))
            {
                MessageBox.Show("Invalid Patient ID. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bloodReports.Any(r => r.PatientID == patientID))
            {
                MessageBox.Show("A report for this Patient ID already exists. Please enter a unique Patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BloodReport report = new BloodReport
            {
                ReportID = bloodReports.Count + 1,
                PatientID = patientID,
                PatientName = txtPatientName.Text,
                TestDate = dtpTestDate.Value,
                RBCCount = Convert.ToDouble(txtRbcCount.Text),
                WBCCount = Convert.ToDouble(txtWbcCount.Text),
                PlateletCount = Convert.ToDouble(txtPlateletCount.Text),
                HemoglobinLevel = Convert.ToDouble(txtHemoglobin.Text)
            };

            bloodReports.Add(report);
            RefreshDataGrid();
            ClearFields();
            MessageBox.Show("Report added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (dataGridViewReports.SelectedRows.Count > 0)
            {
                int reportId = Convert.ToInt32(dataGridViewReports.SelectedRows[0].Cells[0].Value);
                ExportReportToPdf(reportId);
            }
            else
            {
                MessageBox.Show("Please select a report to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExportReportToPdf(int reportId)
        {
            BloodReport report = bloodReports.FirstOrDefault(r => r.ReportID == reportId);

            if (report != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF file (*.pdf)|*.pdf",
                    FileName = $"BloodReport_{report.ReportID}.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PdfDocument document = new PdfDocument();
                        PdfPage page = document.AddPage();
                        XGraphics gfx = XGraphics.FromPdfPage(page);
                        XFont font = new XFont("Arial", 12);

                        gfx.DrawString("Blood Report", font, XBrushes.Black, new XPoint(20, 20));
                        gfx.DrawString($"Report ID: {report.ReportID}", font, XBrushes.Black, new XPoint(20, 50));
                        gfx.DrawString($"Patient ID: {report.PatientID}", font, XBrushes.Black, new XPoint(20, 80));
                        gfx.DrawString($"Patient Name: {report.PatientName}", font, XBrushes.Black, new XPoint(20, 110));
                        gfx.DrawString($"Test Date: {report.TestDate:yyyy-MM-dd}", font, XBrushes.Black, new XPoint(20, 140));

                        gfx.DrawString($"RBC Count: {report.RBCCount} million/\u03BCL ({report.GetRBCCategory()})", font, XBrushes.Black, new XPoint(20, 170));
                        gfx.DrawString($"WBC Count: {report.WBCCount} /\u03BCL ({report.GetWBCCategory()})", font, XBrushes.Black, new XPoint(20, 200));
                        gfx.DrawString($"Platelet Count: {report.PlateletCount} /\u03BCL ({report.GetPlateletCategory()})", font, XBrushes.Black, new XPoint(20, 230));
                        gfx.DrawString($"Hemoglobin Level: {report.HemoglobinLevel} g/dL ({report.GetHemoglobinCategory()})", font, XBrushes.Black, new XPoint(20, 260));

                        document.Save(saveFileDialog.FileName);

                        MessageBox.Show("PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Report not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGrid()
        {
            dataGridViewReports.DataSource = null;
            dataGridViewReports.DataSource = bloodReports.Select(r => new
            {
                r.ReportID,
                r.PatientID,
                r.PatientName,
                r.TestDate,
                RBCCount = $"{r.RBCCount} million/\u03BCL",
                RBCCategory = r.GetRBCCategory(),
                WBCCount = $"{r.WBCCount} /\u03BCL",
                WBCCategory = r.GetWBCCategory(),
                PlateletCount = $"{r.PlateletCount} /\u03BCL",
                PlateletCategory = r.GetPlateletCategory(),
                HemoglobinLevel = $"{r.HemoglobinLevel} g/dL",
                HemoglobinCategory = r.GetHemoglobinCategory()
            }).ToList();
        }

        private void ClearFields()
        {
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtRbcCount.Clear();
            txtWbcCount.Clear();
            txtPlateletCount.Clear();
            txtHemoglobin.Clear();
            dtpTestDate.Value = DateTime.Now;
        }







        private void BloodReportForm1_Load_3(object sender, EventArgs e)
        {
            // This method is unused; remove or clean up reference in Designer.cs
        }

        private void txtHemoglobin_TextChanged(object sender, EventArgs e)
        {
            // This method is unused; remove or clean up reference in Designer.cs
        }

    }

    public class BloodReport
    {
        public int ReportID { get; set; }
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public DateTime TestDate { get; set; }
        public double RBCCount { get; set; }
        public double WBCCount { get; set; }
        public double PlateletCount { get; set; }
        public double HemoglobinLevel { get; set; }

        public string GetRBCCategory()
        {
            if (RBCCount < 4.7) return "Low";
            if (RBCCount > 6.1) return "High";
            return "Normal";
        }

        public string GetWBCCategory()
        {
            if (WBCCount < 4000) return "Low";
            if (WBCCount > 11000) return "High";
            return "Normal";
        }

        public string GetPlateletCategory()
        {
            if (PlateletCount < 150000) return "Low";
            if (PlateletCount > 450000) return "High";
            return "Normal";
        }

        public string GetHemoglobinCategory()
        {
            if (HemoglobinLevel < 13.5) return "Low";
            if (HemoglobinLevel > 17.5) return "High";
            return "Normal";
        }
    }
}
