using Microsoft.EntityFrameworkCore;
using SDAM2_LMS.ErrorLog;
using SDAM2_LMS.Models.Data;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models.Services
{
    public class UsersService
    {
        private readonly DatabaseContext _context;

        public UsersService(DatabaseContext context)
        {
            _context = context;
        }

        public int GetAccountTypeIDOf(string accountType)
        {
            if (accountType == "Admin")
            { return 1; }
            else if (accountType == "Librarian")
            { return 2; }
            else if (accountType == "Member")
            { return 3; }
            else
            {
                //Throw new error for Invalid account type and catch this specific error in controller's error handling
                return -1;
            }
        }

        public object? GetUsers()
        {
            var users = _context.Accounts
                .Include(pid => pid.PersonalID_Info) // To include the PersonalID_Info when loading the members accounts
                .Include(at => at.AccountType)
                .ToList();

            //selecting the columns to display
            var usersList = users.Select(m => new
            {
                m.Username,
                m.PersonalID_Info.Name,
                m.PersonalID_Info.Email,
                m.PersonalID_Info.PhoneNumber,
                m.PersonalID_Info.Address,
                m.AccountType.AccountTypeName,
                m.AccountID
            }).ToList();

            return usersList;
        }

        // Returns false if account already exists, true if it doesn't. Could throw errors
        public bool AddUser(
            string username, string password, string name, string email, string address, string phoneNumber, string accountType
            )
        {
            bool accountExists = _context.Accounts.FirstOrDefault(a => a.Username == username && a.Password == password) != null;
            if (accountExists) { return false; }
            else
            {
                var personalInfo = new PersonalID_Info(name, email, phoneNumber, address);
                _context.PersonalIDs.Add(personalInfo);
                _context.SaveChanges();

                int accountTypeID = this.GetAccountTypeIDOf(accountType);
                var account = new Account()
                {
                    Username = username,
                    Password = password,
                    PersonalID = personalInfo.PersonalID,
                    AccountTypeID = accountTypeID
                };

                _context.Accounts.Add(account);
                _context.SaveChanges(); 
                return true;
            }
        }

        public object? SearchUser(string search)
        {
            var searchList = _context.Accounts
                .Where(account => EF.Functions.Like(account.Username, $"%{search}%") ||
                EF.Functions.Like(account.PersonalID_Info.Name, $"%{search}%") ||
                EF.Functions.Like(account.PersonalID_Info.Email, $"%{search}%"))
                  .ToList();

            var formattedSearchList = searchList.Select(m => new
            {
                m.Username,
                m.PersonalID_Info.Name,
                m.PersonalID_Info.Email,
                m.PersonalID_Info.PhoneNumber,
                m.PersonalID_Info.Address,
                m.AccountType.AccountTypeName,
                m.AccountID
            }).ToList();

            return formattedSearchList;
        }

        public void EditUser(
            Int32 accID, string newUsername, string newName, string newEmail, string newPhoneNumber, string newAddress, string newAccountType
            )
        {
            int accTypeID = this.GetAccountTypeIDOf(newAccountType);
            var account = _context.Accounts.FirstOrDefault(a => a.AccountID == accID);

            if (account != null)
            {
                account.AccountTypeID = accTypeID;
                account.Username = newUsername;
                account.PersonalID_Info.Name = newName;
                account.PersonalID_Info.Email = newEmail;
                account.PersonalID_Info.PhoneNumber = newPhoneNumber;
                account.PersonalID_Info.Address = newAddress;
                _context.SaveChanges();
            }
        }

        public void DeleteUser(int accID)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.AccountID == accID);
            if (account != null)
            {
                _context.Remove(account);
                _context.SaveChanges();

                var personalInfo = _context.PersonalIDs.FirstOrDefault(p => p.PersonalID == account.PersonalID);
                _context?.Remove(personalInfo);
                _context?.SaveChanges();
            }
        }
    }
}
