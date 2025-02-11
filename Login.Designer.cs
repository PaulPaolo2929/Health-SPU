namespace Trial
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            LoginButton = new Button();
            RegisterButton = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(510, 302);
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(396, 48);
            textBoxUsername.TabIndex = 1;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(510, 401);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(396, 48);
            textBoxPassword.TabIndex = 2;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.RoyalBlue;
            LoginButton.FlatStyle = FlatStyle.Popup;
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(510, 500);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(150, 40);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.RoyalBlue;
            RegisterButton.FlatStyle = FlatStyle.Popup;
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(756, 500);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(150, 40);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Pink_Blue_Simple_Elegant_Medical_Logo_removebg_preview_1;
            pictureBox2.Location = new Point(17, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(323, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 650);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 333);
            label2.Name = "label2";
            label2.Size = new Size(350, 207);
            label2.TabIndex = 7;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 226);
            label1.Name = "label1";
            label1.Size = new Size(248, 82);
            label1.TabIndex = 6;
            label1.Text = "Health Service\r\nand Patient Unit";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(532, 56);
            label3.Name = "label3";
            label3.Size = new Size(354, 54);
            label3.TabIndex = 7;
            label3.Text = "EMPLOYEE LOGIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(490, 141);
            label4.Name = "label4";
            label4.Size = new Size(436, 69);
            label4.TabIndex = 8;
            label4.Text = "Good day! You are attempting to log in as an employee.\r\nKindly provide the required information below to continue.\r\nThank you!";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(510, 276);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 9;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(510, 375);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 10;
            label6.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(510, 455);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1046, 645);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button LoginButton;
        private Button RegisterButton;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
    }
}
