using SDAM2_LMS.Controllers;
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

namespace SDAM2_LMS
{
    public partial class AddUser : Form
    {
        private readonly UsersController _controller;

        internal AddUser(UsersController manageUserscontroller)
        {
            InitializeComponent();
            _controller = manageUserscontroller;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _controller.AddUser(
                UsernameInput.Text, PasswordInput.Text,
                NameInput.Text, EmailInput.Text,
                addressInput.Text, PhoneInput.Text,
                inputAccountType.SelectedItem.ToString()
                );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PasswordInput.Clear();
            UsernameInput.Clear();
            EmailInput.Clear();
            ConfirmPasswordInput.Clear();
            NameInput.Clear();
            EmailInput.Clear();
            addressInput.Clear();
            PhoneInput.Clear();
            inputAccountType.Items.Clear();

            UsernameInput.Focus();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            inputAccountType.Items.Add("Admin");
            inputAccountType.Items.Add("Librarian");
            inputAccountType.Items.Add("Member");
        }
    }
}
