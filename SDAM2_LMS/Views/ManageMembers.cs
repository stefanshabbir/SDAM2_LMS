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
    public partial class ManageMembers : Form
    {
        private readonly BookController _controller;
        public ManageMembers()
        {
            InitializeComponent();

            var bookController = new BookController(new DatabaseContext());
            _controller = bookController;
            var books = _controller.GetBooks();
            DataGridViewBooksView.Rows.Clear();
            DataGridViewBooksView.DataSource = books;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var bookId = DataGridViewBooksView.SelectedRows[0].Cells["ISBN"].Value.ToString();

                var confirmation = MessageBox.Show($"Are you sure you want to delete the book with ISBN: {bookId}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    _controller.DeleteBook(bookId);
                    DataGridViewBooksView.DataSource = _controller.GetBooks();
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
            if (DataGridViewBooksView.SelectedRows.Count > 0)
            {
                var selectedRow = DataGridViewBooksView.SelectedRows[0];

                string title = selectedRow.Cells["Title"].Value?.ToString();
                string isbn = selectedRow.Cells["ISBN"].Value?.ToString();
                string author = selectedRow.Cells["Authors"].Value?.ToString();
                string quantity = selectedRow.Cells["Quantity"].Value?.ToString();
                string genre = selectedRow.Cells["Genres"].Value?.ToString();
                string publisher = selectedRow.Cells["Publisher"].Value?.ToString();
                string language = selectedRow.Cells["Language"].Value?.ToString();

                inptName.Text = title;
                inptUsername.Text = isbn;
                inptEmail.Text = author;
                inptAccountType.Text = quantity;
                GenreTextBox.Text = genre;
                inptPhoneNumber.Text = publisher;
                LanguageTextBox.Text = language;
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show($"Are you sure you want to update the selected book?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                _controller.EditBook(inptUsername.Text, inptName.Text, inptEmail.Text, GenreTextBox.Text, inptPhoneNumber.Text, LanguageTextBox.Text, Convert.ToInt32(inptAccountType.Text));

                DataGridViewBooksView.DataSource = _controller.GetBooks();
                MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string search = SearchInput.Text.Trim();

            try
            {
                DataGridViewBooksView.DataSource = _controller.SearchBook(search);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            inptName.Clear();
            inptUsername.Clear();
            inptEmail.Clear();
            inptAccountType.Clear();
            GenreTextBox.Clear();
            inptPhoneNumber.Clear();
            LanguageTextBox.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //TODO: NEEDS ERROR CHECKING--
            string title = inptName.Text;
            string author = inptEmail.Text;
            string genre = GenreTextBox.Text;
            string publisher = inptPhoneNumber.Text;
            string language = LanguageTextBox.Text;
            string isbn = inptUsername.Text;
            int quantity = int.Parse(inptAccountType.Text);
            // --

            var controller = new BookController(new DatabaseContext());
            bool bookIsAdded = controller.AddBook(title, author, genre, publisher, language, isbn, quantity);
            if (bookIsAdded)
            {
                DataGridViewBooksView.DataSource = _controller.GetBooks();
                MessageBox.Show("Book Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An Unexpected error occured, Check error logs. Book couldn't be added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
