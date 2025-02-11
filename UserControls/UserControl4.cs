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
    public partial class UserControl4 : UserControl
    {
        private Queue<Appointment> appointmentQueue = new Queue<Appointment>();

        public UserControl4()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Patient Name";
            dataGridView1.Columns[1].Name = "Appointment Date";
            dataGridView1.Columns[2].Name = "Appointment Time";
            dataGridView1.Columns[3].Name = "Doctor Name";
            dataGridView1.Columns[4].Name = "Reason for Appointment";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void UserControl4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //add
        {
            Form4 form4 = new Form4();
            form4.EnableAddMode(); // Enable Add mode in Form4

            form4.ShowDialog();

            if (form4.DialogResult == DialogResult.OK)
            {
                // Create a new appointment object from form data
                Appointment newAppointment = new Appointment
                {
                    PatientName = form4.PatientNameInput,
                    AppointmentDate = form4.AppointmentDateInput,
                    AppointmentTime = form4.AppointmentTimeInput,
                    DoctorName = form4.DoctorNameInput,
                    Reason = form4.ReasonInput
                };

                // Enqueue the new appointment
                appointmentQueue.Enqueue(newAppointment);

                // Add the appointment to the DataGridView
                string[] row = {
                    newAppointment.PatientName,
                    newAppointment.AppointmentDate.ToString("MM/dd/yyyy"),
                    newAppointment.AppointmentTime.ToString("hh:mm tt"),
                    newAppointment.DoctorName,
                    newAppointment.Reason
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void button3_Click(object sender, EventArgs e) // edit
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                var appointmentToEdit = new List<Appointment>(appointmentQueue)[selectedRowIndex];

                // Open the form to edit the selected appointment
                Form4 form4 = new Form4();
                form4.EnableEditMode(appointmentToEdit.PatientName, appointmentToEdit.AppointmentDate, appointmentToEdit.AppointmentTime, appointmentToEdit.DoctorName, appointmentToEdit.Reason);

                form4.ShowDialog();

                if (form4.DialogResult == DialogResult.OK)
                {
                    // Update the appointment in the queue with new values
                    appointmentQueue.Dequeue(); // Remove the old appointment

                    Appointment editedAppointment = new Appointment
                    {
                        PatientName = form4.PatientNameInput,
                        AppointmentDate = form4.AppointmentDateInput,
                        AppointmentTime = form4.AppointmentTimeInput,
                        DoctorName = form4.DoctorNameInput,
                        Reason = form4.ReasonInput
                    };

                    // Re-enqueue the updated appointment
                    appointmentQueue.Enqueue(editedAppointment);

                    // Refresh DataGridView to show updated appointments
                    dataGridView1.Rows.Clear();
                    foreach (var appointment in appointmentQueue)
                    {
                        string[] row = {
                            appointment.PatientName,
                            appointment.AppointmentDate.ToString("MM/dd/yyyy"),
                            appointment.AppointmentTime.ToString("hh:mm tt"),
                            appointment.DoctorName,
                            appointment.Reason
                        };
                        dataGridView1.Rows.Add(row);  // Add row
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e) //Edit
        {
            if (appointmentQueue.Count > 0)
            {
                appointmentQueue.Dequeue(); // Remove the earliest appointment from the queue

                // Update the DataGridView by refreshing the display
                dataGridView1.Rows.Clear();
                foreach (var appointment in appointmentQueue)
                {
                    string[] row = {
                        appointment.PatientName,
                        appointment.AppointmentDate.ToString("MM/dd/yyyy"),
                        appointment.AppointmentTime.ToString("hh:mm tt"),
                        appointment.DoctorName,
                        appointment.Reason
                    };
                    dataGridView1.Rows.Add(row);  // Add row
                }
            }
            else
            {
                MessageBox.Show("No appointments to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class Appointment
        {
            public string PatientName { get; set; }
            public DateTime AppointmentDate { get; set; }
            public DateTime AppointmentTime { get; set; }
            public string DoctorName { get; set; }
            public string Reason { get; set; }
        }

    }
}
