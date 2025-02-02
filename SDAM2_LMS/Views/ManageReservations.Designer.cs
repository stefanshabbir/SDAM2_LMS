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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            borrowedBooksDataGrid = new DataGridView();
            tabControl1 = new TabControl();
            BorrowedBooksTab = new TabPage();
            ReservedBooksTab = new TabPage();
            ReservedBooksDataGrid = new DataGridView();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            borrowedBooksDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            borrowedBooksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            borrowedBooksDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ReservedBooksDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ReservedBooksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ReservedBooksDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            ReservedBooksDataGrid.Location = new Point(5, 0);
            ReservedBooksDataGrid.Margin = new Padding(2, 1, 2, 1);
            ReservedBooksDataGrid.MultiSelect = false;
            ReservedBooksDataGrid.Name = "ReservedBooksDataGrid";
            ReservedBooksDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            ReservedBooksDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReservedBooksDataGrid.Size = new Size(803, 298);
            ReservedBooksDataGrid.TabIndex = 2;
            ReservedBooksDataGrid.CellContentClick += ReservedBooksDataGrid_CellContentClick;
            // 
            // ManageBorrowed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(820, 351);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ManageBorrowed";
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
    }
}