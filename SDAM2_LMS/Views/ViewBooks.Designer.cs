namespace SDAM2_LMS
{
    partial class ViewBooks
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
            btn_Refresh = new Button();
            BorrowBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooksView).BeginInit();
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
            SearchInput.Size = new Size(262, 23);
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
            dataGridViewBooksView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooksView.Size = new Size(859, 280);
            dataGridViewBooksView.TabIndex = 4;
            dataGridViewBooksView.SelectionChanged += DataGridViewBooksView_SelectionChanged;
            // 
            // btn_Refresh
            // 
            btn_Refresh.Location = new Point(634, 103);
            btn_Refresh.Margin = new Padding(2, 1, 2, 1);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(81, 22);
            btn_Refresh.TabIndex = 19;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = true;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // BorrowBtn
            // 
            BorrowBtn.Location = new Point(792, 435);
            BorrowBtn.Margin = new Padding(2, 1, 2, 1);
            BorrowBtn.Name = "BorrowBtn";
            BorrowBtn.Size = new Size(81, 22);
            BorrowBtn.TabIndex = 20;
            BorrowBtn.Text = "Borrow";
            BorrowBtn.UseVisualStyleBackColor = true;
            BorrowBtn.Click += BorrowBtn_Click;
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 467);
            Controls.Add(BorrowBtn);
            Controls.Add(btn_Refresh);
            Controls.Add(dataGridViewBooksView);
            Controls.Add(SearchInput);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            Name = "ViewBooks";
            Load += ViewBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooksView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox SearchInput;
        private DataGridView dataGridViewBooksView;
        private Button btn_Refresh;
        private Button BorrowBtn;
    }
}