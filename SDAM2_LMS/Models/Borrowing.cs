using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    public class Borrowing
    {

        public int BorrowID { get; set; }
        public int BookID { get; set; }
        public int AccountID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool Reserved { get; set; }

        public Book Book { get; set; }
        public Account Account { get; set; }

        public Borrowing() { }
        public Borrowing(int bookID, int accountID, DateTime borrowDate, DateTime returnDate)
        {
            this.BookID = bookID;
            this.AccountID = accountID;
            this.BorrowDate = borrowDate;
            this.ReturnDate = returnDate;
        }
    }
}
