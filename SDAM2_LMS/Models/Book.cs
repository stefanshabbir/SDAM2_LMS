using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal class Book
    {
        public string? Title { get; private set; }
        public List<string> Authors { get; private set; }
        public List<string> Genres { get; private set; }
        public List<string> Publisher { get; private set; }
        public string? Language { get; private set; }
        public string? ISBN { get; private set; }
        internal int BookID { get; private set; }

        public Book(string title, List<string> authors, List<string> genres, List<string> publisher, string language, string isbn)
        {
            this.Title = title;
            this.Authors = authors;
            this.Genres = genres;
            this.Publisher = publisher;
            this.Language = language;
            this.ISBN = isbn;
        }

        public void SetBookID(int id)
        {
            this.BookID = id;
        }
    }
}
