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

        public List<Account> GetMembers()
        {
            return _context.Accounts
                .Include(m => m.PersonalID_Info) // Include the PersonalID_Info when loading the members accounts
                .ToList(); 
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

        
    }
}
