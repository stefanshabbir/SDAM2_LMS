namespace SDAM2_LMS
{
    partial class ManageBooks
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
            dataGridViewBooksView = new DataGridView();
            panel2 = new Panel();
            btn_Add = new Button();
            LanguageTextBox = new TextBox();
            label10 = new Label();
            ISBNTextBox = new TextBox();
            btn_Clear = new Button();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            GenreTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            PublisherTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            TitleTextBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btn_Refresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooksView).BeginInit();
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
            panel1.Size = new Size(882, 91);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(359, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 0;
            label1.Text = "View Books";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 107);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // SearchInput
            // 
            SearchInput.Location = new Point(326, 104);
            SearchInput.Margin = new Padding(2, 1, 2, 1);
            SearchInput.Name = "SearchInput";
            SearchInput.Size = new Size(234, 23);
            SearchInput.TabIndex = 2;
            // 
            // dataGridViewBooksView
            // 
            dataGridViewBooksView.AllowUserToAddRows = false;
            dataGridViewBooksView.AllowUserToDeleteRows = false;
            dataGridViewBooksView.AllowUserToResizeColumns = false;
            dataGridViewBooksView.AllowUserToResizeRows = false;
            dataGridViewBooksView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooksView.BackgroundColor = Color.Silver;
            dataGridViewBooksView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooksView.Location = new Point(14, 142);
            dataGridViewBooksView.Margin = new Padding(2, 1, 2, 1);
            dataGridViewBooksView.MultiSelect = false;
            dataGridViewBooksView.Name = "dataGridViewBooksView";
            dataGridViewBooksView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewBooksView.Size = new Size(859, 280);
            dataGridViewBooksView.TabIndex = 4;
            dataGridViewBooksView.SelectionChanged += DataGridViewBooksView_SelectionChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(btn_Add);
            panel2.Controls.Add(LanguageTextBox);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(ISBNTextBox);
            panel2.Controls.Add(btn_Clear);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(UpdateBtn);
            panel2.Controls.Add(GenreTextBox);
            panel2.Controls.Add(QuantityTextBox);
            panel2.Controls.Add(PublisherTextBox);
            panel2.Controls.Add(AuthorTextBox);
            panel2.Controls.Add(TitleTextBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(14, 433);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(859, 238);
            panel2.TabIndex = 5;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(462, 191);
            btn_Add.Margin = new Padding(2, 1, 2, 1);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(85, 30);
            btn_Add.TabIndex = 19;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // LanguageTextBox
            // 
            LanguageTextBox.Location = new Point(177, 196);
            LanguageTextBox.Margin = new Padding(2, 1, 2, 1);
            LanguageTextBox.Name = "LanguageTextBox";
            LanguageTextBox.Size = new Size(237, 23);
            LanguageTextBox.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(11, 196);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(78, 21);
            label10.TabIndex = 17;
            label10.Text = "Language";
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Location = new Point(624, 19);
            ISBNTextBox.Margin = new Padding(2, 1, 2, 1);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.Size = new Size(217, 23);
            ISBNTextBox.TabIndex = 16;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(762, 191);
            btn_Clear.Margin = new Padding(2, 1, 2, 1);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(85, 30);
            btn_Clear.TabIndex = 15;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(662, 191);
            DeleteBtn.Margin = new Padding(2, 1, 2, 1);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(85, 30);
            DeleteBtn.TabIndex = 14;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(562, 191);
            UpdateBtn.Margin = new Padding(2, 1, 2, 1);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(85, 30);
            UpdateBtn.TabIndex = 13;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(620, 138);
            GenreTextBox.Margin = new Padding(2, 1, 2, 1);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(221, 23);
            GenreTextBox.TabIndex = 12;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(620, 78);
            QuantityTextBox.Margin = new Padding(2, 1, 2, 1);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(217, 23);
            QuantityTextBox.TabIndex = 11;
            // 
            // PublisherTextBox
            // 
            PublisherTextBox.Location = new Point(177, 146);
            PublisherTextBox.Margin = new Padding(2, 1, 2, 1);
            PublisherTextBox.Name = "PublisherTextBox";
            PublisherTextBox.Size = new Size(237, 23);
            PublisherTextBox.TabIndex = 9;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(177, 80);
            AuthorTextBox.Margin = new Padding(2, 1, 2, 1);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(237, 23);
            AuthorTextBox.TabIndex = 8;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(177, 13);
            TitleTextBox.Margin = new Padding(2, 1, 2, 1);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(237, 23);
            TitleTextBox.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(430, 135);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 6;
            label9.Text = "Genre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(430, 78);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 5;
            label8.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(428, 17);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 21);
            label7.TabIndex = 4;
            label7.Text = "ISBN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(11, 142);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 21);
            label6.TabIndex = 3;
            label6.Text = "Book Publication";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(11, 79);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(143, 21);
            label5.TabIndex = 1;
            label5.Text = "Book Author Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 15);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 0;
            label4.Text = "Book Name";
            // 
            // btn_Refresh
            // 
            btn_Refresh.Location = new Point(623, 99);
            btn_Refresh.Margin = new Padding(2, 1, 2, 1);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(85, 30);
            btn_Refresh.TabIndex = 19;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = true;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // ManageBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 674);
            Controls.Add(btn_Refresh);
            Controls.Add(panel2);
            Controls.Add(dataGridViewBooksView);
            Controls.Add(SearchInput);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            Name = "ManageBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooksView).EndInit();
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
        private DataGridView dataGridViewBooksView;
        private Panel panel2;
        private TextBox GenreTextBox;
        private TextBox QuantityTextBox;
        private TextBox PublisherTextBox;
        private TextBox AuthorTextBox;
        private TextBox TitleTextBox;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btn_Clear;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private TextBox ISBNTextBox;
        private TextBox LanguageTextBox;
        private Label label10;
        private Button btn_Refresh;
        private Button btn_Add;
    }
}