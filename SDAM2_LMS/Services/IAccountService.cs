using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Services
{
    public interface IAccountService
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string confirmPassword);
    }
}
