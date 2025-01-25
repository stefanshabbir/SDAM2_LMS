using Microsoft.EntityFrameworkCore;
using SDAM2_LMS.ErrorLog;
using SDAM2_LMS.Models;
using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace SDAM2_LMS.Controllers
{
    internal class ManageMembersController
    {
        private readonly DatabaseContext _context;
        public ManageMembersController(DatabaseContext context)
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
                //Throw an error or something
                return 0;
            }
        }

        public object GetMembers()
        {
            var members = _context.Accounts
                .Include(m => m.PersonalID_Info) // Include the PersonalID_Info when loading the members accounts
                .Include(at => at.AccountType)
                .ToList();

            var membersList = members.Select(m => new //selecting the columns to display
            {
                m.Username,
                m.PersonalID_Info.Name, //using personalID_Info as it is an object
                m.PersonalID_Info.Email,
                m.PersonalID_Info.PhoneNumber,
                m.PersonalID_Info.Address,
                m.AccountType.AccountTypeName,
                m.AccountID,
                m.PersonalID
            }).ToList();

            return membersList;
        }

        public bool AddMemberAccount(
            string username, string password, string name, string email, string address, string phoneNumber, string accountType
            )
        {
            try
            {
                var accountExists = _context.Accounts.FirstOrDefault(a => a.Username == username && a.Password == password);
                if (accountExists != null)
                { return false; }
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
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                Console.WriteLine($"Error Logged");
                return false;
            }
        }
         //would this work?
        public object SearchMember(string search)
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
                m.AccountID,
                m.PersonalID
            }).ToList();

            return formattedSearchList;
        }

        public void EditMemberAccount(
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
    }
}
