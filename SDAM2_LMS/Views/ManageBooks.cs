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
    public partial class ManageBooks : Form
    {
        private string? _selectedBookISBN;
        private readonly BookController _controller;

        public ManageBooks(BookController bookController)
        {
            InitializeComponent();

            _controller = bookController;
            var books = _controller.GetBooks();
            dataGridViewBooksView.Rows.Clear();
            dataGridViewBooksView.DataSource = books;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show($"Are you sure you want to delete the book with ISBN: {_selectedBookISBN}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                _controller.DeleteBook(_selectedBookISBN);
                dataGridViewBooksView.DataSource = _controller.GetBooks();
            }
        }

        private void DataGridViewBooksView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBooksView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewBooksView.SelectedRows[0];

                TitleTextBox.Text = selectedRow.Cells["Title"].Value?.ToString();
                ISBNTextBox.Text = selectedRow.Cells["ISBN"].Value?.ToString();
                AuthorTextBox.Text = selectedRow.Cells["Authors"].Value?.ToString();
                QuantityTextBox.Text = selectedRow.Cells["Quantity"].Value?.ToString();
                GenreTextBox.Text = selectedRow.Cells["Genres"].Value?.ToString();
                PublisherTextBox.Text = selectedRow.Cells["Publisher"].Value?.ToString();
                LanguageTextBox.Text = selectedRow.Cells["Language"].Value?.ToString();

                _selectedBookISBN = selectedRow.Cells["ISBN"].Value?.ToString();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show($"Are you sure you want to update the selected book?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                _controller.EditBook(
                    _selectedBookISBN, TitleTextBox.Text, AuthorTextBox.Text, GenreTextBox.Text,
                    PublisherTextBox.Text, LanguageTextBox.Text, ISBNTextBox.Text, QuantityTextBox.Text
                    );
                dataGridViewBooksView.DataSource = _controller.GetBooks();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string search = SearchInput.Text.Trim();
            dataGridViewBooksView.DataSource = _controller.SearchBook(search);
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
            _controller.AddBook(
                TitleTextBox.Text, AuthorTextBox.Text, GenreTextBox.Text,
                PublisherTextBox.Text, LanguageTextBox.Text, ISBNTextBox.Text, QuantityTextBox.Text
                );
            dataGridViewBooksView.DataSource = _controller.GetBooks();
        }
    }
}
