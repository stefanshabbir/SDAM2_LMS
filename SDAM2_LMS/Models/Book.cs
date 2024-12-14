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
        public List<Author>? Authors { get; private set; }
        public List<Genre>? Genres { get; private set; }
        public string? Publisher { get; private set; }
        public string? Language { get; private set; }
        public string? ISBN { get; private set; }
        protected int BookID { get; private set; }
    }
}
