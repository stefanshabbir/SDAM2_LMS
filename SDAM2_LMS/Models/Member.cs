using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal class Member : Account
    {
        private DateTime DateOfMembership { get; set; }
        private List<Book> BooksCheckedOut { get; set; }

        public Member(string username, string password, int accountId, DateTime dateOfMembership,List<Book> booksCheckedOut) : base(username, password, accountId)
        {

        }

        public void returnBook(Book book)
        {
            BooksCheckedOut.Remove(book);
        }
    }
}
