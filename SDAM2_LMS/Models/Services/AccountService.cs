using Microsoft.EntityFrameworkCore;
using SDAM2_LMS.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SDAM2_LMS.Models.Services
{
    public class AccountService 
    {
        //placeholder list to simulate list of accounts
        private List<Account> accounts = new List<Account>();

        private readonly DatabaseContext _context;
        private readonly SessionService _sessionService;

        public AccountService(DatabaseContext context, SessionService sessionService)
        {
            _context = context;
            _sessionService = sessionService;
        }

        //simulating the login 
        public Account Login(string username, string password)
        {
            // searching for corresponding account in list
            var account = _context.Accounts
                .Include(a => a.PersonalID_Info)
                .FirstOrDefault(a => a.Username == username && a.Password == password);
            _sessionService.LoggedInAccount = account;
            return account;
        }

        //simulating registrations
        public bool Register(
            string username, string password,string confirmpassword, string email, string name, string address, string phoneNumber
            )
        {
            var accountExists = _context.Accounts.FirstOrDefault(a => a.Username == username && a.Password == password) != null;
            if (accountExists) { return false;} 
            else
            {
                var personal = new PersonalID_Info(name, email, phoneNumber, address);
                _context.PersonalIDs.Add(personal);
                _context.SaveChanges();

                var account = new Account()
                {
                    Username = username,
                    Password = password,
                    PersonalID = personal.PersonalID,
                    AccountTypeID = 3, //default type is 'Member'
                };

                _context.Accounts.Add(account);
                _context.SaveChanges();
                _sessionService.LoggedInAccount = account;
                return true;
            }
        }
           
        public void DeleteAccount()
        {
            var currentUser = this.GetSessionAccount();
            _context.PersonalIDs.Remove(currentUser.PersonalID_Info);
            _context.Accounts.Remove(currentUser);
            _context.SaveChanges();

            _sessionService.Logout();
        }
        
        public void UpdateAccount(
            Int32 accID , string newUsername, string newName,
            string newEmail, string newPhoneNumber, string newAddress
            )
        {
            var dbAccount = _context.Accounts
                .Include(a=> a.PersonalID_Info)
                .FirstOrDefault(a => a.AccountID == accID);

            dbAccount.Username = newUsername;
            dbAccount.PersonalID_Info.Name = newName;
            dbAccount.PersonalID_Info.PhoneNumber = newPhoneNumber;
            dbAccount.PersonalID_Info.Email = newEmail;
            dbAccount.PersonalID_Info.Address = newAddress;

            _context.SaveChanges();
        }

        public void Logout()
        {
            _sessionService.Logout();
        }

        public AutoResetEvent resetPassword(string newPassword)
        {
            var currentUser = _sessionService.LoggedInAccount;
            currentUser.Password = newPassword;
            _context.SaveChanges();
            return new AutoResetEvent(true);
        }

        public Account GetSessionAccount()
        {
            return _sessionService.LoggedInAccount;
        }
    }
}
