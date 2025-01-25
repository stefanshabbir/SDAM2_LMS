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
        public int BorrowID { get; private set; }
        public int BookID { get; private set; }
        public int AccountID { get; private set; }
        public DateTime BorrowDate { get; private set; }
        public DateTime ReturnDate { get; private set; }
        public bool Reserved { get; private set; }

        public Book Book { get; set; }
        public Account Account { get; set; }


        public Borrowing() { }
        public Borrowing(int borrowID, int bookID, int accountID, DateTime borrowDate, DateTime returnDate, Book book, Account account)
        {
            this.BorrowID = borrowID;
            this.BookID = bookID;
            this.AccountID = accountID;
            this.BorrowDate = borrowDate;
            this.ReturnDate = returnDate;
        }
    }
}
