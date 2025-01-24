using SDAM2_LMS.Models;
using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SDAM2_LMS.Controllers
{
    public class AccountController
    {
        private readonly AccountService _accountService;
        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }

        public Account Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                throw new ArgumentException("Username or password cannot be empty.");

            return _accountService.Login(username, password);
        }

        public bool Register(string username, string password, string email,string name, string address, string phone)
        {
            return _accountService.Register(username, password, email, name, address, phone);
        }

        public void DeleteAccount()
        {
            _accountService.DeleteAccount();
        }
        
        public void EditAccount(Account updatedAccount)
        {
            _accountService.EditAccount(updatedAccount);
        }

        public void Logout()
        {
            _accountService.Logout();
        }

        public bool resetPassword(string newPassword)
        {
            if (string.IsNullOrEmpty(newPassword))
            {
                throw new ArgumentException("Password cannot be empty.");
                return false;

            } else
            {
                _accountService.resetPassword(newPassword);
                return true;
            }
        }

    }
}
