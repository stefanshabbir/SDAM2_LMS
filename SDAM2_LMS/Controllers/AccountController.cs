using SDAM2_LMS.Models;
using SDAM2_LMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Controllers
{
    public class AccountController
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService) 
        {
            _accountService = accountService;
        }

        public bool Login(string username, string password)
        {
            return _accountService.Login(username, password);
        }

        public void Register(string username, string password, string confirmPassword) 
        {
            
        }
    }
}
