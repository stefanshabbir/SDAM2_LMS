using SDAM2_LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Controllers
{
    internal class AccountController
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccount accountService) 
        {
            this._accountService = (IAccountService?)accountService;
        }

        public void Login(string username, string password)
        {

        }

        public void Register(string username, string password, string confirmPassword) 
        {
            
        }
    }
}
