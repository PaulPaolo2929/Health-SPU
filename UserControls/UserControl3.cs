using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Trial.UserControls
{
    public partial class UserControl3 : UserControl
    {
        private int selectedRowIndex = -1; // Store the selected row index for editing
        private HashSet<string> idSet = new HashSet<string>(); // Using Hashet to detect and won't allow ID input to be duplicated
        public UserControl3()
        {
            InitializeComponent();
            InitializeDataGridView(); // Initialize DataGridView columns
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "ID Number";
            dataGridView1.Columns[1].Name = "Firstname";
            dataGridView1.Columns[2].Name = "Middle Name";
            dataGridView1.Columns[3].Name = "Surname";
            dataGridView1.Columns[4].Name = "Specialization";
            dataGridView1.Columns[5].Name = "Working Hours";
            dataGridView1.Columns[6].Name = "Contact Number";
            dataGridView1.Columns[7].Name = "Affiliation/Field";
            dataGridView1.Columns[8].Name = "License Number";
            dataGridView1.Columns[9].Name = "Office Room Number";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)// add button
        {
            Form3 form3 = new Form3();

            // Open Form3 for adding new data
            form3.EnableAddMode();
            form3.ShowDialog();

            if (form3.DialogResult == DialogResult.OK)
            {
                // Check for duplicate ID
                if (idSet.Contains(form3.IDNumberInput))
                {
                    MessageBox.Show("Duplicate ID Number detected. Cannot add duplicate entries.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add new data
                string[] row = {
                    form3.IDNumberInput,
                    form3.FirstnameInput,
                    form3.MiddlenameInput,
                    form3.SurnameInput,
                    form3.SpecializationInput,
                    form3.WorkingHoursInput,
                    form3.ContactNumberInput,
                    form3.AffiliationInput,
                    form3.LicenseNumberInput,
                    form3.OfficeRoomNumberInput
                };
                dataGridView1.Rows.Add(row);
                idSet.Add(form3.IDNumberInput); // Add to HashSet
            }
        }

        private void button3_Click_1(object sender, EventArgs e)//edit button
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // Get the selected row data
                string idNumber = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
                string firstname = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
                string middleName = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
                string surname = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
                string specialization = dataGridView1.Rows[selectedRowIndex].Cells[4].Value.ToString();
                string workingHours = dataGridView1.Rows[selectedRowIndex].Cells[5].Value.ToString();
                string contactNumber = dataGridView1.Rows[selectedRowIndex].Cells[6].Value.ToString();
                string affiliationField = dataGridView1.Rows[selectedRowIndex].Cells[7].Value.ToString();
                string licenseNumber = dataGridView1.Rows[selectedRowIndex].Cells[8].Value.ToString();
                string officeRoomNumber = dataGridView1.Rows[selectedRowIndex].Cells[9].Value.ToString();

                Form3 form3 = new Form3();

                // Pass data to Form3 and enable Edit mode
                form3.EnableEditMode(idNumber, firstname, middleName, surname, specialization, workingHours, contactNumber, affiliationField, licenseNumber, officeRoomNumber);
                form3.ShowDialog();

                if (form3.DialogResult == DialogResult.OK)
                {
                    // Check for duplicate ID if changed
                    if (idNumber != form3.IDNumberInput && idSet.Contains(form3.IDNumberInput))
                    {
                        MessageBox.Show("Duplicate ID Number detected. Cannot save changes.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Update the selected row with the new data
                    dataGridView1.Rows[selectedRowIndex].Cells[0].Value = form3.IDNumberInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[1].Value = form3.FirstnameInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[2].Value = form3.MiddlenameInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[3].Value = form3.SurnameInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[4].Value = form3.SpecializationInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = form3.WorkingHoursInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[6].Value = form3.ContactNumberInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[7].Value = form3.AffiliationInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[8].Value = form3.LicenseNumberInput;
                    dataGridView1.Rows[selectedRowIndex].Cells[9].Value = form3.OfficeRoomNumberInput;

                    // Update HashSet
                    idSet.Remove(idNumber);
                    idSet.Add(form3.IDNumberInput);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click_1(object sender, EventArgs e) //delete button
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    // Remove ID from HashSet
                    string idNumber = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    idSet.Remove(idNumber);

                    // Remove row
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
