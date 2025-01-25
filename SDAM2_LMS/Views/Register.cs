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
    public partial class Register : Form
    {
        private readonly AccountController _accountController;
        private readonly SessionService _sessionService;
        private readonly AccountService _accountService;
        internal Register(AccountController accountController, SessionService sessionService, AccountService accountService)
        {
            InitializeComponent();
            _accountController = accountController;
            _sessionService = sessionService;
            _accountService = accountService;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //-- NEEDS ERROR HANDLING; set max length in winform itself, empty/null text inputs
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;
            string confirmPassword = ConfirmPasswordInput.Text;

            string email = EmailInput.Text;
            string phone = PhoneInput.Text;
            string address = addressInput.Text;
            string name = NameInput.Text;
            //--


            bool isRegistered = _accountController.Register(username, password, email, name, address, phone);

            if (isRegistered)
            {
                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new MemberDashboard(_sessionService, _accountService, _accountController).Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                PasswordInput.Clear();
                UsernameInput.Clear();
                EmailInput.Clear();
                ConfirmPasswordInput.Clear();
                UsernameInput.Focus();
            }



        }
    }
}
