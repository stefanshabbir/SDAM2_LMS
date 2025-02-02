namespace SDAM2_LMS
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new Label();
            lbl2 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            LoginBtn = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            RegistrationBtn = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(18, 151);
            lbl1.Margin = new Padding(2, 0, 2, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(75, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "Username";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(18, 241);
            lbl2.Margin = new Padding(2, 0, 2, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(70, 20);
            lbl2.TabIndex = 1;
            lbl2.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(106, 151);
            textBoxUsername.Margin = new Padding(2, 1, 2, 1);
            textBoxUsername.MaxLength = 30;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(294, 27);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(106, 240);
            textBoxPassword.Margin = new Padding(2, 1, 2, 1);
            textBoxPassword.MaxLength = 16;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(294, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(106, 319);
            LoginBtn.Margin = new Padding(2, 1, 2, 1);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(126, 40);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 41);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(2, 27);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 46);
            label1.TabIndex = 6;
            label1.Text = "The Book Vault";
            // 
            // RegistrationBtn
            // 
            RegistrationBtn.Location = new Point(275, 319);
            RegistrationBtn.Margin = new Padding(2, 1, 2, 1);
            RegistrationBtn.Name = "RegistrationBtn";
            RegistrationBtn.Size = new Size(126, 40);
            RegistrationBtn.TabIndex = 7;
            RegistrationBtn.Text = "Sign Up";
            RegistrationBtn.UseVisualStyleBackColor = true;
            RegistrationBtn.Click += RegistrationBtn_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(431, 492);
            Controls.Add(RegistrationBtn);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(LoginBtn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "LoginPage";
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private TextBox txt1;
        private TextBox txt2;
        private Button LoginBtn;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button RegistrationBtn;
    }
}