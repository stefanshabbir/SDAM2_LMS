namespace SDAM2_LMS
{
    partial class LoginPage
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(30, 242);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(121, 32);
            lbl1.TabIndex = 0;
            lbl1.Text = "Username";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(30, 386);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(111, 32);
            lbl2.TabIndex = 1;
            lbl2.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(172, 242);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(475, 39);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(172, 383);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(475, 39);
            textBoxPassword.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(172, 509);
            button1.Name = "button1";
            button1.Size = new Size(205, 46);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 39);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 47);
            label1.Name = "label1";
            label1.Size = new Size(428, 71);
            label1.TabIndex = 6;
            label1.Text = "The Book Vault";
            // 
            // button2
            // 
            button2.Location = new Point(417, 509);
            button2.Name = "button2";
            button2.Size = new Size(206, 46);
            button2.TabIndex = 7;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(700, 900);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button button2;
    }
}