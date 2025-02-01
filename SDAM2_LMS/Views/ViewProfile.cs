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
    }
}
