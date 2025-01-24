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

namespace SDAM2_LMS.Controllers
{
    internal class BookController
    {
        private readonly DatabaseContext _context;
        public BookController(DatabaseContext context)
        {
            _context = context;
        }

        public bool AddBook(
        string title, string author, string genre, string publisher, string language, string isbn, int quantity
            )
        {
            try
            {
                if (_context.Books.Any(b => b.ISBN == isbn))
                {
                    // TODO: Update the book's quantity
                    return true;
                }
                var book = new Book(title, author, genre, publisher, language, isbn, quantity);
                _context.Books.Add(book);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                Console.WriteLine($"Error Logged");
                return false;
            }
        }

        public List<Book> GetBooks() 
        { 
            return _context.Books.ToList();
        }

        public IEnumerable<Book> SearchBook(string search)
        {
            return _context.Books
                .Where(book => EF.Functions.Like(book.Title, $"%{search}%") || 
                EF.Functions.Like(book.Authors.ToString(), $"%{search}%") ||
                EF.Functions.Like(book.Genres.ToString(), $"%{search}%"))
                  //.Where(book => book.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                                 //book.Authors.Split(',').Any(author => author.Trim().Contains(search)) ||
                                 //book.Genres.Split(',').Any(genre => genre.Trim().Contains(search)) ||
                                 //book.Publisher.Split(',').Any(publisher => publisher.Trim().Contains(search)) ||
                                 //book.Language.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                                 //book.ISBN.Contains(search, StringComparison.OrdinalIgnoreCase))
                  .ToList();
        }

        public void DeleteBook(string id)
        {
            var book = _context.Books.FirstOrDefault(a => a.ISBN == id);
            if (book != null)
            {
                _context.Remove(book);
                _context.SaveChanges();
            }
        }

        public void EditBook(string id, string newTitle, string newAuthors, string newGenres, string newPublishers, string newLanguage, int newQuantity)
        {
            var book = _context.Books.FirstOrDefault(a => a.ISBN == id);

            if (book != null)
            {
                book.Title = newTitle;
                book.Authors = newAuthors;
                book.Genres = newGenres;
                book.Publisher = newPublishers;
                book.Language = newLanguage;
                book.Quantity = newQuantity;
                _context.SaveChanges();
            }
        }
    }
}
