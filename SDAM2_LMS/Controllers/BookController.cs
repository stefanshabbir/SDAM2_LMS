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
                // Message
            }
        }

        //-- NEEDS ERROR HANDLING
        public List<Book> GetBooks() 
        { 
            return _bookService.GetBooks();
        }

        //-- NEEDS ERROR HANDLING
        public IEnumerable<Book> SearchBook(string search)
        {
            return _bookService.SearchBook(search);
        }

        //-- NEEDS ERROR HANDLING
        public void DeleteBook(string isbn)
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

        //-- NEEDS ERROR HANDLING; null texts, int parsing and unexpected exceptions
        public void EditBook(
            string _oldISBN, string newTitle, string newAuthors, string newGenres,
            string newPublishers, string newLanguage, string newISBN, string stringQuantity
            )
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

        public void BorrowBook(string isbn)
        {
            Int32 bookID = _bookService.GetBookID(isbn);

            bool borrowedSuccessfully = _bookService.BorrowBook(bookID);
            if (borrowedSuccessfully)
            {
                MessageBox.Show("Book borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to borrow book. It may be unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public IEnumerable<object> GetBorrowings(int accountId)
        {
            return _bookService.GetBorrowings(accountId);
        }

        public bool ReturnBook(Int32 bookID)
        {
            bool returnedSuccessfully = _bookService.ReturnBook(bookID);
            if (returnedSuccessfully)
            {
                MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            MessageBox.Show("An error occurred while returning the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
