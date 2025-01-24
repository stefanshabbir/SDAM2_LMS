namespace SDAM2_LMS.Views
{
    partial class ViewProfile
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
            groupBox1 = new GroupBox();
            EditBtn = new Button();
            UpdateBtn = new Button();
            label1 = new Label();
            addressInput = new TextBox();
            PhoneInput = new TextBox();
            phoneNumberLabel = new Label();
            NameInput = new TextBox();
            usernameLabel = new Label();
            EmailInput = new TextBox();
            UsernameInput = new TextBox();
            lbl2 = new Label();
            lbl1 = new Label();
            groupBox2 = new GroupBox();
            ResetPasswordBtn = new Button();
            DeleteBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(EditBtn);
            groupBox1.Controls.Add(UpdateBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(addressInput);
            groupBox1.Controls.Add(PhoneInput);
            groupBox1.Controls.Add(phoneNumberLabel);
            groupBox1.Controls.Add(NameInput);
            groupBox1.Controls.Add(usernameLabel);
            groupBox1.Controls.Add(EmailInput);
            groupBox1.Controls.Add(UsernameInput);
            groupBox1.Controls.Add(lbl2);
            groupBox1.Controls.Add(lbl1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 248);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(310, 214);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(75, 23);
            EditBtn.TabIndex = 32;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.DialogResult = DialogResult.OK;
            UpdateBtn.Location = new Point(198, 214);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(106, 23);
            UpdateBtn.TabIndex = 31;
            UpdateBtn.Text = "Save Changes";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 137);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 29;
            label1.Text = "Address";
            // 
            // addressInput
            // 
            addressInput.Location = new Point(122, 134);
            addressInput.Margin = new Padding(2, 1, 2, 1);
            addressInput.Name = "addressInput";
            addressInput.ReadOnly = true;
            addressInput.Size = new Size(263, 23);
            addressInput.TabIndex = 28;
            // 
            // PhoneInput
            // 
            PhoneInput.Location = new Point(122, 58);
            PhoneInput.Margin = new Padding(2, 1, 2, 1);
            PhoneInput.Name = "PhoneInput";
            PhoneInput.ReadOnly = true;
            PhoneInput.Size = new Size(263, 23);
            PhoneInput.TabIndex = 27;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(11, 61);
            phoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
            phoneNumberLabel.TabIndex = 26;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // NameInput
            // 
            NameInput.Location = new Point(122, 20);
            NameInput.Margin = new Padding(2, 1, 2, 1);
            NameInput.Name = "NameInput";
            NameInput.ReadOnly = true;
            NameInput.Size = new Size(263, 23);
            NameInput.TabIndex = 25;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(11, 176);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 24;
            usernameLabel.Text = "Username";
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(122, 96);
            EmailInput.Margin = new Padding(2, 1, 2, 1);
            EmailInput.Name = "EmailInput";
            EmailInput.ReadOnly = true;
            EmailInput.Size = new Size(263, 23);
            EmailInput.TabIndex = 21;
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(122, 173);
            UsernameInput.Margin = new Padding(2, 1, 2, 1);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.ReadOnly = true;
            UsernameInput.Size = new Size(263, 23);
            UsernameInput.TabIndex = 20;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(11, 99);
            lbl2.Margin = new Padding(2, 0, 2, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(81, 15);
            lbl2.TabIndex = 17;
            lbl2.Text = "Email Address";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(11, 23);
            lbl1.Margin = new Padding(2, 0, 2, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(39, 15);
            lbl1.TabIndex = 16;
            lbl1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ResetPasswordBtn);
            groupBox2.Controls.Add(DeleteBtn);
            groupBox2.Location = new Point(12, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(411, 55);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            // 
            // ResetPasswordBtn
            // 
            ResetPasswordBtn.FlatStyle = FlatStyle.Flat;
            ResetPasswordBtn.Location = new Point(6, 22);
            ResetPasswordBtn.Name = "ResetPasswordBtn";
            ResetPasswordBtn.Size = new Size(105, 23);
            ResetPasswordBtn.TabIndex = 33;
            ResetPasswordBtn.Text = "Reset Password";
            ResetPasswordBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.DarkRed;
            DeleteBtn.BackgroundImageLayout = ImageLayout.None;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Location = new Point(300, 22);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(105, 23);
            DeleteBtn.TabIndex = 30;
            DeleteBtn.Text = "Delete Account";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ViewProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 354);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ViewProfile";
            Text = "Profile";
            Load += ViewProfile_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox addressInput;
        private TextBox PhoneInput;
        private Label phoneNumberLabel;
        private TextBox NameInput;
        private Label usernameLabel;
        private TextBox EmailInput;
        private TextBox UsernameInput;
        private Label lbl2;
        private Label lbl1;
        private Button UpdateBtn;
        private Button EditBtn;
        private GroupBox groupBox2;
        private Button ResetPasswordBtn;
        private Button DeleteBtn;
    }
}