using SDAM2_LMS.Controllers;
using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM2_LMS
{
    public partial class ViewBooks : Form
    {
        private readonly BookController _bookController;
        private string? _selectedBookISBN;

        public ViewBooks(BookController bookController)
        {
            InitializeComponent();

            _bookController = bookController;
 
            dataGridViewBooksView.Rows.Clear();
            dataGridViewBooksView.DataSource = _bookController.GetBooks();
        }

        private void DataGridViewBooksView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBooksView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewBooksView.SelectedRows[0];

                var quantityValue = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                if (quantityValue <= 0)
                { BorrowBtn.Text = "Reserve"; }
                else 
                { BorrowBtn.Text = "Borrow"; }

                _selectedBookISBN = selectedRow.Cells["ISBN"].Value?.ToString();
            }

        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string search = SearchInput.Text.Trim();
            dataGridViewBooksView.DataSource = _bookController.SearchBook(search);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            if (!dataGridViewBooksView.Columns.Contains("Availability"))
            {
                DataGridViewTextBoxColumn availabilityColumn = new DataGridViewTextBoxColumn
                {
                    Name = "Availability",
                    HeaderText = "Availability",
                    ReadOnly = true
                };
                dataGridViewBooksView.Columns.Add(availabilityColumn);
            }

            // Attach the CellFormatting event for custom styling
            dataGridViewBooksView.CellFormatting += DataGridViewBooksView_CellFormatting;
        }

        private void DataGridViewBooksView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if we're formatting the Availability column
            if (dataGridViewBooksView.Columns[e.ColumnIndex].Name == "Availability")
            {
                // Get the corresponding Quantity value
                var quantityValue = Convert.ToInt32(dataGridViewBooksView.Rows[e.RowIndex].Cells["Quantity"].Value);

                if (quantityValue > 0)
                {
                    e.Value = "Available";
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.Value = "Unavailable";
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                dataGridViewBooksView.Columns["Quantity"].Visible = false; // Hide the Quantity column
                e.FormattingApplied = true; // Indicate that formatting has been applied
            }
        }

        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            bool noBookSelected = dataGridViewBooksView.SelectedRows.Count == 0;
            if (noBookSelected)
            {
                MessageBox.Show("Please select a book to borrow.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //debug
            MessageBox.Show(_selectedBookISBN, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _bookController.BorrowBook(_selectedBookISBN);
        }
    }
}
