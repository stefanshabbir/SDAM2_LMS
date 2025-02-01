﻿using Microsoft.EntityFrameworkCore;
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
        private readonly AccountService _accountService;

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

        public bool DeleteBook(string isbn)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookID == this.GetBookID(isbn));

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
            return _context.Borrowings.Where(b => b.AccountID == accountId)
                .Select(b => new
                {
                    b.BookID,
                    b.Book.Title,
                    b.BorrowDate,
                    b.ReturnDate
                }).ToList();
        }

        public bool BorrowBook(int bookID)
        {
            var accID = _accountService.GetSessionAccount().AccountID;

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

        public bool ReturnBook(int bookID)
        {
            var accID = _accountService.GetSessionAccount().AccountID;
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
    }
}
