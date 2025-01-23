using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal static class AppSession
    {
        public static Account? LoggedInAccount { get; set; }

        public static bool IsLoggedIn => LoggedInAccount != null;

        public static void Logout()
        {
            LoggedInAccount = null;
        }
    }
}
