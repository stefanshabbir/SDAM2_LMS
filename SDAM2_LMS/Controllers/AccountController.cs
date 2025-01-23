using SDAM2_LMS.Models;
using SDAM2_LMS.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Controllers
{
    internal class AccountController
    {
        private readonly DatabaseContext _context;
        public AccountController(DatabaseContext context)
        {
            _context = context;
        }

        public Account Login(string username, string password)
        {
            return _context.Accounts.FirstOrDefault(a=> a.Username == username && a.Password == password);
        }

        public bool Register(string username, string password, string confirmPassword) 
        {
            try
            {
                if (_context.Accounts.Any(a=> a.Username == username))
                    return false;

                var account = new Account { Username = username, Password = password, PersonalID = 124124, AccountTypeID = 12312 };

                _context.Accounts.Add(account);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
