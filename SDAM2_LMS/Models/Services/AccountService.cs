using SDAM2_LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models.Services
{
    internal class AccountService 
    {
        //placeholder list to simulate list of accounts
        private List<Account> accounts = new List<Account>();

        //simulating the login 
        public bool Login(string username, string password)
        {
            // searching for corresponding account in list
            return accounts.Any(a => a.Username == username && a.Password == password);
        }

        //simulating registrations
        public bool Register(string username, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            if (password != confirmPassword)
                return false;

            if (accounts.Any(a => a.Username == username))
                return false;

            // adds username, password and ascending number for acc ID and returns true
            //accounts.Add(new Account(username, password, accounts.Count + 1));
            return true;
        }
    }
}
