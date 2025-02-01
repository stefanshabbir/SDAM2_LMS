using Accessibility;
using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Controllers
{
    public class BorrowController
    {
        private readonly DatabaseContext _context;
        private readonly SessionService _sessionService;

        public BorrowController(DatabaseContext context, SessionService sessionService)
        {
            _context = context;
            _sessionService = sessionService;
        }

        


    }
}
