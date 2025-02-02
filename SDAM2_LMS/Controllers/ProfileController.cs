using SDAM2_LMS.Models.Services;
using SDAM2_LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using SDAM2_LMS.ErrorLog;
using System.Net.Mail;

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

        // Incomplete error handling or user input
        public void UpdateProfile(
            string newUsername, string newName, string newPhoneNumber, string newEmail, string newAddress
            )
        {
            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Username and Name are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(newPhoneNumber) || newPhoneNumber.Length < 10)
            {
                MessageBox.Show("Phone Number must be at least 10 digits", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(newEmail) || !AuthenticationController.IsValidEmail(newEmail))
            {
                MessageBox.Show("Invalid Email Format", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(newAddress))
            {
                newAddress = "Not Given";
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
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not update profile. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
            }
        }

        public void DeleteProfile()
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete your account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    _accountService.DeleteAccount();
                    MessageBox.Show("Account deleted successfully. The application will now restart.");
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not delete profile. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
            }
        }

        // NEEDS ERROR HANDLING; incomplete
        public bool resetPassword(string newPassword)
        {
            try
            {
                if (string.IsNullOrEmpty(newPassword))
                { return false; }
                else
                {
                    _accountService.resetPassword(newPassword);
                    return true;
                }
            }
            catch (Exception ex)
            {
                new WriteErrorLog(ex);
                MessageBox.Show($"Could not reset password. An Unexpected Error occured. Check logs for more details. \nError:\n {ex}");
                return false;
            }
        }
    }
}
