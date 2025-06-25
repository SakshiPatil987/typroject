
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;

namespace HospitalBilling
{
    public partial class MainForm : Form
    {
        private List<Patient> patients;
        private List<Bill> bills;
        private List<Service> services;

        public MainForm()
        {
            InitializeComponent();
            patients = new List<Patient>();
            bills = new List<Bill>();
            LoadServices();
        }

        private void LoadServices()
        {
            services = new List<Service>
            {
                new Service("Consultation", 100),
                new Service("Surgery", 5000),
                new Service("X-ray", 300),
                new Service("Blood Test", 150),
                new Service("MRI Scan", 1200),
                new Service("ECG", 250)
            };

            foreach (var service in services)
            {
                clbServices.Items.Add($"{service.Name} - ${service.Price}");
            }
        }

        private void BtnRegisterPatient_Click(object sender, EventArgs e)
        {
            string name = txtPatientName.Text;
            string phone = txtPhone.Text;
            string gender = cmbGender.SelectedItem?.ToString();
            string doctor = cmbDoctor.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || gender == null || doctor == null)
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Patient newPatient = new Patient(name, phone, gender, doctor);
            patients.Add(newPatient);
            UpdatePatientGrid();
        }

        private void UpdatePatientGrid()
        {
            dataGridViewPatients.DataSource = null;
            dataGridViewPatients.DataSource = patients;
        }

        private void BtnGenerateBill_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Patient selectedPatient = (Patient)dataGridViewPatients.SelectedRows[0].DataBoundItem;
            List<Service> selectedServices = clbServices.CheckedItems
                .Cast<string>()
                .Select(item => services.First(s => $"{s.Name} - ${s.Price}" == item))
                .ToList();

            decimal totalCost = selectedServices.Sum(s => s.Price);
            decimal discount = decimal.TryParse(txtDiscount.Text, out decimal disc) ? disc : 0;
            decimal finalAmount = totalCost - (totalCost * discount / 100);
            decimal amountPaid = decimal.TryParse(txtActualPay.Text, out decimal paid) ? paid : 0;
            string paymentMethod = cmbPaymentMethod.SelectedItem?.ToString();
            string paymentStatus = amountPaid >= finalAmount ? "Paid" : amountPaid > 0 ? "Partially Paid" : "Pending";

            Bill newBill = new Bill(selectedPatient, selectedServices, totalCost, discount, finalAmount, paymentMethod, amountPaid, paymentStatus);
            bills.Add(newBill);
            UpdateBillGrid();
        }

        private void UpdateBillGrid()
        {
            dataGridViewBills.DataSource = null;
            dataGridViewBills.DataSource = bills.Select(b => new
            {
                PatientName = b.Patient.Name,
                Services = string.Join(", ", b.Services.Select(s => s.Name)),
                TotalAmount = b.TotalAmount.ToString("F2"),
                Discount = b.Discount + "%",
                FinalAmount = b.FinalAmount.ToString("F2"),
                PaymentMethod = b.PaymentMethod,
                AmountPaid = b.AmountPaid.ToString("F2"),
                PaymentStatus = b.PaymentStatus
            }).ToList();
        }

        private void BtnExportPDF_Click(object sender, EventArgs e)
        {
            if (dataGridViewBills.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a bill to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string patientName = dataGridViewBills.SelectedRows[0].Cells["PatientName"].Value.ToString();
            Bill selectedBill = bills.FirstOrDefault(b => b.Patient.Name == patientName);

            if (selectedBill == null)
            {
                MessageBox.Show("Error retrieving the selected bill.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "PDF files (*.pdf)|*.pdf", Title = "Save Bill as PDF" };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PdfGenerator.GeneratePDF(selectedBill, saveFileDialog.FileName);
                MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {

        }
    }

    // Patient Class
    public class Patient
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Doctor { get; set; }

        public Patient(string name, string phone, string gender, string doctor)
        {
            Name = name;
            Phone = phone;
            Gender = gender;
            Doctor = doctor;
        }
    }

    // Service Class
    public class Service
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Service(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    // Bill Class
    public class Bill
    {
        public Patient Patient { get; set; }
        public List<Service> Services { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentStatus { get; set; }

        public Bill(Patient patient, List<Service> services, decimal totalAmount, decimal discount, decimal finalAmount, string paymentMethod, decimal amountPaid, string paymentStatus)
        {
            Patient = patient;
            Services = services;
            TotalAmount = totalAmount;
            Discount = discount;
            FinalAmount = finalAmount;
            PaymentMethod = paymentMethod;
            AmountPaid = amountPaid;
            PaymentStatus = paymentStatus;
        }
    }

    // PDF Generator Class
    public static class PdfGenerator
    {
        public static void GeneratePDF(Bill bill, string filePath)
        {
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18f);
            iTextSharp.text.Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12f);

            // Add hospital logo
            string logoPath = Path.Combine(Application.StartupPath, "C:\\Users\\Sakshi Patil\\source\\repos\\typroject\\bin\\Debug\\logo.png");
            if (File.Exists(logoPath))
            {
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                logo.ScaleToFit(100f, 100f);
                logo.Alignment = Element.ALIGN_CENTER;
                doc.Add(logo);
            }

            doc.Add(new Paragraph("Ashirwad hospital", titleFont));
            doc.Add(new Paragraph(" "));

            doc.Add(new Paragraph($"Patient: {bill.Patient.Name}", normalFont));
            doc.Add(new Paragraph($"Phone: {bill.Patient.Phone}", normalFont));
            doc.Add(new Paragraph($"Doctor: {bill.Patient.Doctor}", normalFont));
            doc.Add(new Paragraph(" "));

            PdfPTable table = new PdfPTable(2);
            table.AddCell("Service");
            table.AddCell("Cost ($)");

            foreach (var service in bill.Services)
            {
                table.AddCell(service.Name);
                table.AddCell(service.Price.ToString("F2"));
            }

            doc.Add(table);
            doc.Add(new Paragraph($"Total Amount: ${bill.TotalAmount:F2}", normalFont));
            doc.Add(new Paragraph($"Discount: {bill.Discount}%", normalFont));
            doc.Add(new Paragraph($"Final Amount: ${bill.FinalAmount:F2}", normalFont));
            doc.Add(new Paragraph($"Payment Method: {bill.PaymentMethod:F2}", normalFont));
            doc.Add(new Paragraph($"Amount Paid: ${bill.AmountPaid:F2}", normalFont));

            doc.Add(new Paragraph($"Payment Status: {bill.PaymentStatus:F2}", normalFont));





            doc.Close();
        }
    }
}
