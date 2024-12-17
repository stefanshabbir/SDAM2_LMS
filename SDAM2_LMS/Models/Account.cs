using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal class Account
    {
        private string Username { get; set; }
        private string Password { get; set; }
        private int AccountID { get; set; }


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
