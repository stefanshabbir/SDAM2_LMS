using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal class Catalouge
    {
        public List<Author>? Authors { get; private set; }
        public List<Book>? Books { get; private set; }
        public List<Genre>? Genres { get; private set; }

        public Catalouge()
        {
            // Temporary constructor
        }

        public void AddToCatalouge(Book book)
        {
            this.Books.Add(book);
            UpdateCatalouge(book);
        }
        public void UpdateCatalouge(Book book)
        {
            foreach (var author in book.Authors)
            {
                bool authorDoesNotExist = !this.Authors.Contains(author);
                if (authorDoesNotExist) { this.Authors.Add(author); }
            }

            foreach (var genre in book.Genres)
            {
                bool genreDoesNotExist = !this.Genres.Contains(genre);
                if (genreDoesNotExist) { this.Genres.Add(genre); }
            }
        }
    }
}
