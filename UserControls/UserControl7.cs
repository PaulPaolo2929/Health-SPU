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
    public partial class UserControl7 : UserControl
    {
        private Stack<Prescription> prescriptionsStack = new Stack<Prescription>();

        public UserControl7()
        {
            InitializeComponent();
            InitializeDataGridView(); // Set up the data grid
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Date";
            dataGridView1.Columns[2].Name = "Medication";
            dataGridView1.Columns[3].Name = "Dosage";
            dataGridView1.Columns[4].Name = "Frequency";
            dataGridView1.Columns[5].Name = "Notes";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UserControl7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //add
        {
            Form7 form7 = new Form7();
            form7.EnableAddMode(); // Enable Add mode in Form7

            form7.ShowDialog();

            if (form7.DialogResult == DialogResult.OK)
            {
                // Create new prescription object from form data
                Prescription newPrescription = new Prescription
                {
                    Name = form7.NameInput,
                    Date = form7.DateInput,
                    Medication = form7.MedicationInput,
                    Dosage = form7.DosageInput,
                    Frequency = form7.FrequencyInput,
                    Notes = form7.NotesInput
                };

                // Push the new prescription onto the stack
                prescriptionsStack.Push(newPrescription);

                // Add the prescription to the DataGridView
                string[] row = {
                    newPrescription.Name,
                    newPrescription.Date.ToString("MM/dd/yyyy"),
                    newPrescription.Medication,
                    newPrescription.Dosage,
                    newPrescription.Frequency,
                    newPrescription.Notes
                };
                dataGridView1.Rows.Insert(0, row);  // Add new row at the top
            }
        }

        private void button2_Click(object sender, EventArgs e) //EDIT
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                Prescription selectedPrescription = prescriptionsStack.ToArray()[selectedRowIndex];

                Form7 form7 = new Form7();
                form7.EnableEditMode(selectedPrescription);

                form7.ShowDialog();

                if (form7.DialogResult == DialogResult.OK)
                {
                    // Update the prescription data in the stack
                    prescriptionsStack.Pop();
                    Prescription updatedPrescription = new Prescription
                    {
                        Name = form7.NameInput,
                        Date = form7.DateInput,
                        Medication = form7.MedicationInput,
                        Dosage = form7.DosageInput,
                        Frequency = form7.FrequencyInput,
                        Notes = form7.NotesInput
                    };

                    prescriptionsStack.Push(updatedPrescription);

                    // Update the DataGridView with the edited data
                    dataGridView1.Rows.Clear();
                    foreach (var prescription in prescriptionsStack)
                    {
                        string[] row = {
                            prescription.Name,
                            prescription.Date.ToString("MM/dd/yyyy"),
                            prescription.Medication,
                            prescription.Dosage,
                            prescription.Frequency,
                            prescription.Notes
                        };
                        dataGridView1.Rows.Insert(0, row);  // Add updated row at the top
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e) //DELETE
        {
            if (prescriptionsStack.Count > 0)
            {
                prescriptionsStack.Pop(); // Remove the top-most prescription from the stack

                // Update the DataGridView by refreshing the display
                dataGridView1.Rows.Clear();
                foreach (var prescription in prescriptionsStack)
                {
                    string[] row = {
                        prescription.Name,
                        prescription.Date.ToString("MM/dd/yyyy"),
                        prescription.Medication,
                        prescription.Dosage,
                        prescription.Frequency,
                        prescription.Notes
                    };
                    dataGridView1.Rows.Insert(0, row);  // Add row at the top
                }
            }
            else
            {
                MessageBox.Show("No prescriptions to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class Prescription
        {
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public string Medication { get; set; }
            public string Dosage { get; set; }
            public string Frequency { get; set; }
            public string Notes { get; set; }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
