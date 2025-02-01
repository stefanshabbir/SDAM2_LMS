using Microsoft.EntityFrameworkCore;
using SDAM2_LMS.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    public class Book
    {
        private readonly DatabaseContext dbContext;
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Genres { get; set; }
        public string Publisher { get; set; }
        public string? Language { get; set; }
        public string? ISBN { get; set; }
        public int Quantity { get; set; }
        public int BookID { get; set; }


        public Book(DatabaseContext context)
        {
            this.dbContext = context;
        }
        public Book(
        string title, string author, string genre, string publisher, string language, string isbn, int quantity
            )
        {
            this.Title = title;
            this.Authors = author;
            this.Genres = genre;
            this.Publisher = publisher;
            this.Language = language;
            this.ISBN = isbn;
            this.Quantity = quantity;
        }

        public void SetBookID(int id)
        {
            this.BookID = id;
        }

        public IEnumerable<Book> SearchBook(string search)
        {
            return dbContext.Books.Where(book => 
            book.Title.Contains(search)).ToList();
            //EF.Functions.Like(book.Authors.ToString(), $"%{search}%") ||
            //EF.Functions.Like(book.Genres.ToString(), $"%{search}%"))
        }

        public bool DeleteBook(int id) 
        { 
            var book = dbContext.Books.FirstOrDefault(a => a.BookID== id);
            if (book != null)
            {
                dbContext.Remove(book);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
