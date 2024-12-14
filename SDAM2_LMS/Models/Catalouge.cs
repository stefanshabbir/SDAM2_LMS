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
    }
}
