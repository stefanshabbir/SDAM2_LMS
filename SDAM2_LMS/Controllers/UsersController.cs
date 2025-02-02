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
    public class UsersController
    {
        private readonly UsersService _userService;
        public UsersController(UsersService service)
        {
            _userService = service;
        }

        public object? GetUsers()
        {
            return _userService.GetUsers();
        }
        public void AddUser(
            string username, string password, string name,
            string email, string address, string phoneNumber, string accountType
            )
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email)
                    || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(accountType))
                {
                    MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool userSuccessfullyAdded = _userService.AddUser(username, password, name, email, address, phoneNumber, accountType);
                if (userSuccessfullyAdded)
                {
                    MessageBox.Show("Account successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Account already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"An Unexpected Error occured. Check logs for more details. \nError: \n {ex}");
            }
        }

        public object? SearchUser(string search)
        {
            try
            {
                return _userService.SearchUser(search);
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex); 
                MessageBox.Show($"Could not refresh, an Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return null;
            }
        }

        public void EditUser(
            Int32 accID, string newUsername, string newName,
            string newEmail, string newPhoneNumber, string newAddress, string newAccountType
            )
        {
            try
            {
                if (accID <= 0)
                {
                    MessageBox.Show("Please enter a valid numeric Account ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } 
                if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newEmail) || 
                    string.IsNullOrWhiteSpace(newPhoneNumber) || string.IsNullOrWhiteSpace(newAddress) || string.IsNullOrWhiteSpace(newAccountType))
                {
                    MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _userService.EditUser(accID, newUsername, newName, newEmail, newPhoneNumber, newAddress, newAccountType);
                MessageBox.Show("User profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
            }
            
        }
        public void DeleteUser(int accID)
        {
            try
            {
                if (accID < 0)
                {
                    MessageBox.Show("Please enter a valid numeric Account ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _userService.DeleteUser(accID);
                MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
            }
        }
    }
}
