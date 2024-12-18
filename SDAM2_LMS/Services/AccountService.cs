using SDAM2_LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Services
{
    internal class AccountService : IAccountService
    {
        //placeholder list to simulate list of accounts
        private readonly List<Account> _accounts;

        public AccountService() 
        {
            _accounts = new List<Account>
            {
                new Account("admin", "admin123", 1) //Admin username
            };
        }

        //simulating the login 
        public bool Login(string username, string password)
        {
            // searching for corresponding account in list
            return _accounts.Any(a => a.Username == username && a.Password == password);
        }

        //simulating registrations
        public bool Register(string username, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            if (password != confirmPassword)
                return false;

            if (_accounts.Any(a => a.Username == username))
                return false;

            // adds username, password and ascending number for acc ID and returns true
            _accounts.Add(new Account(username, password, _accounts.Count + 1));
            return true;
        }
    }
}
