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

        public IEnumerable<Book>? SearchBookForBorrow(string search)
        {
            try
            {
                if (string.IsNullOrEmpty(search)) { return _bookService.GetBooks(); }

                return _bookService.SearchBook(search);
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not search books. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return null;
            }
        }

        public void BorrowBook(string isbn)
        {
            try
            {
                if (string.IsNullOrEmpty(isbn))
                {
                    MessageBox.Show("ISBN cannot be empty!","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

        public IEnumerable<object>? GetBorrowings(Int32 accID)
        {
            try
            {
                if (accID <= 0)
                {
                    MessageBox.Show("Invalid Account ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }

                return _bookService.GetBorrowings(accID);
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not get borrowings. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return null;
            }
        }

        public IEnumerable<object>? GetBorrowings() 
        {
            try
            {
                return _bookService.GetBorrowings();
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not get borrowings. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return null;
            }
        }

        public IEnumerable<object>? GetReservations(int accID)
        {
            try
            {
                return _bookService.GetReservations(accID);
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not get reservations. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return null;
            }
        }

        public IEnumerable<object>? GetReservations()
        {
            try
            {
                return _bookService.GetReservations();
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not get reservations. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return null;
            }
        }

        public bool ReturnBook(Int32 bookID)
        {
            try
            {
                Account acc = _accountService.GetSessionAccount();
                bool returnedSuccessfully;

                if (acc.AccountType.AccountTypeName == "Librarian")
                {
                    returnedSuccessfully = _bookService.ReturnBook(bookID);
                } else
                {
                    returnedSuccessfully = _bookService.ReturnBook(bookID, acc.AccountID);
                }

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
                MessageBox.Show($"Could not return book. An Unexpected Error occurred. Check logs for more details. \nError:\n {ex}");
                return false;
            }
        }

        public bool ReserveBook(string isbn)
        {
            try
            {
                Int32 bookID = _bookService.GetBookID(isbn);
                Int32 accID = _accountService.GetSessionAccount().AccountID;

                if (_bookService.CheckReservation(bookID))
                {
                    MessageBox.Show("Book is already reserved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                bool reservedSuccessfully = _bookService.ReserveBook(bookID, accID);

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

        public bool DeleteReservations(Int32 bookID, Int32 accID)
        {
            try
            {
                bool deletedSuccessfully = _bookService.DeleteReservation(bookID, accID);
                if (deletedSuccessfully)
                {
                    MessageBox.Show("Reservation deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                MessageBox.Show("An error occurred while deleting the reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not delete reservation. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return false;
            }
        }

        public bool ExtendBorrowing(int borrowID)
        {
            try
            {
                bool extendedSuccessfully = _bookService.ExtendBorrowing(borrowID);
                if (extendedSuccessfully)
                {
                    MessageBox.Show("Borrowing extended successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                MessageBox.Show("An error occurred while extending the borrowing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not extend borrowing. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return false;
            }
        }

        public bool UpdateBorrowDate(int borrowID, DateTime newBorrowDate)
        {
            try
            {
                if (newBorrowDate.CompareTo(DateTime.Now) < 0)
                {
                    MessageBox.Show("Borrow date cannot be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                bool dateUpdated = _bookService.UpdateBorrowDate(borrowID, newBorrowDate);
                if (dateUpdated)
                {
                    MessageBox.Show("Borrow Date updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to update borrow date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not update borrow date. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return false;
            }
        }
    }
}
