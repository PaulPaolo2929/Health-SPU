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
    public partial class UserControl5 : UserControl
    {
        private LinkedList<MedicalRecord> medicalHistory = new LinkedList<MedicalRecord>();
        private int selectedIndex = -1;

        public UserControl5()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Doctor's Name";
            dataGridView1.Columns[1].Name = "Treatment Type";
            dataGridView1.Columns[2].Name = "Patient Name";
            dataGridView1.Columns[3].Name = "Diagnosis/Condition";
            dataGridView1.Columns[4].Name = "Medication";
            dataGridView1.Columns[5].Name = "Remarks";
            dataGridView1.Columns[6].Name = "Date";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.EnableAddMode();
            form5.ShowDialog();

            if (form5.DialogResult == DialogResult.OK)
            {
                var record = new MedicalRecord(
                    form5.DoctorNameInput,
                    form5.TreatmentTypeInput,
                    form5.PatientNameInput,
                    form5.DiagnosisInput,
                    form5.MedicationInput,
                    form5.RemarksInput,
                    form5.DateInput
                );
                medicalHistory.AddLast(record);
                AddRecordToDataGridView(record);
            }
        }
        private void AddRecordToDataGridView(MedicalRecord record)
        {
            dataGridView1.Rows.Add(record.DoctorName, record.TreatmentType, record.PatientName, record.Diagnosis, record.Medication, record.Remarks, record.Date);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete the selected record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    var selectedNode = GetNodeByIndex(selectedIndex);
                    medicalHistory.Remove(selectedNode);
                    UpdateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedIndex = dataGridView1.SelectedRows[0].Index;
                var selectedNode = GetNodeByIndex(selectedIndex);

                Form5 form5 = new Form5();
                form5.EnableEditMode(
                    selectedNode.Value.DoctorName,
                    selectedNode.Value.TreatmentType,
                    selectedNode.Value.PatientName,
                    selectedNode.Value.Diagnosis,
                    selectedNode.Value.Medication,
                    selectedNode.Value.Remarks,
                    selectedNode.Value.Date
                );
                form5.ShowDialog();

                if (form5.DialogResult == DialogResult.OK)
                {
                    selectedNode.Value = new MedicalRecord(
                        form5.DoctorNameInput,
                        form5.TreatmentTypeInput,
                        form5.PatientNameInput,
                        form5.DiagnosisInput,
                        form5.MedicationInput,
                        form5.RemarksInput,
                        form5.DateInput
                    );
                    UpdateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private LinkedListNode<MedicalRecord> GetNodeByIndex(int index)
        {
            var currentNode = medicalHistory.First;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var record in medicalHistory)
            {
                AddRecordToDataGridView(record);
            }
        }
        public class MedicalRecord
        {
            public string DoctorName { get; }
            public string TreatmentType { get; }
            public string PatientName { get; }
            public string Diagnosis { get; }
            public string Medication { get; }
            public string Remarks { get; }
            public string Date { get; }

            public MedicalRecord(string doctorName, string treatmentType, string patientName, string diagnosis, string medication, string remarks, string date)
            {
                DoctorName = doctorName;
                TreatmentType = treatmentType;
                PatientName = patientName;
                Diagnosis = diagnosis;
                Medication = medication;
                Remarks = remarks;
                Date = date;
            }
        }
    }
}
