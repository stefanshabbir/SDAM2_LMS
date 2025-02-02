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
            usernameLabel = new Label();
            NameInput = new TextBox();
            phoneNumberLabel = new Label();
            PhoneInput = new TextBox();
            addressInput = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(32, 105);
            lbl1.Margin = new Padding(2, 0, 2, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(49, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "Name";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(32, 193);
            lbl2.Margin = new Padding(2, 0, 2, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(103, 20);
            lbl2.TabIndex = 1;
            lbl2.Text = "Email Address";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(32, 369);
            lbl3.Margin = new Padding(2, 0, 2, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(70, 20);
            lbl3.TabIndex = 2;
            lbl3.Text = "Password";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(32, 415);
            lbl4.Margin = new Padding(2, 0, 2, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(127, 20);
            lbl4.TabIndex = 3;
            lbl4.Text = "Confirm Password";
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(170, 320);
            UsernameInput.Margin = new Padding(2, 1, 2, 1);
            UsernameInput.MaxLength = 30;
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(279, 27);
            UsernameInput.TabIndex = 4;
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(170, 191);
            EmailInput.Margin = new Padding(2, 1, 2, 1);
            EmailInput.MaxLength = 100;
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(279, 27);
            EmailInput.TabIndex = 5;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(170, 365);
            PasswordInput.Margin = new Padding(2, 1, 2, 1);
            PasswordInput.MaxLength = 16;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(279, 27);
            PasswordInput.TabIndex = 6;
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // ConfirmPasswordInput
            // 
            ConfirmPasswordInput.Location = new Point(170, 411);
            ConfirmPasswordInput.Margin = new Padding(2, 1, 2, 1);
            ConfirmPasswordInput.MaxLength = 16;
            ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            ConfirmPasswordInput.Size = new Size(279, 27);
            ConfirmPasswordInput.TabIndex = 7;
            ConfirmPasswordInput.UseSystemPasswordChar = true;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(490, 439);
            RegisterBtn.Margin = new Padding(2, 1, 2, 1);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(97, 40);
            RegisterBtn.TabIndex = 8;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Arial Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(225, 5);
            title.Margin = new Padding(2, 0, 2, 0);
            title.Name = "title";
            title.Size = new Size(170, 48);
            title.TabIndex = 9;
            title.Text = "Sign up ";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(32, 324);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 10;
            usernameLabel.Text = "Username";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(170, 101);
            NameInput.Margin = new Padding(2, 1, 2, 1);
            NameInput.MaxLength = 50;
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(279, 27);
            NameInput.TabIndex = 11;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(32, 152);
            phoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(108, 20);
            phoneNumberLabel.TabIndex = 12;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // PhoneInput
            // 
            PhoneInput.Location = new Point(170, 148);
            PhoneInput.Margin = new Padding(2, 1, 2, 1);
            PhoneInput.MaxLength = 15;
            PhoneInput.Name = "PhoneInput";
            PhoneInput.Size = new Size(279, 27);
            PhoneInput.TabIndex = 13;
            // 
            // addressInput
            // 
            addressInput.Location = new Point(170, 239);
            addressInput.Margin = new Padding(2, 1, 2, 1);
            addressInput.MaxLength = 200;
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(279, 27);
            addressInput.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 243);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 15;
            label1.Text = "Address";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 492);
            Controls.Add(label1);
            Controls.Add(addressInput);
            Controls.Add(PhoneInput);
            Controls.Add(phoneNumberLabel);
            Controls.Add(NameInput);
            Controls.Add(usernameLabel);
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
        private Label usernameLabel;
        private TextBox NameInput;
        private Label phoneNumberLabel;
        private TextBox PhoneInput;
        private TextBox addressInput;
        private Label label1;
    }
}