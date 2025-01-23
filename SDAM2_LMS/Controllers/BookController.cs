using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDAM2_LMS.ErrorLog;

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
    }
}
