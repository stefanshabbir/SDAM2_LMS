using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal class Account : IAccount
    {
        public int AccountID { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public int PersonalID { get; private set; }
        public int AccountTypeID { get; private set; }

        public PersonalID_Info PersonalID_Info { get; private set; }
        public AccountType AccountType { get; private set; }
        public ICollection<Borrowing> Borrowings { get; private set; } = new List<Borrowing>();


        public Account(string username, string password, int accountId, int personalInfoID, int accountTypeID)
        {
            this.Username = username;
            this.Password = password;
            this.AccountID = accountId;
            this.PersonalID = personalInfoID;
            this.AccountTypeID = accountTypeID;
        }

        public void ResetPassword(string newPassword)
        {
            Password = newPassword;
        }
    }
}
