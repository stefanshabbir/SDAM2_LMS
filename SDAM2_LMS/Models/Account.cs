using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal class Account : IAccount
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public int AccountID { get; private set; }


        public Account(string username, string password, int accountId)
        {
            this.Username = username;
            this.Password = password;   
            this.AccountID = accountId;
        }

        public void ResetPassword(string newPassword)
        {
            Password = newPassword;
        }
    }
}
