using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial
{
    public partial class Form6 : Form
    {
        public string PatientIDInput { get; private set; }
        public string FullnameInput { get; private set; }
        public string ConditionInput { get; private set; }
        public string ContactNumberInput { get; private set; }
        public string StatusInput { get; private set; }



        public Form6()
        {
            InitializeComponent();
        }

        public void EnableAddMode()
        {
            button1.Enabled = true;  // Enable Add button
            button2.Enabled = false;  // Disable Save Changes button
        }

        // Method to enable Edit mode for an existing patient's details
        public void EnableEditMode(string patientID, string status)
        {
            textBox1.Text = patientID;
            textBox2.Text = status;

            button1.Enabled = false;  // Disable Add button
            button2.Enabled = true;  // Enable Save Changes button
        }

        // Collects input from the form's text fields
        private void CollectInput()
        {
            PatientIDInput = textBox1.Text;
            FullnameInput = textBox3.Text;
            ConditionInput = textBox5.Text;
            ContactNumberInput = textBox4.Text;
            StatusInput = textBox2.Text;

            // Check if any required fields are empty
            if (string.IsNullOrWhiteSpace(PatientIDInput) ||
                string.IsNullOrWhiteSpace(FullnameInput) ||
                string.IsNullOrWhiteSpace(ConditionInput) ||
                string.IsNullOrWhiteSpace(ContactNumberInput) ||
                string.IsNullOrWhiteSpace(StatusInput))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If all fields are filled, return the OK dialog result and close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //add
        {
            CollectInput();
        }

        private void button2_Click(object sender, EventArgs e) //save changes
        {
            CollectInput();
        }

        private void button3_Click(object sender, EventArgs e) //cancel
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
