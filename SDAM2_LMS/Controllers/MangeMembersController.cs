using Microsoft.EntityFrameworkCore;
using SDAM2_LMS.ErrorLog;
using SDAM2_LMS.Models;
using SDAM2_LMS.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Controllers
{
    internal class MangeMembersController
    {
        private readonly DatabaseContext _context;
        public MangeMembersController(DatabaseContext context)
        {
            _context = context;
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
                m.AccountType.AccountTypeName,
                m.AccountID,
                m.PersonalID
            }).ToList();

            return membersList;
        }

        public bool AddMemberAccount()
        {
            try
            {
                if (false)
                {
                    // TODO: Update the book's quantity
                    return true;
                }
                

                return true;
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                Console.WriteLine($"Error Logged");
                return false;
            }
        }
         //would this work?
        public IEnumerable<Account> SearchMember(string search)
        {
            return _context.Accounts
                .Where(account => EF.Functions.Like(account.Username, $"%{search}%") ||
                EF.Functions.Like(account.PersonalID_Info.Name, $"%{search}%") ||
                EF.Functions.Like(account.PersonalID_Info.Email, $"%{search}%"))
                  
                  .ToList();
        }

        public void EditMemberAccount()
        {

        }
    }
}
