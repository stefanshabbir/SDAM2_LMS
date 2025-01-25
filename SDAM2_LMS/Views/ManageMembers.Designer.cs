namespace SDAM2_LMS
{
    partial class ManageMembers
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            SearchInput = new TextBox();
            DataGridViewBooksView = new DataGridView();
            panel2 = new Panel();
            inptAddress = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            inptUsername = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            inptAccountType = new TextBox();
            inptPhoneNumber = new TextBox();
            inptEmail = new TextBox();
            inptName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btn_Refresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBooksView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 91);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 37);
            label1.TabIndex = 0;
            label1.Text = "View Members";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 109);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Search Name";
            // 
            // SearchInput
            // 
            SearchInput.Location = new Point(395, 106);
            SearchInput.Margin = new Padding(2, 1, 2, 1);
            SearchInput.Name = "SearchInput";
            SearchInput.Size = new Size(234, 23);
            SearchInput.TabIndex = 2;
            // 
            // DataGridViewBooksView
            // 
            DataGridViewBooksView.AllowUserToAddRows = false;
            DataGridViewBooksView.AllowUserToDeleteRows = false;
            DataGridViewBooksView.AllowUserToResizeColumns = false;
            DataGridViewBooksView.AllowUserToResizeRows = false;
            DataGridViewBooksView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewBooksView.BackgroundColor = Color.Silver;
            DataGridViewBooksView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewBooksView.Location = new Point(14, 142);
            DataGridViewBooksView.Margin = new Padding(2, 1, 2, 1);
            DataGridViewBooksView.MultiSelect = false;
            DataGridViewBooksView.Name = "DataGridViewBooksView";
            DataGridViewBooksView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGridViewBooksView.Size = new Size(959, 280);
            DataGridViewBooksView.TabIndex = 4;
            DataGridViewBooksView.SelectionChanged += DataGridViewBooksView_SelectionChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(inptAddress);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(inptUsername);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(inptAccountType);
            panel2.Controls.Add(inptPhoneNumber);
            panel2.Controls.Add(inptEmail);
            panel2.Controls.Add(inptName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(14, 427);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 184);
            panel2.TabIndex = 5;
            // 
            // inptAddress
            // 
            inptAddress.Location = new Point(665, 100);
            inptAddress.Margin = new Padding(2, 1, 2, 1);
            inptAddress.Name = "inptAddress";
            inptAddress.Size = new Size(217, 23);
            inptAddress.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(479, 100);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 20;
            label3.Text = "Address";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(279, 144);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 30);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // inptUsername
            // 
            inptUsername.Location = new Point(665, 14);
            inptUsername.Margin = new Padding(2, 1, 2, 1);
            inptUsername.Name = "inptUsername";
            inptUsername.Size = new Size(217, 23);
            inptUsername.TabIndex = 16;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(579, 144);
            btnClear.Margin = new Padding(2, 1, 2, 1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 30);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(479, 144);
            btnDelete.Margin = new Padding(2, 1, 2, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 30);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(379, 144);
            btnUpdate.Margin = new Padding(2, 1, 2, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 30);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // inptAccountType
            // 
            inptAccountType.Location = new Point(665, 55);
            inptAccountType.Margin = new Padding(2, 1, 2, 1);
            inptAccountType.Name = "inptAccountType";
            inptAccountType.Size = new Size(217, 23);
            inptAccountType.TabIndex = 11;
            // 
            // inptPhoneNumber
            // 
            inptPhoneNumber.Location = new Point(226, 102);
            inptPhoneNumber.Margin = new Padding(2, 1, 2, 1);
            inptPhoneNumber.Name = "inptPhoneNumber";
            inptPhoneNumber.Size = new Size(237, 23);
            inptPhoneNumber.TabIndex = 9;
            // 
            // inptEmail
            // 
            inptEmail.Location = new Point(226, 59);
            inptEmail.Margin = new Padding(2, 1, 2, 1);
            inptEmail.Name = "inptEmail";
            inptEmail.Size = new Size(237, 23);
            inptEmail.TabIndex = 8;
            // 
            // inptName
            // 
            inptName.Location = new Point(226, 12);
            inptName.Margin = new Padding(2, 1, 2, 1);
            inptName.Name = "inptName";
            inptName.Size = new Size(237, 23);
            inptName.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(479, 57);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 5;
            label8.Text = "Account Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(477, 14);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 21);
            label7.TabIndex = 4;
            label7.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(60, 100);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 3;
            label6.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(60, 58);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 14);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 0;
            label4.Text = "Name";
            // 
            // btn_Refresh
            // 
            btn_Refresh.Location = new Point(679, 101);
            btn_Refresh.Margin = new Padding(2, 1, 2, 1);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(85, 30);
            btn_Refresh.TabIndex = 19;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = true;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // ManageMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 621);
            Controls.Add(btn_Refresh);
            Controls.Add(panel2);
            Controls.Add(DataGridViewBooksView);
            Controls.Add(SearchInput);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            Name = "ManageMembers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBooksView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox SearchInput;
        private DataGridView DataGridViewBooksView;
        private Panel panel2;
        private TextBox GenreTextBox;
        private TextBox inptAccountType;
        private TextBox inptPhoneNumber;
        private TextBox inptEmail;
        private TextBox inptName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox inptUsername;
        private Button btn_Refresh;
        private Button btnAdd;
        private TextBox inptAddress;
        private Label label3;
    }
}