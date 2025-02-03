namespace SDAM2_LMS
{
    partial class ManageReservations
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            borrowedBooksDataGrid = new DataGridView();
            tabControl1 = new TabControl();
            BorrowedBooksTab = new TabPage();
            ReservedBooksTab = new TabPage();
            ReservedBooksDataGrid = new DataGridView();
            borrowDateInput = new DateTimePicker();
            Update = new Button();
            ((System.ComponentModel.ISupportInitialize)borrowedBooksDataGrid).BeginInit();
            tabControl1.SuspendLayout();
            BorrowedBooksTab.SuspendLayout();
            ReservedBooksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReservedBooksDataGrid).BeginInit();
            SuspendLayout();
            // 
            // borrowedBooksDataGrid
            // 
            borrowedBooksDataGrid.AllowUserToAddRows = false;
            borrowedBooksDataGrid.AllowUserToDeleteRows = false;
            borrowedBooksDataGrid.AllowUserToResizeColumns = false;
            borrowedBooksDataGrid.AllowUserToResizeRows = false;
            borrowedBooksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            borrowedBooksDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            borrowedBooksDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            borrowedBooksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            borrowedBooksDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            borrowedBooksDataGrid.Location = new Point(5, 0);
            borrowedBooksDataGrid.Margin = new Padding(2, 1, 2, 1);
            borrowedBooksDataGrid.MultiSelect = false;
            borrowedBooksDataGrid.Name = "borrowedBooksDataGrid";
            borrowedBooksDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            borrowedBooksDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            borrowedBooksDataGrid.Size = new Size(803, 298);
            borrowedBooksDataGrid.TabIndex = 1;
            borrowedBooksDataGrid.CellContentClick += borrowedBooksDataGrid_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(BorrowedBooksTab);
            tabControl1.Controls.Add(ReservedBooksTab);
            tabControl1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.ItemSize = new Size(500, 40);
            tabControl1.Location = new Point(0, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(820, 346);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 3;
            // 
            // BorrowedBooksTab
            // 
            BorrowedBooksTab.Controls.Add(borrowedBooksDataGrid);
            BorrowedBooksTab.Location = new Point(4, 44);
            BorrowedBooksTab.Name = "BorrowedBooksTab";
            BorrowedBooksTab.Padding = new Padding(5);
            BorrowedBooksTab.Size = new Size(812, 298);
            BorrowedBooksTab.TabIndex = 0;
            BorrowedBooksTab.Text = "Borrowed Books";
            BorrowedBooksTab.UseVisualStyleBackColor = true;
            // 
            // ReservedBooksTab
            // 
            ReservedBooksTab.Controls.Add(Update);
            ReservedBooksTab.Controls.Add(borrowDateInput);
            ReservedBooksTab.Controls.Add(ReservedBooksDataGrid);
            ReservedBooksTab.Location = new Point(4, 44);
            ReservedBooksTab.Name = "ReservedBooksTab";
            ReservedBooksTab.Padding = new Padding(3);
            ReservedBooksTab.Size = new Size(812, 298);
            ReservedBooksTab.TabIndex = 1;
            ReservedBooksTab.Text = "Reserved Books";
            ReservedBooksTab.UseVisualStyleBackColor = true;
            // 
            // ReservedBooksDataGrid
            // 
            ReservedBooksDataGrid.AllowUserToAddRows = false;
            ReservedBooksDataGrid.AllowUserToDeleteRows = false;
            ReservedBooksDataGrid.AllowUserToResizeColumns = false;
            ReservedBooksDataGrid.AllowUserToResizeRows = false;
            ReservedBooksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            ReservedBooksDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            ReservedBooksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            ReservedBooksDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            ReservedBooksDataGrid.Location = new Point(5, 0);
            ReservedBooksDataGrid.Margin = new Padding(2, 1, 2, 1);
            ReservedBooksDataGrid.MultiSelect = false;
            ReservedBooksDataGrid.Name = "ReservedBooksDataGrid";
            ReservedBooksDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            ReservedBooksDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReservedBooksDataGrid.Size = new Size(803, 252);
            ReservedBooksDataGrid.TabIndex = 2;
            ReservedBooksDataGrid.CellContentClick += ReservedBooksDataGrid_CellContentClick;
            // 
            // borrowDateInput
            // 
            borrowDateInput.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrowDateInput.Format = DateTimePickerFormat.Short;
            borrowDateInput.Location = new Point(103, 261);
            borrowDateInput.MinDate = new DateTime(2025, 2, 3, 0, 0, 0, 0);
            borrowDateInput.Name = "borrowDateInput";
            borrowDateInput.Size = new Size(200, 25);
            borrowDateInput.TabIndex = 3;
            // 
            // Update
            // 
            Update.Location = new Point(337, 261);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 4;
            Update.Text = "button1";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // ManageReservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(820, 351);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ManageReservations";
            Text = "ReturnBook";
            Load += ManageBorrowed_Load;
            ((System.ComponentModel.ISupportInitialize)borrowedBooksDataGrid).EndInit();
            tabControl1.ResumeLayout(false);
            BorrowedBooksTab.ResumeLayout(false);
            ReservedBooksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReservedBooksDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView borrowedBooksDataGrid;
        private TabControl tabControl1;
        private TabPage ReservedBooksTab;
        private TabPage BorrowedBooksTab;
        private DataGridView ReservedBooksDataGrid;
        private DateTimePicker borrowDateInput;
        private Button Update;
    }
}