using SDAM2_LMS.Controllers;
using SDAM2_LMS.Models;
using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SDAM2_LMS.Views
{
    public partial class ViewProfile : Form
    {
        private readonly AccountController _accountController;
        private readonly SessionService _sessionService;

        internal ViewProfile(AccountController accountController, SessionService sessionService)
        {
            InitializeComponent();
            _accountController = accountController;
            _sessionService = sessionService;
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            var currentUser = _sessionService.LoggedInAccount;

            if (currentUser != null)
            {
                UsernameInput.Text = currentUser.Username;
                NameInput.Text = currentUser.PersonalID_Info.Name;
                PhoneInput.Text = currentUser.PersonalID_Info.PhoneNumber;
                EmailInput.Text = currentUser.PersonalID_Info.Email;
                addressInput.Text = currentUser.PersonalID_Info.Address;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ViewProfile_Load(sender, e);
            UsernameInput.ReadOnly = !UsernameInput.ReadOnly;
            NameInput.ReadOnly = !NameInput.ReadOnly;
            PhoneInput.ReadOnly = !PhoneInput.ReadOnly;
            EmailInput.ReadOnly = !EmailInput.ReadOnly;
            addressInput.ReadOnly = !addressInput.ReadOnly;

            EditBtn.Text = UsernameInput.ReadOnly ? "Edit" : "Cancel";
            UpdateBtn.Enabled = !UsernameInput.ReadOnly;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            _accountController.DeleteAccount();
            this.Close();
            Application.Restart();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameInput.Text) || string.IsNullOrEmpty(NameInput.Text))
            {
                MessageBox.Show("Username and Name are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _sessionService.LoggedInAccount.Username = UsernameInput.Text;
            _sessionService.LoggedInAccount.PersonalID_Info.Name = NameInput.Text;
            _sessionService.LoggedInAccount.PersonalID_Info.PhoneNumber = PhoneInput.Text;
            _sessionService.LoggedInAccount.PersonalID_Info.Email = EmailInput.Text;
            _sessionService.LoggedInAccount.PersonalID_Info.Address = addressInput.Text;

            try
            {
                _accountController.EditAccount(_sessionService.LoggedInAccount);
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EditBtn_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
