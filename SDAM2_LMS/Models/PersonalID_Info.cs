﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM2_LMS.Models
{
    public class PersonalID_Info
    {
        public int PersonalID { get; set; }
        public string Name { get; set; }
        public string Email { get;  set; }
        public string PhoneNumber {  get;  set; }
        public string Address { get;  set; }

        public Account Account { get; set; }

        public PersonalID_Info(string name, string email, string phoneNumber, string address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
