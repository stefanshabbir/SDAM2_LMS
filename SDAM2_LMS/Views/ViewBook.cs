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
    public partial class ViewBook : Form
    {
        private readonly BookController _controller;
        public ViewBook()
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

                TitleTextBox.Text = title;
                ISBNTextBox.Text = isbn;
                AuthorTextBox.Text = author;
                QuantityTextBox.Text = quantity;
                GenreTextBox.Text = genre;
                PublisherTextBox.Text = publisher;
                LanguageTextBox.Text = language;
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show($"Are you sure you want to update the selected book?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                _controller.EditBook(ISBNTextBox.Text, TitleTextBox.Text, AuthorTextBox.Text, GenreTextBox.Text, PublisherTextBox.Text, LanguageTextBox.Text, Convert.ToInt32(QuantityTextBox.Text));

                dataGridViewBooksView.DataSource = _controller.GetBooks();
                MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
            TitleTextBox.Clear();
            ISBNTextBox.Clear();
            AuthorTextBox.Clear();
            QuantityTextBox.Clear();
            GenreTextBox.Clear();
            PublisherTextBox.Clear();
            LanguageTextBox.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //TODO: NEEDS ERROR CHECKING--
            string title = TitleTextBox.Text;
            string author = AuthorTextBox.Text;
            string genre = GenreTextBox.Text;
            string publisher = PublisherTextBox.Text;
            string language = LanguageTextBox.Text;
            string isbn = ISBNTextBox.Text;
            int quantity = int.Parse(QuantityTextBox.Text);
            // --

            var controller = new BookController(new DatabaseContext());
            bool bookIsAdded = controller.AddBook(title, author, genre, publisher, language, isbn, quantity);
            if (bookIsAdded)
            {
                dataGridViewBooksView.DataSource = _controller.GetBooks();
                MessageBox.Show("Book Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An Unexpected error occured, Check error logs. Book couldn't be added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
