using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial.UserControls
{
    public partial class UserControl6 : UserControl
    {
        private Queue<Patient> emergencyQueue = new Queue<Patient>(); // Queue to handle patients
        private int selectedRowIndex = -1;

        public UserControl6()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 6; // Update column count for Queue system
            dataGridView1.Columns[0].Name = "Queue Position";
            dataGridView1.Columns[1].Name = "Patient ID";
            dataGridView1.Columns[2].Name = "Fullname";
            dataGridView1.Columns[3].Name = "Condition";
            dataGridView1.Columns[4].Name = "Contact Number";
            dataGridView1.Columns[5].Name = "Status";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UserControl6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // add
        {
            Form6 form6 = new Form6();

            form6.EnableAddMode(); // Disable Save Changes button
            form6.ShowDialog();

            if (form6.DialogResult == DialogResult.OK)
            {
                // Add patient to the queue
                Patient newPatient = new Patient
                {
                    PatientID = form6.PatientIDInput,
                    Fullname = form6.FullnameInput,
                    Condition = form6.ConditionInput,
                    ContactNumber = form6.ContactNumberInput,
                    Status = "Waiting"
                };

                emergencyQueue.Enqueue(newPatient);

                // Display the patient in the DataGridView
                DisplayQueue();
            }
        }

        private void button2_Click(object sender, EventArgs e) //delete
        {
            if (emergencyQueue.Count > 0)
            {
                // Process the patient at the front of the queue
                Patient patientToProcess = emergencyQueue.Dequeue();
                patientToProcess.Status = "Being Processed"; // Update status

                // Display the updated queue
                DisplayQueue();
            }
            else
            {
                MessageBox.Show("No patients in the queue to process.", "Queue Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e) // edit
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                string patientID = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
                string status = dataGridView1.Rows[selectedRowIndex].Cells[5].Value.ToString();

                Form6 form6 = new Form6();
                form6.EnableEditMode(patientID, status); // Pass current data for editing
                form6.ShowDialog();

                if (form6.DialogResult == DialogResult.OK)
                {
                    // Update status in the queue
                    foreach (var patient in emergencyQueue)
                    {
                        if (patient.PatientID == patientID)
                        {
                            patient.Status = form6.StatusInput; // Update patient status
                        }
                    }

                    // Refresh the DataGridView with the updated queue
                    DisplayQueue();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayQueue()
        {
            dataGridView1.Rows.Clear();
            int queuePosition = 1;

            // Display each patient in the queue
            foreach (var patient in emergencyQueue)
            {
                string[] row =
                {
                queuePosition.ToString(),
                patient.PatientID,
                patient.Fullname,
                patient.Condition,
                patient.ContactNumber,
                patient.Status
            };
                dataGridView1.Rows.Add(row);
                queuePosition++;
            }
        }

        // Create a Patient class to represent the data structure
        public class Patient
        {
            public string PatientID { get; set; }
            public string Fullname { get; set; }
            public string Condition { get; set; }
            public string ContactNumber { get; set; }
            public string Status { get; set; }
        }
    }
}
