﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    internal interface IAccount
    {
        string Username { get; }
        string Password { get; }
        void ResetPassword(string password);
    }
}
