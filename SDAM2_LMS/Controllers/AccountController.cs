using SDAM2_LMS.Models;
using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Controllers
{
    internal class AccountController
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

        public bool Register(string username, string password, string email) 
        { 
            return _accountService.Register(username, password, email);
        }
        
    }
}
