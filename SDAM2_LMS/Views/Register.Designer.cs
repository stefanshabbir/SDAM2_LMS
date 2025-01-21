namespace SDAM2_LMS
{
    partial class Register
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
            lbl3 = new Label();
            lbl4 = new Label();
            UsernameInput = new TextBox();
            EmailInput = new TextBox();
            PasswordInput = new TextBox();
            ConfirmPasswordInput = new TextBox();
            RegisterBtn = new Button();
            title = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(28, 79);
            lbl1.Margin = new Padding(2, 0, 2, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(39, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Name";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(28, 145);
            lbl2.Margin = new Padding(2, 0, 2, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(81, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "Email Address";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(28, 214);
            lbl3.Margin = new Padding(2, 0, 2, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(57, 15);
            lbl3.TabIndex = 2;
            lbl3.Text = "Password";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(28, 280);
            lbl4.Margin = new Padding(2, 0, 2, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(104, 15);
            lbl4.TabIndex = 3;
            lbl4.Text = "Confirm Password";
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(149, 79);
            UsernameInput.Margin = new Padding(2, 1, 2, 1);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(245, 23);
            UsernameInput.TabIndex = 4;
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(149, 143);
            EmailInput.Margin = new Padding(2, 1, 2, 1);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(245, 23);
            EmailInput.TabIndex = 5;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(149, 211);
            PasswordInput.Margin = new Padding(2, 1, 2, 1);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(245, 23);
            PasswordInput.TabIndex = 6;
            // 
            // ConfirmPasswordInput
            // 
            ConfirmPasswordInput.Location = new Point(149, 277);
            ConfirmPasswordInput.Margin = new Padding(2, 1, 2, 1);
            ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            ConfirmPasswordInput.Size = new Size(245, 23);
            ConfirmPasswordInput.TabIndex = 7;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(429, 340);
            RegisterBtn.Margin = new Padding(2, 1, 2, 1);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(81, 22);
            RegisterBtn.TabIndex = 8;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Arial Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(197, 4);
            title.Margin = new Padding(2, 0, 2, 0);
            title.Name = "title";
            title.Size = new Size(136, 38);
            title.TabIndex = 9;
            title.Text = "Sign up ";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 369);
            Controls.Add(title);
            Controls.Add(RegisterBtn);
            Controls.Add(ConfirmPasswordInput);
            Controls.Add(PasswordInput);
            Controls.Add(EmailInput);
            Controls.Add(UsernameInput);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private TextBox UsernameInput;
        private TextBox EmailInput;
        private TextBox PasswordInput;
        private TextBox ConfirmPasswordInput;
        private Button RegisterBtn;
        private Label title;
    }
}