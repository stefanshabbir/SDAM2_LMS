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

        public Borrowing()
        {

        }
        public Borrowing(int bookID, int accountID, DateTime borrowDate, DateTime returnDate)
        {
            this.BookID = bookID;
            this.AccountID = accountID;
            this.BorrowDate = borrowDate;
            this.ReturnDate = returnDate;
            this.Reserved = false;
        }

        public Borrowing(int bookID, int accountID, DateTime borrowDate, DateTime returnDate, bool reserved)
        {
            this.BookID = bookID;
            this.AccountID = accountID;
            this.BorrowDate = borrowDate;
            this.ReturnDate = returnDate;
            this.Reserved = reserved;
        }
    }

    public class StandardBorrowing : Borrowing
    {
        public int LoanPeriodDays { get; set; } = 7;
    }

    public class ExtendedBorrowing : Borrowing
    {
        public int LoanPeriodDays { get; set; } = 14;
    }
}
