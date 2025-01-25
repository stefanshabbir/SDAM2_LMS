using SDAM2_LMS.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    public class Account : IAccount
    {
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int PersonalID { get; set; }
        public int AccountTypeID { get; set; }

        public PersonalID_Info PersonalID_Info { get;  set; }
        public AccountType AccountType { get; private set; }
        public ICollection<Borrowing> Borrowings { get; private set; } = new List<Borrowing>();


        public Account() { }
        public Account(string username, string password, int accountTypeID, int personalInfoID)
        {
            this.Username = username;
            this.Password = password;
            this.PersonalID = personalInfoID;
            this.AccountTypeID = accountTypeID;
        }

        public void ResetPassword(string newPassword)
        {
            Password = newPassword;
        }
    }
}
