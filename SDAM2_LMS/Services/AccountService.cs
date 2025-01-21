using Microsoft.EntityFrameworkCore;
using SDAM2_LMS.Models;
using SDAM2_LMS.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Services
{
    internal class AccountService 
    {
        //placeholder list to simulate list of accounts
        private List<Account> accounts = new List<Account>();

        private readonly DatabaseContext _context;

        public AccountService(DatabaseContext context)
        {
            _context = context;
        }

        //simulating the login 
        public Account Login(string username, string password)
        {
            // searching for corresponding account in list
            return _context.Accounts.FirstOrDefault(a => a.Username == username && a.Password == password);
        }

        //simulating registrations
        public bool Register(string username, string password, string email)
        {

            var accountExists = _context.Accounts.FirstOrDefault(a => a.Username == username);
            if (accountExists != null)
            {
                return false;
            } else
            {
                var personal = new PersonalID_Info(null, email, null, null);
                _context.PersonalIDs.Add(personal);
                _context.SaveChanges();

                var account = new Account()
                {
                    Username = username,
                    Password = password,
                    PersonalID = personal.PersonalID,
                    AccountTypeID = 1,
                };

                _context.Accounts.Add(account);
                _context.SaveChanges();
                return true;
            }
            
        }
            

        
    }
}
