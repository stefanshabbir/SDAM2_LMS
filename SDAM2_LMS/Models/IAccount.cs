using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    public interface IAccount
    {
        string Username { get; }
        string Password { get; }
        void ResetPassword(string password);
    }
}
