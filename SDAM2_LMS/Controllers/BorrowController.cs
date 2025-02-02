using SDAM2_LMS.ErrorLog;
using SDAM2_LMS.Models;
using SDAM2_LMS.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Controllers
{
    public class BorrowController
    {
        private readonly BookService _bookService;
        private readonly AccountService _accountService;

        public BorrowController(BookService bookService, AccountService accountService)
        {
            _bookService = bookService;
            _accountService = accountService;
        }

        public List<Book>? GetBooksForBorrow()
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
        public IEnumerable<Book>? SearchBookForBorrow(string search)
        {
            try
            {
                return _bookService.SearchBook(search);
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not search books. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return null;
            }
        }

        //-- NEEDS ERROR HANDLING; if null
        public void BorrowBook(string isbn)
        {
            try
            {
                Int32 bookID = _bookService.GetBookID(isbn);
                Int32 accID = _accountService.GetSessionAccount().AccountID;

                bool borrowedSuccessfully = _bookService.BorrowBook(bookID, accID);
                if (borrowedSuccessfully)
                {
                    MessageBox.Show("Book borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to borrow book. It may be unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not borrow book. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
            }
        }

        //-- NEEDS ERROR HANDLING; if null
        public IEnumerable<object>? GetBorrowings(Int32 accID)
        {
            try
            {
                return _bookService.GetBorrowings(accID);
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
                Int32 accID = _accountService.GetSessionAccount().AccountID;

                bool returnedSuccessfully = bookID != null && _bookService.ReturnBook(bookID, accID);
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

        public bool ReserveBook(string isbn)
        {
            try
            {
                Int32 bookID = _bookService.GetBookID(isbn);
                Int32 accID = _accountService.GetSessionAccount().AccountID;
                bool reservedSuccessfully = bookID != null && _bookService.ReserveBook(bookID, accID);

                if (reservedSuccessfully)
                {
                    MessageBox.Show("Book reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                MessageBox.Show("An error occurred while reserving the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not reserve book. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return false;
            }
        }
    }
}
