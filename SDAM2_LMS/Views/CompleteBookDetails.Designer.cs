namespace SDAM2_LMS
{
    partial class CompleteBookDetails
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
            label1 = new Label();
            borrowedDataGrid = new DataGridView();
            reservedDataGrid = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)borrowedDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservedDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 0;
            label1.Text = "Borrowed Book";
            // 
            // borrowedDataGrid
            // 
            borrowedDataGrid.AllowUserToAddRows = false;
            borrowedDataGrid.AllowUserToDeleteRows = false;
            borrowedDataGrid.AllowUserToResizeColumns = false;
            borrowedDataGrid.AllowUserToResizeRows = false;
            borrowedDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrowedDataGrid.Location = new Point(6, 56);
            borrowedDataGrid.Margin = new Padding(2, 1, 2, 1);
            borrowedDataGrid.MultiSelect = false;
            borrowedDataGrid.Name = "borrowedDataGrid";
            borrowedDataGrid.ReadOnly = true;
            borrowedDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            borrowedDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            borrowedDataGrid.Size = new Size(805, 103);
            borrowedDataGrid.TabIndex = 1;
            borrowedDataGrid.CellContentClick += borrowedDataGrid_CellContentClick;
            // 
            // reservedDataGrid
            // 
            reservedDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservedDataGrid.Location = new Point(6, 218);
            reservedDataGrid.Margin = new Padding(2, 1, 2, 1);
            reservedDataGrid.Name = "reservedDataGrid";
            reservedDataGrid.RowHeadersWidth = 82;
            reservedDataGrid.Size = new Size(805, 128);
            reservedDataGrid.TabIndex = 3;
            reservedDataGrid.CellContentClick += reservedDataGrid_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(314, 176);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(186, 32);
            label2.TabIndex = 2;
            label2.Text = "Reserved Book";
            // 
            // CompleteBookDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(820, 351);
            Controls.Add(reservedDataGrid);
            Controls.Add(label2);
            Controls.Add(borrowedDataGrid);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CompleteBookDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompleteBookDetails";
            Load += CompleteBookDetails_Load_1;
            ((System.ComponentModel.ISupportInitialize)borrowedDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservedDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView borrowedDataGrid;
        private DataGridView reservedDataGrid;
        private Label label2;
    }
}