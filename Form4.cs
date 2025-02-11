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
    public partial class Form4 : Form
    {
        public string PatientNameInput { get; private set; }
        public DateTime AppointmentDateInput { get; private set; }
        public DateTime AppointmentTimeInput { get; private set; }
        public string DoctorNameInput { get; private set; }
        public string ReasonInput { get; private set; }

        public Form4()
        {
            InitializeComponent();
            ConfigureTimePicker();
        }

        private void ConfigureTimePicker()
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "hh:mm tt"; // Time format: 12-hour with AM/PM
            dateTimePicker2.ShowUpDown = true;        // Removes calendar, enabling only time selection
        }

        // Enable Add Mode
        public void EnableAddMode()
        {
            button1.Enabled = true;  // Enable Add button
            button2.Enabled = false; // Disable Save Changes button
        }

        // Enable Edit Mode with existing appointment data
        public void EnableEditMode(string patientName, DateTime appointmentDate, DateTime appointmentTime, string doctorName, string reason)
        {
            textBox1.Text = patientName;
            dateTimePicker1.Value = appointmentDate;
            dateTimePicker2.Value = appointmentTime;
            textBox2.Text = doctorName;
            textBox3.Text = reason;

            button1.Enabled = false; // Disable Add button
            button2.Enabled = true;  // Enable Save Changes button
        }

        // Collect the input data from textboxes
        private void CollectInput()
        {
            PatientNameInput = textBox1.Text;
            AppointmentDateInput = dateTimePicker1.Value.Date; // Get only the date
            AppointmentTimeInput = dateTimePicker2.Value; // Get the time
            DoctorNameInput = textBox2.Text;
            ReasonInput = textBox3.Text;

            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(PatientNameInput) ||
                string.IsNullOrWhiteSpace(DoctorNameInput) ||
                string.IsNullOrWhiteSpace(ReasonInput))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// add
        {
            CollectInput();
        }

        private void button2_Click(object sender, EventArgs e)// save changes
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
