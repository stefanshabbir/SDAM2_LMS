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

            //-- NEEDS ERROR HANDLING; empty/null texts, set max length in winform itself
            _sessionService.LoggedInAccount.Username = UsernameInput.Text;
            _sessionService.LoggedInAccount.PersonalID_Info.Name = NameInput.Text;
            _sessionService.LoggedInAccount.PersonalID_Info.PhoneNumber = PhoneInput.Text;
            _sessionService.LoggedInAccount.PersonalID_Info.Email = EmailInput.Text;
            _sessionService.LoggedInAccount.PersonalID_Info.Address = addressInput.Text;
            //--

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

        private void ResetPasswordBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to reset your password?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                //_accountController.ResetPassword();

                using (var inputDialog = new Form())
                {
                    inputDialog.Text = "Reset Password";
                    inputDialog.Size = new Size(400, 250);
                    inputDialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                    inputDialog.StartPosition = FormStartPosition.CenterParent;

                    // Old password label and textbox
                    var lblOldPassword = new Label() { Text = "Old Password:", Location = new Point(20, 20), AutoSize = true };
                    var txtOldPassword = new TextBox() { Location = new Point(140, 20), Width = 200, UseSystemPasswordChar = true };

                    // New password label and textbox
                    var lblNewPassword = new Label() { Text = "New Password:", Location = new Point(20, 70), AutoSize = true };
                    var txtNewPassword = new TextBox() { Location = new Point(140, 70), Width = 200, UseSystemPasswordChar = true };

                    // Confirm button
                    var btnConfirm = new Button()
                    {
                        Text = "Confirm",
                        Location = new Point(140, 130),
                        DialogResult = DialogResult.OK
                    };
                    inputDialog.AcceptButton = btnConfirm;

                    // Add controls to the dialog
                    inputDialog.Controls.Add(lblOldPassword);
                    inputDialog.Controls.Add(txtOldPassword);
                    inputDialog.Controls.Add(lblNewPassword);
                    inputDialog.Controls.Add(txtNewPassword);
                    inputDialog.Controls.Add(btnConfirm);

                    // Show dialog and check if user clicked OK
                    if (inputDialog.ShowDialog() == DialogResult.OK)
                    {
                        var oldPassword = txtOldPassword.Text;
                        var newPassword = txtNewPassword.Text;

                        if (!string.IsNullOrEmpty(oldPassword) && !string.IsNullOrEmpty(newPassword))
                        {
                            // Call the ResetPassword method in the AccountController
                            var success = _accountController.resetPassword(newPassword);

                            if (success)
                            {
                                MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Password reset failed. Please check your old password and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Both fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
