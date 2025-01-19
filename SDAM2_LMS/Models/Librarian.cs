using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal class Librarian : Account
    {
        public Librarian() { }
        public Librarian(string username, string password, int accountId, int personalInfoID, int accountTypeID) 
        {
 
        }

        public void AddBookItem(Book book)
        {

        }

        public void UpdateCatalogue(Book book) { }
    }
}
