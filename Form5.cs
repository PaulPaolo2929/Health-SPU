using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trial
{
    public partial class Form5 : Form
    {
        public string DoctorNameInput { get; private set; }
        public string TreatmentTypeInput { get; private set; }
        public string PatientNameInput { get; private set; }
        public string DiagnosisInput { get; private set; }
        public string MedicationInput { get; private set; }
        public string RemarksInput { get; private set; }
        public string DateInput { get; private set; }


        public Form5()
        {
            InitializeComponent();
        }

        public void EnableAddMode()
        {
            button1.Enabled = true;  // Enable Add button
            button2.Enabled = false; // Disable Save Changes button
        }

        public void EnableEditMode(string doctorName, string treatmentType, string patientName, string diagnosis, string medication, string remarks, string date)
        {
            textBox1.Text = doctorName;
            textBox2.Text = treatmentType;
            textBox3.Text = patientName;
            textBox4.Text = diagnosis;
            textBox5.Text = medication;
            textBox6.Text = remarks;
            textBox7.Text = date;

            button1.Enabled = false; // Disable Add button
            button2.Enabled = true;  // Enable Save Changes button
        }

        private void CollectInput()
        {
            DoctorNameInput = textBox1.Text;
            TreatmentTypeInput = textBox2.Text;
            PatientNameInput = textBox3.Text;
            DiagnosisInput = textBox4.Text;
            MedicationInput = textBox5.Text;
            RemarksInput = textBox6.Text;
            DateInput = textBox7.Text;

            if (string.IsNullOrWhiteSpace(DoctorNameInput) ||
                string.IsNullOrWhiteSpace(TreatmentTypeInput) ||
                string.IsNullOrWhiteSpace(PatientNameInput) ||
                string.IsNullOrWhiteSpace(DiagnosisInput) ||
                string.IsNullOrWhiteSpace(MedicationInput) ||
                string.IsNullOrWhiteSpace(RemarksInput) ||
                string.IsNullOrWhiteSpace(DateInput))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectInput();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CollectInput();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
