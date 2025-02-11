using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Trial.UserControls;

namespace Trial
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl;

        public Form1()
        {
            InitializeComponent();
            initializeNavigationControl(); // Call this method in the constructor
            UserControl1 dashboardControl = new UserControl1();
            UserControl2 patientControl = new UserControl2();

            // Add both controls to the form or panel
            this.Controls.Add(dashboardControl);
            this.Controls.Add(patientControl);
        }

        private void initializeNavigationControl()
        {
            // Initialize the list of UserControls
            List<UserControl> userControls = new List<UserControl>   //USING LINKEDLIST
            {
                new UserControl1(), //Dashboard
                new UserControl2(), //Patients
                new UserControl3(), //Doctors
                new UserControl4(), //Appointment Queue
                new UserControl5(), //Medical History
                new UserControl6(), //Emergency Handling
                new UserControl7(), //Recent Prescription
                new UserControl8(), //Logout

            };

            // Initialize the NavigationControl with the list and panel
            navigationControl = new NavigationControl(userControls, panel2);
            navigationControl.Display(0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Remove if not needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            navigationControl.Display(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            navigationControl.Display(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
