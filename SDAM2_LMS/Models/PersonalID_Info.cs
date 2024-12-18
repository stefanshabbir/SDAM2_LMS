using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDAM2_LMS.Models.Data;

namespace SDAM2_LMS.Models
{
    internal class PersonalID_Info
    {
        public Database_ID PersonalID { get; private set; }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber {  get; private set; }
        public string Address { get; private set; }

        PersonalID_Info(int personalID, string name, string email, string phoneNumber, string address)
        {
            PersonalID = new Database_ID(personalID);
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
