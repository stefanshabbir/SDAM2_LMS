using SDAM2_LMS.Controllers;
using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM2_LMS
{
    public partial class Register : Form
    {
        private readonly AuthenticationController _authController;

        internal Register(AuthenticationController authenticationController)
        {
            InitializeComponent();
            _authController = authenticationController;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;
            string confirmPassword = ConfirmPasswordInput.Text;

            string email = EmailInput.Text;
            string phone = PhoneInput.Text;
            string address = addressInput.Text;
            string name = NameInput.Text;
            
            if (!ValidateInputs(username,password, confirmPassword, email, phone, address, name)) { return; }

            bool registrationIsSuccessful = _authController.Register(username, password, email, name, address, phone);
            if (registrationIsSuccessful) { this.Hide(); }
            
        }

        private bool ValidateInputs(string username, string password, string confirmpassword, string email, string phone, string address, string name)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowError("Username cannot be empty!", UsernameInput);
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                ShowError("Password cannot be empty!", PasswordInput);
                return false;
            }
            if (string.IsNullOrWhiteSpace(confirmpassword))
            {
                ShowError("Confirm Password cannot be empty!", PasswordInput);
                return false;
            }
            if (password != confirmpassword)
            {
                ShowError("Passwords do not match", ConfirmPasswordInput);
                return false;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                ShowError("Email cannot be empty!", EmailInput);
                return false;
            }
            if (!IsValidEmail(email))
            {
                ShowError("Invalid email format", EmailInput);
                return false;
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                ShowError("Phone nummber cannot be empty", PhoneInput);
                return false;
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                address = "Not Given";
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                ShowError("Name cannot be empty", NameInput);
                return false;
            }
            return true;
        }
      
        private void ShowError(string message, Control control)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var test = new MailAddress(email);
                return true;
            }
            catch(FormatException)
            {
                return false;
            }
        }
    }
}
