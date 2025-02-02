namespace SDAM2_LMS
{
    partial class AddUser
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
            btnConfirm = new Button();
            title = new Label();
            usernameLabel = new Label();
            NameInput = new TextBox();
            phoneNumberLabel = new Label();
            PhoneInput = new TextBox();
            addressInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnClear = new Button();
            inputAccountType = new ComboBox();
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
            lbl3.Location = new Point(28, 277);
            lbl3.Margin = new Padding(2, 0, 2, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(57, 15);
            lbl3.TabIndex = 2;
            lbl3.Text = "Password";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(28, 311);
            lbl4.Margin = new Padding(2, 0, 2, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(104, 15);
            lbl4.TabIndex = 3;
            lbl4.Text = "Confirm Password";
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(149, 240);
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
            PasswordInput.Location = new Point(149, 274);
            PasswordInput.Margin = new Padding(2, 1, 2, 1);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(245, 23);
            PasswordInput.TabIndex = 6;
            PasswordInput.UseSystemPasswordChar = true;
            // 
            // ConfirmPasswordInput
            // 
            ConfirmPasswordInput.Location = new Point(149, 308);
            ConfirmPasswordInput.Margin = new Padding(2, 1, 2, 1);
            ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            ConfirmPasswordInput.Size = new Size(245, 23);
            ConfirmPasswordInput.TabIndex = 7;
            ConfirmPasswordInput.UseSystemPasswordChar = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(149, 410);
            btnConfirm.Margin = new Padding(2, 1, 2, 1);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(85, 30);
            btnConfirm.TabIndex = 8;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Arial Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(149, 9);
            title.Margin = new Padding(2, 0, 2, 0);
            title.Name = "title";
            title.Size = new Size(201, 38);
            title.TabIndex = 9;
            title.Text = "Add Member";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(28, 243);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 10;
            usernameLabel.Text = "Username";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(149, 76);
            NameInput.Margin = new Padding(2, 1, 2, 1);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(245, 23);
            NameInput.TabIndex = 11;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(28, 114);
            phoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
            phoneNumberLabel.TabIndex = 12;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // PhoneInput
            // 
            PhoneInput.Location = new Point(149, 111);
            PhoneInput.Margin = new Padding(2, 1, 2, 1);
            PhoneInput.Name = "PhoneInput";
            PhoneInput.Size = new Size(245, 23);
            PhoneInput.TabIndex = 13;
            // 
            // addressInput
            // 
            addressInput.Location = new Point(149, 179);
            addressInput.Margin = new Padding(2, 1, 2, 1);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(245, 23);
            addressInput.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 182);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 15;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 370);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 16;
            label2.Text = "Account Type";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(309, 410);
            btnClear.Margin = new Padding(2, 1, 2, 1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 30);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // inputAccountType
            // 
            inputAccountType.FormattingEnabled = true;
            inputAccountType.Location = new Point(149, 367);
            inputAccountType.Name = "inputAccountType";
            inputAccountType.Size = new Size(245, 23);
            inputAccountType.TabIndex = 23;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(inputAccountType);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addressInput);
            Controls.Add(PhoneInput);
            Controls.Add(phoneNumberLabel);
            Controls.Add(NameInput);
            Controls.Add(usernameLabel);
            Controls.Add(title);
            Controls.Add(btnConfirm);
            Controls.Add(ConfirmPasswordInput);
            Controls.Add(PasswordInput);
            Controls.Add(EmailInput);
            Controls.Add(UsernameInput);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 1, 2, 1);
            Name = "AddUser";
            Load += AddUser_Load;
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
        private Button btnConfirm;
        private Label title;
        private Label usernameLabel;
        private TextBox NameInput;
        private Label phoneNumberLabel;
        private TextBox PhoneInput;
        private TextBox addressInput;
        private Label label1;
        private Label label2;
        private Button btnClear;
        private ComboBox inputAccountType;
    }
}