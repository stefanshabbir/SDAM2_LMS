using Microsoft.EntityFrameworkCore;
using SDAM2_LMS.Controllers;
using SDAM2_LMS.ErrorLog;
using SDAM2_LMS.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models.Services
{
    public class BookService
    {
        private readonly DatabaseContext _context;

        public BookService(DatabaseContext context)
        {
            _context = context;
        }

        public Int32 GetBookID(string isbn)
        {
            if (isbn == null) { return -1;}

            var book = _context.Books.FirstOrDefault(a => a.ISBN == isbn);

            bool bookExist = book != null;
            if (bookExist)
            {
                return Convert.ToInt32(book.BookID);
            }

            return -1;
        }

        public bool AddBook(
            string title, string author, string genre,
            string publisher, string language, string isbn, int quantity
           )
        {
            bool bookExists = _context.Books.Any(b => b.BookID == this.GetBookID(isbn));
            if (bookExists)
            { return false; }

            var book = new Book(title, author, genre, publisher, language, isbn, quantity);
            _context.Books.Add(book);
            _context.SaveChanges();
            return true;
        }

        public List<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public IEnumerable<Book> SearchBook(string search)
        {
            return _context.Books
                .Where(book =>
                EF.Functions.Like(book.Title, $"%{search}%") ||
                EF.Functions.Like(book.Authors.ToString(), $"%{search}%") ||
                EF.Functions.Like(book.Genres.ToString(), $"%{search}%") ||
                EF.Functions.Like(book.Publisher.ToString(), $"%{search}%"))
                .ToList();
        }

        public bool DeleteBook(Int32 bookID)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookID == bookID);

            bool bookExists = book != null;
            if (bookExists)
            {
                _context.Remove(book);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public bool EditBook(
            Int32 bookID, string newTitle, string newAuthors, string newGenres,
            string newPublishers, string newLanguage, string newISBN, int newQuantity
            )
        {
            var book = _context.Books.FirstOrDefault(b => b.BookID == bookID);

            bool bookExists = book != null;
            if (bookExists)
            {
                book.Title = newTitle;
                book.Authors = newAuthors;
                book.Genres = newGenres;
                book.Publisher = newPublishers;
                book.Language = newLanguage;
                book.ISBN = newISBN;
                book.Quantity = newQuantity;
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public IEnumerable<object> GetBorrowings(int accountId)
        {
            return _context.Borrowings.Where(b => b.AccountID == accountId && b.Reserved == false)
                .Select(b => new
                {
                    b.BookID,
                    b.Book.Title,
                    b.BorrowDate,
                    b.ReturnDate
                }).ToList();
        }
        public IEnumerable<object> GetBorrowings()
        {
            return _context.Borrowings.Where(b => b.Reserved == false)
                .Select(b => new
                {
                    b.BookID,
                    b.Account.Username,
                    b.Book.Title,
                    b.BorrowDate,
                    b.ReturnDate
                }).ToList();
        }

        public IEnumerable<object> GetReservations(int accountId)
        {
            return _context.Borrowings.Where(b => b.AccountID == accountId && b.Reserved == true)
                .Select(b => new
                {
                    b.BookID,
                    b.Book.Title,
                    b.BorrowDate,
                    b.ReturnDate
                }).ToList();
        }
        
        public IEnumerable<object> GetReservations()
        {
            return _context.Borrowings.Where(b => b.Reserved == true)
                .Select(b => new
                {
                    b.BookID,
                    b.AccountID,
                    b.Account.Username,
                    b.Book.Title,
                    b.BorrowDate,
                    b.ReturnDate
                }).ToList();
        }

        

        public bool BorrowBook(Int32 bookID, Int32 accID)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookID == bookID);
            var account = _context.Accounts.FirstOrDefault(a => a.AccountID == accID);
            if (book == null || account == null)
            {
                return false;
            }
            if (book.Quantity > 0)
            {
                book.Quantity--;
                var borrowing = new Models.Borrowing(bookID, accID, DateTime.Now, DateTime.Now.AddDays(7));
                _context.Borrowings.Add(borrowing);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ReturnBook(Int32 bookID, Int32 accID)
        {
            var borrowing = _context.Borrowings.FirstOrDefault(b => b.BookID == bookID && b.AccountID == accID);
            var book = _context.Books.FirstOrDefault(b => b.BookID == bookID);
            if (borrowing == null || book == null)
            {
                return false;
            }
            book.Quantity++;
            _context.Borrowings.Remove(borrowing);
            _context.SaveChanges();
            return true;
        }

        public bool ReturnBook(Int32 bookID)
        {
            var borrowing = _context.Borrowings.FirstOrDefault(b => b.BookID == bookID);
            var book = _context.Books.FirstOrDefault(b => b.BookID == bookID);
            if (borrowing == null || book == null)
            {
                return false;
            }
            book.Quantity++;
            _context.Borrowings.Remove(borrowing);
            _context.SaveChanges();
            return true;
        }

        public bool ReserveBook(Int32 bookID, int accID)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookID == bookID);
            var account = _context.Accounts.FirstOrDefault(a => a.AccountID == accID);
            var borrow = _context.Borrowings.FirstOrDefault(br => br.BookID == bookID);

            if (book == null)
            {
                return false;
            }

            if (borrow != null && borrow.Reserved)
            {
                return false;
            }

            if (book.Quantity <= 0)
            {
                var borrowing = new Models.Borrowing(bookID, accID, borrow.ReturnDate, borrow.ReturnDate.AddDays(7), true);
                _context.Borrowings.Add(borrowing);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool CheckReservation(Int32 bookID)
        {
            return _context.Borrowings.Any(b => b.BookID == bookID && b.Reserved == true);
        }

        public bool DeleteReservation(Int32 bookID, Int32 accID)
        {
            var borrow = _context.Borrowings.FirstOrDefault(b => b.BookID == bookID && b.AccountID == accID);
            if (borrow != null)
            {
                _context.Borrowings.Remove(borrow);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ExtendBorrowing(int borrowID)
        {
            var borrowing = _context.Borrowings.FirstOrDefault(b => b.BorrowID == borrowID);

            if (borrowing == null)
            {
                return false;
            }
                borrowing = new Borrowing()
                {
                    BorrowID = borrowing.BorrowID,
                    BookID = borrowing.BookID,
                    AccountID = borrowing.AccountID,
                    BorrowDate = borrowing.BorrowDate,
                    ReturnDate = borrowing.BorrowDate.AddDays(7),
                    Reserved = borrowing.Reserved
                };
                _context.Borrowings.Update(borrowing);
            _context.SaveChanges();
            return true;
        }

    }
}
