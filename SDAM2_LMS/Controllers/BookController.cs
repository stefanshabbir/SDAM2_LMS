using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDAM2_LMS.ErrorLog;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using SDAM2_LMS.Models.Services;
using System.Net;
using System.Windows.Forms;

namespace SDAM2_LMS.Controllers
{
    public class BookController
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        public void AddBook(
        string title, string author, string genre,
        string publisher, string language, string isbn, string stringQuantity
            )
        {
            try
            {
                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(genre) || string.IsNullOrEmpty(publisher)
                    || string.IsNullOrEmpty(language) || string.IsNullOrWhiteSpace(isbn) || string.IsNullOrEmpty(stringQuantity))
                {
                    MessageBox.Show("All Fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (isbn.Contains(" "))
                {
                    MessageBox.Show("ISBN cannot contain spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(stringQuantity, out int quantity) || quantity <= 0) 
                {
                    MessageBox.Show("Quantity must be a valid positive number.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return;
                }

                bool bookIsAdded = _bookService.AddBook(title, author, genre, publisher, language, isbn, quantity);
                if (bookIsAdded)
                {
                    MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A book with the same ISBN already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not add book. An Unexpected Error occurred. Check logs for more details. \nError:\n {ex}");
            }
        }

        public List<Book>? GetBooks()
        {
            try
            {
                return _bookService.GetBooks();
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not get books. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return null;
            }
        }

        public IEnumerable<Book>? SearchBook(string search)
        {
            try
            {
                if (string.IsNullOrEmpty(search)) { return _bookService.GetBooks(); }

                return _bookService.SearchBook(search);
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not search/refresh books. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return null;
            }
        }

        public void DeleteBook(string isbn)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(isbn))
                {
                    MessageBox.Show("ISBN cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Int32 bookID = _bookService.GetBookID(isbn);

                if (bookID == 0)
                {
                    MessageBox.Show("Book not found. Nothing to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool bookIsDeleted = _bookService.DeleteBook(bookID);
                if (bookIsDeleted)
                {
                    MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not delete book. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
            }
        }

        public void EditBook(
            string _oldISBN, string newTitle, string newAuthors, string newGenres,
            string newPublishers, string newLanguage, string newISBN, string stringQuantity
            )
        {
            try
            {
                if (string.IsNullOrEmpty(newTitle) || string.IsNullOrEmpty(newAuthors) || string.IsNullOrEmpty(newGenres) ||  string.IsNullOrEmpty(newPublishers)
                    || string.IsNullOrEmpty(newLanguage) || string.IsNullOrWhiteSpace(newISBN) || string.IsNullOrEmpty(stringQuantity))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(stringQuantity, out int newQuantity) || newQuantity <= 0)
                {
                    MessageBox.Show("Quantity must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (newISBN.Contains(" "))
                {
                    MessageBox.Show("New ISBN cannot contain spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Int32 bookID = _bookService.GetBookID(_oldISBN);

                bool bookIsEdited = _bookService.EditBook(
                    bookID, newTitle, newAuthors, newGenres, newPublishers, newLanguage, newISBN, newQuantity
                    );
                if (bookIsEdited)
                {
                    MessageBox.Show("Book edited successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book cannot be edited. It may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not edit book.An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
            }
        }
    }
}
