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

        public bool BorrowBook(int bookID)
        {
            var accID = _sessionService.LoggedInAccount.AccountID;

            var book = _context.Books.FirstOrDefault(b => b.BookID == bookID);
            var account = _context.Accounts.FirstOrDefault(a => a.AccountID == accID);
            if (book == null || account == null)
            {
                return false;
            }
            if (book.Quantity > 0)
            {
                book.Quantity--;
                var borrowing = new Models.Borrowing(bookID, accID, DateTime.Now, DateTime.Now.AddDays(7));
                _context.Borrowings.Add(borrowing);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
