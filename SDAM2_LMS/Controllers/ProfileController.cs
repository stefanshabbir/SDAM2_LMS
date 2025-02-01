using SDAM2_LMS.Models.Services;
using SDAM2_LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace SDAM2_LMS.Controllers
{
    public class ProfileController
    {
        private readonly AccountService _accountService;

        public ProfileController(AccountService accountService)
        {
            _accountService = accountService;
        }

        public Account? GetSessionAccount()
        {
            return _accountService.GetSessionAccount();
        }

        // Incomplete error handling
        public void UpdateProfile(
            string newUsername, string newName, string newPhoneNumber, string newEmail, string newAddress
            )
        {
            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Username and Name are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var user = _accountService.GetSessionAccount();

                user.Username = newUsername;
                user.PersonalID_Info.Name = newName;
                user.PersonalID_Info.PhoneNumber = newPhoneNumber;
                user.PersonalID_Info.Email = newEmail;
                user.PersonalID_Info.Address = newAddress;

                _accountService.UpdateAccount(
                    user.AccountID, newUsername, newName, newEmail, newPhoneNumber, newAddress
                    );
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NEEDS ERROR HANDLING
        public void DeleteProfile()
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete your account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                _accountService.DeleteAccount();
                MessageBox.Show("Account deleted successfully. The application will now restart.");
            }
        }

        // NEEDS ERROR HANDLING
        public bool resetPassword(string newPassword)
        {
            if (string.IsNullOrEmpty(newPassword))
            { return false; }
            else
            {
                _accountService.resetPassword(newPassword);
                return true;
            }
        }
    }
}
