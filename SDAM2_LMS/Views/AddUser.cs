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
        private readonly ManageUsersController _controller;

        internal AddUser(ManageUsersController manageUserscontroller)
        {
            InitializeComponent();
            _controller = manageUserscontroller;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //-- NEEDS ERROR HANDLING; empty/null text inputs, set max length in winform itself
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;
            string confirmPassword = ConfirmPasswordInput.Text;

            string name = NameInput.Text;
            string email = EmailInput.Text;
            string address = addressInput.Text;
            string phoneNumber = PhoneInput.Text;
            string accountType = inptAccountType.Text;
            //

            bool accountIsAdded = _controller
                .AddUser(username, password, name, email, address, phoneNumber, accountType);

            if (accountIsAdded)
            {
                MessageBox.Show("Account successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An Error occured, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                PasswordInput.Clear();
                UsernameInput.Clear();
                EmailInput.Clear();
                ConfirmPasswordInput.Clear();
                UsernameInput.Focus();
            }

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
            inptAccountType.Clear();

            UsernameInput.Focus();
        }
    }
}
