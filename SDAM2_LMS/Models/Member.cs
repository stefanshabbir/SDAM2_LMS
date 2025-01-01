using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal class Member : Account
    {
        public DateTime DateOfMembership { get; private set; }
        public List<Book> BooksCheckedOut { get; private set; }


        public Member() { }
        public Member(string username, string password, int accountId, int personalInfoID, int accountTypeID, DateTime dateOfMembership) 
        {
            this.DateOfMembership = dateOfMembership;
            this.BooksCheckedOut = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            BooksCheckedOut.Add(book);
        }
        public void ReturnBook(Book book)
        {
            BooksCheckedOut.Remove(book);
        }
    }
}
