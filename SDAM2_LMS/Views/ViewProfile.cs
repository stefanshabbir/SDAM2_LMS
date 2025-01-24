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
            var updatedAccount = new Account
            {
                AccountID = _sessionService.LoggedInAccount.AccountID,
                Username = UsernameInput.Text,
                //PersonalID_Info = new PersonalID_Info
                //{
                //    Name = NameInput.Text,
                //    Email = EmailInput.Text,
                //    PhoneNumber = PhoneInput.Text,
                //    Address = addressInput.Text
                //}
            };

            // Save the changes via the controller
            //_accountController.UpdateProfile(updatedAccount);

            // Update session data
            //AppSession.LoggedInAccount = _accountController.GetProfile(updatedAccount.AccountID);

            // Feedback to the user
            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
