
namespace Trial
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lblPatientCount = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            label11 = new Label();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            label15 = new Label();
            pictureBox6 = new PictureBox();
            label14 = new Label();
            panel6 = new Panel();
            label13 = new Label();
            label12 = new Label();
            pictureBox5 = new PictureBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 285);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 17);
            label2.Name = "label2";
            label2.Size = new Size(244, 31);
            label2.TabIndex = 1;
            label2.Text = "ADMIN DASHBOARD";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 48);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 2;
            label3.Text = "Home / Admin";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblPatientCount);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(19, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 170);
            panel1.TabIndex = 3;
            // 
            // lblPatientCount
            // 
            lblPatientCount.AutoSize = true;
            lblPatientCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientCount.Location = new Point(140, 65);
            lblPatientCount.Name = "lblPatientCount";
            lblPatientCount.Size = new Size(46, 54);
            lblPatientCount.TabIndex = 3;
            lblPatientCount.Text = "0";
            lblPatientCount.Click += lblPatientCount_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 125);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 2;
            label5.Text = "Total Patient";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 10);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 1;
            label4.Text = "PATIENTS";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Nurse_Assistant_Emergency;
            pictureBox1.Location = new Point(15, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(271, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 170);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(109, 125);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 5;
            label7.Text = "Total Doctors";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(59, 10);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 4;
            label6.Text = "DOCTORS";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Stethoscope;
            pictureBox2.Location = new Point(14, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(527, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 170);
            panel3.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(87, 125);
            label9.Name = "label9";
            label9.Size = new Size(134, 20);
            label9.TabIndex = 2;
            label9.Text = "Total Appointment";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(35, 10);
            label8.Name = "label8";
            label8.Size = new Size(157, 28);
            label8.TabIndex = 1;
            label8.Text = "APPOINTMENT";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Online_Medical_Service_Monitor;
            pictureBox3.Location = new Point(12, 65);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(19, 295);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 170);
            panel4.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(102, 124);
            label11.Name = "label11";
            label11.Size = new Size(113, 20);
            label11.TabIndex = 2;
            label11.Text = "Total Treatment";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(48, 10);
            label10.Name = "label10";
            label10.Size = new Size(131, 28);
            label10.TabIndex = 1;
            label10.Text = "TREATMENT";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Blood_Bag_Donation;
            pictureBox4.Location = new Point(15, 64);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 80);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label20);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(label14);
            panel5.Location = new Point(527, 295);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 170);
            panel5.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(96, 125);
            label15.Name = "label15";
            label15.Size = new Size(124, 20);
            label15.TabIndex = 9;
            label15.Text = "Total Prescription";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Nurse_Hat;
            pictureBox6.Location = new Point(12, 64);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(80, 80);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(33, 10);
            label14.Name = "label14";
            label14.Size = new Size(162, 28);
            label14.TabIndex = 8;
            label14.Text = "PRESCRIPTIONS";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label19);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(pictureBox5);
            panel6.Location = new Point(271, 295);
            panel6.Name = "panel6";
            panel6.Size = new Size(225, 170);
            panel6.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(99, 125);
            label13.Name = "label13";
            label13.Size = new Size(119, 20);
            label13.TabIndex = 2;
            label13.Text = "Total Emergency";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(48, 10);
            label12.Name = "label12";
            label12.Size = new Size(131, 28);
            label12.TabIndex = 1;
            label12.Text = "EMERGENCY";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Ambulance;
            pictureBox5.Location = new Point(14, 64);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(80, 80);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(133, 65);
            label16.Name = "label16";
            label16.Size = new Size(46, 54);
            label16.TabIndex = 6;
            label16.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(131, 65);
            label17.Name = "label17";
            label17.Size = new Size(46, 54);
            label17.TabIndex = 3;
            label17.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(140, 70);
            label18.Name = "label18";
            label18.Size = new Size(46, 54);
            label18.TabIndex = 3;
            label18.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(133, 70);
            label19.Name = "label19";
            label19.Size = new Size(46, 54);
            label19.TabIndex = 3;
            label19.Text = "0";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(131, 70);
            label20.Name = "label20";
            label20.Size = new Size(46, 54);
            label20.TabIndex = 10;
            label20.Text = "0";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(785, 645);
            Load += UserControl1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Label label14;
        private Label label15;
        private Panel panel6;
        private PictureBox pictureBox5;
        private Label label13;
        private Label label12;
        private Label lblPatientCount;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label20;
        private Label label19;
    }
}
