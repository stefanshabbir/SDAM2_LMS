using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Controllers
{
    internal class BookController
    {
        private readonly DatabaseContext _context;
        public BookController(DatabaseContext context)
        {
            _context = context;
        }

        public void AddBook()
        {

        }
    }
}
