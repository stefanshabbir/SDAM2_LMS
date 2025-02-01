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
            bool bookIsDeleted = _bookService.DeleteBook(isbn);
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

        public bool BorrowBook(int bookID)
        {
            return _bookService.BorrowBook(bookID);
        }

        public IEnumerable<object> GetBorrowings(int accountId)
        {
            return _bookService.GetBorrowings(accountId);
        }

        public bool ReturnBook(int bookID)
        {
            return _bookService.ReturnBook(bookID);
        }
    }
}
