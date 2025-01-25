using SDAM2_LMS.Controllers;
using SDAM2_LMS.Models.Data;
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
        private readonly BookController _controller;
        public ViewBooks()
        {
            InitializeComponent();

            var bookController = new BookController(new DatabaseContext());
            _controller = bookController;
            var books = _controller.GetBooks();
            dataGridViewBooksView.Rows.Clear();
            dataGridViewBooksView.DataSource = books;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var bookId = dataGridViewBooksView.SelectedRows[0].Cells["ISBN"].Value.ToString();

                var confirmation = MessageBox.Show($"Are you sure you want to delete the book with ISBN: {bookId}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    _controller.DeleteBook(bookId);
                    dataGridViewBooksView.DataSource = _controller.GetBooks();
                    MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewBooksView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBooksView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewBooksView.SelectedRows[0];

                string title = selectedRow.Cells["Title"].Value?.ToString();
                string isbn = selectedRow.Cells["ISBN"].Value?.ToString();
                string author = selectedRow.Cells["Authors"].Value?.ToString();
                string quantity = selectedRow.Cells["Quantity"].Value?.ToString();
                string genre = selectedRow.Cells["Genres"].Value?.ToString();
                string publisher = selectedRow.Cells["Publisher"].Value?.ToString();
                string language = selectedRow.Cells["Language"].Value?.ToString();

            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string search = SearchInput.Text.Trim();

            try
            {
                dataGridViewBooksView.DataSource = _controller.SearchBook(search);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
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
    }
}
