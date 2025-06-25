using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PatientInfoApp
{
    public partial class Form1 : Form
    {
        // A class to store patient info
        public class PatientInfo
        {
            public string PatientId { get; set; }
            public string PatientName { get; set; }
            public string Disease { get; set; }
            public string Doctor { get; set; }
            public string SuggestedMedicine { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        // Method to automatically suggest medicine based on disease
        private string GetSuggestedMedicine(string disease)
        {
            switch (disease.ToLower())
            {
                case "flu":
                    return "Tamiflu, Oseltamivir";
                case "headache":
                    return "Aspirin, Ibuprofen, Paracetamol";
                case "cold":
                    return "NyQuil, DayQuil, Decongestants";
                case "cough":
                    return "Cough Syrup, Dextromethorphan, Mucinex";
                case "fever":
                    return "Paracetamol, Ibuprofen, Acetaminophen";
                case "stomach ulcer":
                    return "Omeprazole, Ranitidine, Antacids";
                case "diabetes":
                    return "Metformin, Insulin (Type 1), Sulfonylureas (Type 2)";
                case "hypertension":
                    return "Lisinopril, Amlodipine, Losartan";
                case "asthma":
                    return "Albuterol (Inhaler), Salmeterol, Fluticasone";
                case "allergies":
                    return "Antihistamines (e.g., Loratadine, Cetirizine), Nasal Spray";
                case "pneumonia":
                    return "Amoxicillin, Azithromycin";
                case "migraine":
                    return "Sumatriptan, Excedrin Migraine, Ibuprofen";
                case "acid reflux":
                    return "Esomeprazole, Pantoprazole, Antacids";
                case "copd":
                    return "Salbutamol (Bronchodilators), Prednisone (Steroids)";
                case "infection":
                    return "Ciprofloxacin, Nitrofurantoin (Antibiotics)";
                case "skin rash":
                    return "Hydrocortisone Cream, Calamine Lotion, Topical Steroids";
                case "hypothyroidism":
                    return "Levothyroxine";
                case "arthritis":
                    return "Methotrexate, Ibuprofen, Celecoxib";
                case "depression":
                    return "SSRIs (e.g., Fluoxetine, Sertraline), SNRIs (e.g., Venlafaxine)";
                case "anxiety":
                    return "Diazepam, Lorazepam, Buspirone";
                case "chickenpox":
                    return "Antihistamines, Calamine Lotion, Acetaminophen for fever";
                case "tuberculosis":
                    return "Rifampin, Isoniazid, Pyrazinamide";
                case "hiv/aids":
                    return "Tenofovir, Efavirenz, Emtricitabine (Antiretrovirals)";
                case "stroke": return "Aspirin, Clopidogrel, Atorvastatin";
                case "gout": return "Allopurinol, Colchicine, NSAIDs";
                default:
                    return "Consult a doctor for specific medicine";
            }
        }

        // Method to populate doctor names based on disease
        private void PopulateDoctors(string disease)
        {
            comboBoxDoctors.Items.Clear();

            switch (disease.ToLower())
            {
                case "flu":
                    comboBoxDoctors.Items.Add("Dr. Smith");
                    comboBoxDoctors.Items.Add("Dr. Brown");
                    break;
                case "headache":
                    comboBoxDoctors.Items.Add("Dr. Jain");
                    comboBoxDoctors.Items.Add("Dr. Suresh");
                    break;
                case "cold":
                    comboBoxDoctors.Items.Add("Dr. Donald");
                    comboBoxDoctors.Items.Add("Dr. Smitha");
                    break;
                case "diabetes":
                    comboBoxDoctors.Items.Add("Dr. Madhavi");
                    comboBoxDoctors.Items.Add("Dr. Babita");
                    break;
                case "asthma":
                    comboBoxDoctors.Items.Add("Dr. Shruti");
                    comboBoxDoctors.Items.Add("Dr. Sanika");
                    break;
                case "depression":
                    comboBoxDoctors.Items.Add("Dr. harsh");
                    comboBoxDoctors.Items.Add("Dr. aniket");
                    break;

                case "tuberculosis":
                    comboBoxDoctors.Items.Add("Dr.Jeet");
                    comboBoxDoctors.Items.Add("Dr.Payal");
                    break;
                default:
                    comboBoxDoctors.Items.Add("Dr. General");
                    break;
            }

            if (comboBoxDoctors.Items.Count > 0)
                comboBoxDoctors.SelectedIndex = 0;

        }


        // Method to populate doctor names based on disease
        
            

        // Button click event to display patient info and automatically suggest medicine
        private void button1_Click(object sender, EventArgs e)
        {
            // Getting values from TextBoxes and ComboBox
            string patientId = textBox1.Text; // Patient ID
            string patientName = textBox2.Text; // Patient Name
            string disease = comboBoxDiseases.SelectedItem.ToString(); // Disease
            string doctor = comboBoxDoctors.SelectedItem.ToString(); // Doctor

            // Automatically suggest medicine based on the disease
            string suggestedMedicine = GetSuggestedMedicine(disease);

            // Create a new PatientInfo object with the data
            PatientInfo patient = new PatientInfo
            {
                PatientId = patientId,
                PatientName = patientName,
                Disease = disease,
                Doctor = doctor,
                SuggestedMedicine = suggestedMedicine
            };

            // Add the patient data to the DataGridView
            dataGridView1.Rows.Add(patient.PatientId, patient.PatientName, patient.Disease, patient.Doctor, patient.SuggestedMedicine);

            // Optionally, you can clear the TextBoxes after adding the data
            textBox1.Clear();
            textBox2.Clear();
            comboBoxDiseases.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up the DataGridView columns
            dataGridView1.Columns.Add("PatientId", "Patient ID");
            dataGridView1.Columns.Add("PatientName", "Patient Name");
            dataGridView1.Columns.Add("Disease", "Disease");
            dataGridView1.Columns.Add("Doctor", "Doctor");
            dataGridView1.Columns.Add("SuggestedMedicine", "Suggested Medicine");

            // Populate diseases ComboBox
            comboBoxDiseases.Items.Add("Flu");
            comboBoxDiseases.Items.Add("Headache");
            comboBoxDiseases.Items.Add("Cold");
            comboBoxDiseases.Items.Add("Diabetes");
            comboBoxDiseases.Items.Add("Asthma");


            comboBoxDiseases.Items.Add("fever");
            comboBoxDiseases.Items.Add("depression");
            comboBoxDiseases.Items.Add("anxiety");
            comboBoxDiseases.Items.Add("stroke");
            comboBoxDiseases.Items.Add("hiv/aids");
            comboBoxDiseases.Items.Add("cough");
            comboBoxDiseases.Items.Add("stomach ulcer");
            comboBoxDiseases.Items.Add("tuberculosis");



            comboBoxDiseases.SelectedIndex = 0;

            // Populate doctors based on the selected disease
            PopulateDoctors(comboBoxDiseases.SelectedItem.ToString());

            // Add event handler for when the disease selection changes
            comboBoxDiseases.SelectedIndexChanged += (s, args) =>
            {
                PopulateDoctors(comboBoxDiseases.SelectedItem.ToString());
            };
        }
    }
}