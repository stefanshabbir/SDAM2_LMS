using SDAM2_LMS.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Controllers
{
    internal class MemberController
    {
        private readonly DatabaseContext _context;
        public MemberController(DatabaseContext context)
        {
            _context = context;
        }
    }
}
