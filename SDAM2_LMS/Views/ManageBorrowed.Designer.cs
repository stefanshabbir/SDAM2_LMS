namespace SDAM2_LMS
{
    partial class ManageBorrowed
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
            borrowedBooksDataGrid = new DataGridView();
            label1 = new Label();
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
            borrowedBooksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrowedBooksDataGrid.Location = new Point(5, 0);
            borrowedBooksDataGrid.Margin = new Padding(2, 1, 2, 1);
            borrowedBooksDataGrid.MultiSelect = false;
            borrowedBooksDataGrid.Name = "borrowedBooksDataGrid";
            borrowedBooksDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            borrowedBooksDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            borrowedBooksDataGrid.Size = new Size(803, 278);
            borrowedBooksDataGrid.TabIndex = 1;
            borrowedBooksDataGrid.CellContentClick += borrowedBooksDataGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 2;
            label1.Text = "Borrowed Book";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(BorrowedBooksTab);
            tabControl1.Controls.Add(ReservedBooksTab);
            tabControl1.Location = new Point(0, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(820, 306);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 3;
            // 
            // BorrowedBooksTab
            // 
            BorrowedBooksTab.Controls.Add(borrowedBooksDataGrid);
            BorrowedBooksTab.Location = new Point(4, 24);
            BorrowedBooksTab.Name = "BorrowedBooksTab";
            BorrowedBooksTab.Padding = new Padding(3);
            BorrowedBooksTab.Size = new Size(812, 278);
            BorrowedBooksTab.TabIndex = 0;
            BorrowedBooksTab.Text = "Borrowed Books";
            BorrowedBooksTab.UseVisualStyleBackColor = true;
            // 
            // ReservedBooksTab
            // 
            ReservedBooksTab.Controls.Add(ReservedBooksDataGrid);
            ReservedBooksTab.Location = new Point(4, 24);
            ReservedBooksTab.Name = "ReservedBooksTab";
            ReservedBooksTab.Padding = new Padding(3);
            ReservedBooksTab.Size = new Size(812, 278);
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
            ReservedBooksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReservedBooksDataGrid.Location = new Point(5, 0);
            ReservedBooksDataGrid.Margin = new Padding(2, 1, 2, 1);
            ReservedBooksDataGrid.MultiSelect = false;
            ReservedBooksDataGrid.Name = "ReservedBooksDataGrid";
            ReservedBooksDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            ReservedBooksDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReservedBooksDataGrid.Size = new Size(803, 278);
            ReservedBooksDataGrid.TabIndex = 2;
            ReservedBooksDataGrid.CellContentClick += ReservedBooksDataGrid_CellContentClick;
            // 
            // ManageBorrowed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(820, 351);
            Controls.Add(label1);
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
            PerformLayout();
        }

        #endregion
        private DataGridView borrowedBooksDataGrid;
        private Label label1;
        private TabControl tabControl1;
        private TabPage ReservedBooksTab;
        private TabPage BorrowedBooksTab;
        private DataGridView ReservedBooksDataGrid;
    }
}