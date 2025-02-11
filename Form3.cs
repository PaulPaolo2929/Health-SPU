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
    public partial class Form3 : Form
    {
        public string IDNumberInput { get; private set; }
        public string FirstnameInput { get; private set; }
        public string MiddlenameInput { get; private set; }
        public string SurnameInput { get; private set; }
        public string SpecializationInput { get; private set; }
        public string WorkingHoursInput { get; private set; }
        public string ContactNumberInput { get; private set; }
        public string AffiliationInput { get; private set; }
        public string LicenseNumberInput { get; private set; }
        public string OfficeRoomNumberInput { get; private set; }

        private bool isEditMode = false;

        public Form3()
        {
            InitializeComponent();
        }

       

        // Enable Add Mode
        public void EnableAddMode()
        {
            
           button1.Enabled = true; // Enable Add button
           button2.Enabled = false; // Disable Save Changes button
            

            isEditMode = false;
            this.Text = "Add New Entry";

            // Clear all input fields
            ClearInputFields();
        }



        public void EnableEditMode(string idNumber, string firstname, string middlename, string surname, string specialization, string workingHours, string contactNumber, string affiliation, string licenseNumber, string officeRoomNumber)
        {
             isEditMode = true;
            this.Text = "Edit Entry";

            textBox1.Text = idNumber;
            textBox2.Text = firstname;
            textBox3.Text = middlename;
            textBox4.Text = surname;
            textBox5.Text = specialization;
            textBox6.Text = workingHours;
            textBox7.Text = contactNumber;
            textBox8.Text = affiliation;
            textBox9.Text = licenseNumber;
            textBox10.Text = officeRoomNumber;

            textBox1.Enabled = false;// DISABLE TEXT

            button1.Enabled = false; // Disable Add button
            button2.Enabled = true;  // Enable Save Changes button
        }

        private void CollectInput()
        {
            IDNumberInput = textBox1.Text;
            FirstnameInput = textBox2.Text;
            MiddlenameInput = textBox3.Text;
            SurnameInput = textBox4.Text;
            SpecializationInput = textBox5.Text;
            WorkingHoursInput = textBox6.Text;
            ContactNumberInput = textBox7.Text;
            AffiliationInput = textBox8.Text;
            LicenseNumberInput = textBox9.Text;
            OfficeRoomNumberInput = textBox10.Text;

            if (string.IsNullOrWhiteSpace(IDNumberInput) ||
                string.IsNullOrWhiteSpace(FirstnameInput) ||
                string.IsNullOrWhiteSpace(MiddlenameInput) ||
                string.IsNullOrWhiteSpace(SurnameInput) ||
                string.IsNullOrWhiteSpace(SpecializationInput) ||
                string.IsNullOrWhiteSpace(WorkingHoursInput) ||
                string.IsNullOrWhiteSpace(ContactNumberInput) ||
                string.IsNullOrWhiteSpace(AffiliationInput) ||
                string.IsNullOrWhiteSpace(LicenseNumberInput) ||
                string.IsNullOrWhiteSpace(OfficeRoomNumberInput))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ClearInputFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox1.Enabled = true; // Enable editing of ID Number
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e) // cancel button
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e) // save changes button
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assign input values to properties
            IDNumberInput = textBox1.Text.Trim();
            FirstnameInput = textBox2.Text.Trim();
            MiddlenameInput = textBox3.Text.Trim();
            SurnameInput = textBox4.Text.Trim();
            SpecializationInput = textBox5.Text.Trim();
            WorkingHoursInput = textBox6.Text.Trim();
            ContactNumberInput = textBox7.Text.Trim();
            AffiliationInput = textBox8.Text.Trim();
            LicenseNumberInput = textBox9.Text.Trim();
            OfficeRoomNumberInput = textBox10.Text.Trim();

            // Set dialog result and close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e) //Add Info Button
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assign input values to properties
            IDNumberInput = textBox1.Text.Trim();
            FirstnameInput = textBox2.Text.Trim();
            MiddlenameInput = textBox3.Text.Trim();
            SurnameInput = textBox4.Text.Trim();
            SpecializationInput = textBox5.Text.Trim();
            WorkingHoursInput = textBox6.Text.Trim();
            ContactNumberInput = textBox7.Text.Trim();
            AffiliationInput = textBox8.Text.Trim();
            LicenseNumberInput = textBox9.Text.Trim();
            OfficeRoomNumberInput = textBox10.Text.Trim();

            // Set dialog result and close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
