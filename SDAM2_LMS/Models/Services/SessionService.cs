using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models.Services
{
    public class SessionService
    {
        public Account? LoggedInAccount { get; set; }

        public bool IsLoggedIn => LoggedInAccount != null;

        public void Logout()
        {
            LoggedInAccount = null;
        }
    }
}
