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
        public bool Register(string username, string password, string email, string name, string address, string phone)
        {

            var accountExists = _context.Accounts.FirstOrDefault(a => a.Username == username);
            if (accountExists != null)
            {
                return false;
            } else
            {
                var personal = new PersonalID_Info(name, email, phone, address);
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
            var confirmResult = MessageBox.Show("Are you sure you want to delete your account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                var currentUser = _sessionService.LoggedInAccount;
                _context.Accounts.Remove(currentUser);
                _context.SaveChanges();

                _sessionService.Logout();
                MessageBox.Show("Account deleted successfully.");
            }
        }
        
        public void EditAccount(Account updatedAccount)
        {
            var dbAccount = _context.Accounts
                .Include(a=> a.PersonalID_Info)
                .FirstOrDefault(a => a.AccountID == updatedAccount.AccountID);

            dbAccount.Username = updatedAccount.Username;
            dbAccount.PersonalID_Info.Name = updatedAccount.PersonalID_Info.Name;
            dbAccount.PersonalID_Info.PhoneNumber = updatedAccount.PersonalID_Info.PhoneNumber;
            dbAccount.PersonalID_Info.Email = updatedAccount.PersonalID_Info.Email;
            dbAccount.PersonalID_Info.Address = updatedAccount.PersonalID_Info.Address;

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
    }
}
