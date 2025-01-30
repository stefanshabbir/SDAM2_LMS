using Microsoft.EntityFrameworkCore;
using SDAM2_LMS.ErrorLog;
using SDAM2_LMS.Models;
using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace SDAM2_LMS.Controllers
{
    public class UserController
    {
        private readonly UserService _userService;
        public UserController(UserService service)
        {
            _userService = service;
        }

        public object? GetUsers()
        {
            return _userService.GetUsers();
        }

        //NEEDS DISPLAY MESSAGES
        public void AddUser(
            string username, string password, string name, string email, string address, string phoneNumber, string accountType
            )
        {
            try
            {
                bool userSuccessfullyAdded = _userService.AddUser(username, password, name, email, address, phoneNumber, accountType);
                if (userSuccessfullyAdded)
                { 
                    // Success message
                }
                else
                {
                    // Account already exists message
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                // Error message with exception (Follow format of line 60-69)
            }
        }

        public object? SearchUser(string search)
        {
            try
            {
                return _userService.SearchUser(search);
            }
            catch (Exception ex) //Catch block format for error handling
            {
                new WriteErrorLog(ex); //Writes the error to a text file at /bin/ErrorLogs
                //Try to following this wording format for the message box
                MessageBox.Show($"Could not refresh, an Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                
                return null;
            }
        }

        //-- NEEDS ERROR HANDLING; unexpected exceptions (Follow format of line 60-69)
        public void EditUser(
            Int32 accID, string newUsername, string newName, string newEmail, string newPhoneNumber, string newAddress, string newAccountType
            )
        {
            _userService.EditUser(accID, newUsername, newName, newEmail, newPhoneNumber, newAddress, newAccountType);
        }

        //-- NEEDS ERROR HANDLING; unexpected exceptions (Follow format of line 60-69)
        public void DeleteUser(int accID)
        {
            _userService.DeleteUser(accID);
        }
    }
}
