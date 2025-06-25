namespace AdvancedBloodReportApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();  // This is where the designer file is called to initialize components
        }

        // Event to generate a report
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Example data insertion into DataGridView
            dgvBloodReport.Rows.Add("RBC Count", "5.1", "4.7 - 6.1", "Normal");
            dgvBloodReport.Rows.Add("Hemoglobin", "14.5", "12 - 16", "Normal");
            dgvBloodReport.Rows.Add("WBC Count", "7.2", "4.0 - 10.0", "Normal");
        }

        // Event to clear the data
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvBloodReport.Rows.Clear();  // Clears all rows from the DataGridView
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

