using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Trial.UserControls.UserControl7;

namespace Trial
{
    public partial class Form7 : Form
    {
        public string NameInput { get; private set; }
        public DateTime DateInput { get; private set; }
        public string MedicationInput { get; private set; }
        public string DosageInput { get; private set; }
        public string FrequencyInput { get; private set; }
        public string NotesInput { get; private set; }


        public Form7()
        {
            InitializeComponent();
        }

        public void EnableAddMode()
        {
            button1.Enabled = true;  // Enable Add button
            button2.Enabled = false; // Disable Save Changes button
        }

        // Enable Edit Mode with the selected prescription data
        public void EnableEditMode(Prescription prescription)
        {
            textBox1.Text = prescription.Name;
            dateTimePicker1.Value = prescription.Date;
            textBox2.Text = prescription.Medication;
            textBox3.Text = prescription.Dosage;
            textBox4.Text = prescription.Frequency;
            textBox5.Text = prescription.Notes;

            button1.Enabled = false; // Disable Add button
            button2.Enabled = true;  // Enable Save Changes button
        }

        // Collect the input data from textboxes
        private void CollectInput()
        {
            NameInput = textBox1.Text;
            DateInput = dateTimePicker1.Value;
            MedicationInput = textBox2.Text;
            DosageInput = textBox3.Text;
            FrequencyInput = textBox4.Text;
            NotesInput = textBox5.Text;

            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(NameInput) ||
                string.IsNullOrWhiteSpace(MedicationInput) ||
                string.IsNullOrWhiteSpace(DosageInput) ||
                string.IsNullOrWhiteSpace(FrequencyInput) ||
                string.IsNullOrWhiteSpace(NotesInput))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // ADD
        {
            CollectInput();
        }

        private void button2_Click(object sender, EventArgs e)//Save Changes
        {
            CollectInput();
        }

        private void button3_Click(object sender, EventArgs e) //Cancel
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
