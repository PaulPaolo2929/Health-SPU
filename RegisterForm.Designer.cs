namespace Trial
{
    partial class RegisterForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            RegisterButton = new Button();
            CancelButton = new Button();
            textBoxConfirmPassword = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(510, 261);
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(396, 48);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(510, 345);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(396, 48);
            textBoxPassword.TabIndex = 1;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.RoyalBlue;
            RegisterButton.FlatStyle = FlatStyle.Popup;
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(756, 500);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(150, 40);
            RegisterButton.TabIndex = 2;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Red;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(510, 500);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(150, 40);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Back";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(510, 424);
            textBoxConfirmPassword.Multiline = true;
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(396, 48);
            textBoxConfirmPassword.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 650);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 333);
            label2.Name = "label2";
            label2.Size = new Size(350, 207);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 226);
            label1.Name = "label1";
            label1.Size = new Size(248, 82);
            label1.TabIndex = 1;
            label1.Text = "Health Service\r\nand Patient Unit";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pink_Blue_Simple_Elegant_Medical_Logo_removebg_preview_1;
            pictureBox1.Location = new Point(17, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(448, 56);
            label3.Name = "label3";
            label3.Size = new Size(514, 54);
            label3.TabIndex = 6;
            label3.Text = "EMPLOYEE REGISTRATION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(490, 141);
            label4.Name = "label4";
            label4.Size = new Size(436, 69);
            label4.TabIndex = 7;
            label4.Text = "Good day! You are attempting to register as an employee.\r\nKindly provide the required information below to continue.\r\nThank you!\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(510, 235);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 8;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(510, 319);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 9;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(509, 398);
            label7.Name = "label7";
            label7.Size = new Size(146, 23);
            label7.TabIndex = 10;
            label7.Text = "Confirm Password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1046, 645);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(CancelButton);
            Controls.Add(RegisterButton);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button RegisterButton;
        private Button CancelButton;
        private TextBox textBoxConfirmPassword;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}