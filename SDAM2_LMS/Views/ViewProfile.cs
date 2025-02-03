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
        private readonly ProfileController _profileController;

        internal ViewProfile(ProfileController profileController)
        {
            InitializeComponent();
            _profileController = profileController;
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            var currentUser = _profileController.GetSessionAccount();
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
            var confirmResult = MessageBox.Show("Are you sure you want to delete your account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                _profileController.DeleteProfile();
                this.Close();
                Application.Restart();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to update your account details?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                _profileController.UpdateProfile(
                UsernameInput.Text, NameInput.Text,
                PhoneInput.Text, EmailInput.Text, addressInput.Text
                );
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
                            var success = _profileController.ResetPassword(newPassword);

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
