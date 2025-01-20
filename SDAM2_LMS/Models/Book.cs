using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Genre { get; private set; }
        public string Publisher { get; private set; }
        public string? Language { get; private set; }
        public string? ISBN { get; private set; }
        public int Quantity { get; private set; }
        internal int BookID { get; private set; }


        public Book() { }
        public Book(
        string title, string author, string genre, string publisher, string language, string isbn, int quantity
            )
        {
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.Publisher = publisher;
            this.Language = language;
            this.ISBN = isbn;
            this.Quantity = quantity;
        }

        public void SetBookID(int id)
        {
            this.BookID = id;
        }
    }
}
