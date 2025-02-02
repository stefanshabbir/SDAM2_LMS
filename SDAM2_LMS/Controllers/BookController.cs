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
        public BookController(BookService context)
        {
            _bookService = context;
        }

        public void AddBook(
        string title, string author, string genre,
        string publisher, string language, string isbn, string stringQuantity
            )
        {
            // null/empty texts error handling
            try
            {
                int quantity = int.Parse(stringQuantity); // could throw errors

                bool bookIsAdded = _bookService.AddBook(title, author, genre, publisher, language, isbn, quantity);
                if (bookIsAdded)
                {
                   // Success message
                }
                else
                {
                    // Book already exists, cannot be added (same isbn)
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not add book. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
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

        //-- NEEDS ERROR HANDLING; if null
        public IEnumerable<Book>? SearchBook(string search)
        {
            try
            {
                return _bookService.SearchBook(search);
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not search/refresh books. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return null;
            }
        }

        //-- NEEDS ERROR HANDLING; if null
        public void DeleteBook(string isbn)
        {
            try
            {
                Int32 bookID = _bookService.GetBookID(isbn);

                bool bookIsDeleted = _bookService.DeleteBook(bookID);
                if (bookIsDeleted)
                {
                    // Success message
                }
                else
                {
                    //Invalid book, nothing deleted
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not delete book. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
            }
        }

        //-- NEEDS ERROR HANDLING; null texts, int parsing
        public void EditBook(
            string _oldISBN, string newTitle, string newAuthors, string newGenres,
            string newPublishers, string newLanguage, string newISBN, string stringQuantity
            )
        {
            try
            {
                Int32 bookID = _bookService.GetBookID(_oldISBN);

                int newQuantity = int.Parse(stringQuantity);

                bool bookIsEdited = _bookService.EditBook(
                    bookID, newTitle, newAuthors, newGenres, newPublishers, newPublishers, newISBN, newQuantity
                    );
                if (bookIsEdited)
                {
                    // Success message
                }
                else
                {
                    // Book cannot be edited, it may not exist
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not edit book.An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
            }
        }

        //-- NEEDS ERROR HANDLING; if null
        public void BorrowBook(string isbn)
        {
            try
            {
                Int32 bookID = _bookService.GetBookID(isbn);

                bool borrowedSuccessfully = _bookService.BorrowBook(bookID);
                if (borrowedSuccessfully)
                {
                    MessageBox.Show("Book borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MessageBox.Show("Failed to borrow book. It may be unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not borrow book. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
            }
        }

        //-- NEEDS ERROR HANDLING; if null
        public IEnumerable<object>? GetBorrowings(int accountId)
        {
            try
            {
                return _bookService.GetBorrowings(accountId);
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not get borrowings. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return null;
            }
        }

        public bool ReturnBook(Int32 bookID)
        {
            try
            {
                bool returnedSuccessfully = bookID != null && _bookService.ReturnBook(bookID);
                if (returnedSuccessfully)
                {
                    MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                MessageBox.Show("An error occurred while returning the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not return book. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return false;
            }
        }
    }
}
