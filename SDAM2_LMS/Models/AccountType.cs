using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal class AccountType
    {
        public int AccountTypeID { get; private set; }
        public string AccountTypeName { get; set; }

        public AccountType(int accountTypeID, string accountTypeName ) 
        {
            this.AccountTypeID = accountTypeID;
            this.AccountTypeName = accountTypeName;
        }

        public ICollection<Account> Accounts { get; set; }
    }
}
