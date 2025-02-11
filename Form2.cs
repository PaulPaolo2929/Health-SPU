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
    public partial class Form2 : Form
    {
        public string RoomNumberInput { get; private set; }
        public string PatientIDInput { get; private set; }
        public string FullnameInput { get; private set; }
        public string AgeInput { get; private set; }
        public string GenderInput { get; private set; }
        public string ContactNumberInput { get; private set; }
        public string InsuranceTypeInput { get; private set; }
        public string EmergencyContactInput { get; private set; }
        public string StatusInput { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        public void EnableAddMode()
        {
            button1.Enabled = true; // Enable Add button
            button2.Enabled = false; // Disable Save Changes button
        }

        public void EnableEditMode(string roomNumber, string patientID, string fullname, string age, string gender, string contactNumber, string insuranceType, string emergencyContact, string status)
        {
            textBox1.Text = roomNumber;
            textBox2.Text = patientID;
            textBox3.Text = fullname;
            textBox4.Text = age;
            textBox5.Text = gender;
            textBox6.Text = contactNumber;
            textBox7.Text = insuranceType;
            textBox8.Text = emergencyContact;
            textBox9.Text = status;

            button1.Enabled = false; // Disable Add button
            button2.Enabled = true;  // Enable Save Changes button
        }



        private void CollectInput()
        {
            RoomNumberInput = textBox1.Text;
            PatientIDInput = textBox2.Text;
            FullnameInput = textBox3.Text;
            AgeInput = textBox4.Text;
            GenderInput = textBox5.Text;
            ContactNumberInput = textBox6.Text;
            InsuranceTypeInput = textBox7.Text;
            EmergencyContactInput = textBox8.Text;
            StatusInput = textBox9.Text;

            if (string.IsNullOrWhiteSpace(RoomNumberInput) ||
                string.IsNullOrWhiteSpace(PatientIDInput) ||
                string.IsNullOrWhiteSpace(FullnameInput) ||
                string.IsNullOrWhiteSpace(AgeInput) ||
                string.IsNullOrWhiteSpace(GenderInput) ||
                string.IsNullOrWhiteSpace(ContactNumberInput) ||
                string.IsNullOrWhiteSpace(InsuranceTypeInput) ||
                string.IsNullOrWhiteSpace(EmergencyContactInput) ||
                string.IsNullOrWhiteSpace(StatusInput))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e) // Cancel/close Button
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //Edit Info Button
        {
            CollectInput();
        }

        private void button1_Click(object sender, EventArgs e) // Add Info Button
        {
            CollectInput();
        }
    }
}
