using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Trial.UserControl1;

namespace Trial
{
    public partial class UserControl2 : UserControl
    {
        private int selectedRowIndex = -1; // Store the selected row index for editing
        public UserControl2()
        {
            InitializeComponent();
            InitializeDataGridView(); // Initialize DataGridView columns
        }


        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "Room Number";
            dataGridView1.Columns[1].Name = "Patient ID";
            dataGridView1.Columns[2].Name = "Fullname";
            dataGridView1.Columns[3].Name = "Age";
            dataGridView1.Columns[4].Name = "Gender";
            dataGridView1.Columns[5].Name = "Contact Number";
            dataGridView1.Columns[6].Name = "Insurance Type";
            dataGridView1.Columns[7].Name = "Emergency Contact";
            dataGridView1.Columns[8].Name = "Status";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click_1(object sender, EventArgs e) // add
        {
            Form2 form2 = new Form2();

            // Open Form2 for adding new data
            form2.EnableAddMode(); // Disable Save Changes button
            form2.ShowDialog();

            if (form2.DialogResult == DialogResult.OK)
            {
                string[] row = { // Using ARRRAY FOR GETTING, HANDLING, STORING DATA
                    form2.RoomNumberInput,
                    form2.PatientIDInput,
                    form2.FullnameInput,
                    form2.AgeInput,
                    form2.GenderInput,
                    form2.ContactNumberInput,
                    form2.InsuranceTypeInput,
                    form2.EmergencyContactInput,
                    form2.StatusInput
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void button2_Click_1(object sender, EventArgs e) //delete
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e) //edit
                {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // Get the selected row data
                string roomNumber = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
                string patientID = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
                string fullname = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
                string age = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
                string gender = dataGridView1.Rows[selectedRowIndex].Cells[4].Value.ToString();
                string contactNumber = dataGridView1.Rows[selectedRowIndex].Cells[5].Value.ToString();
                string insuranceType = dataGridView1.Rows[selectedRowIndex].Cells[6].Value.ToString();
                string emergencyContact = dataGridView1.Rows[selectedRowIndex].Cells[7].Value.ToString();
                string status = dataGridView1.Rows[selectedRowIndex].Cells[8].Value.ToString();

                Form2 form2 = new Form2();

                // Pass data to Form2 and enable Edit mode
                form2.EnableEditMode(roomNumber, patientID, fullname, age, gender, contactNumber, insuranceType, emergencyContact, status);
                form2.ShowDialog();

                if (form2.DialogResult == DialogResult.OK)
                {
                    // Update the selected row with the new data
                    dataGridView1.Rows[selectedRowIndex].Cells[0].Value = form2.RoomNumberInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[1].Value = form2.PatientIDInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[2].Value = form2.FullnameInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[3].Value = form2.AgeInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[4].Value = form2.GenderInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = form2.ContactNumberInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[6].Value = form2.InsuranceTypeInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[7].Value = form2.EmergencyContactInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[8].Value = form2.StatusInput;
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        
    }
}
