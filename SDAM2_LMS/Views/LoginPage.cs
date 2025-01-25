using Microsoft.Extensions.DependencyInjection;
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

namespace SDAM2_LMS
{
    public partial class LoginPage : Form
    {
        private readonly AccountController _accountController;
        private readonly SessionService _sessionService;
        private readonly AccountService _accountService;

        const int ADMIN = 1;
        const int LIBRARIAN = 2;
        const int MEMBER = 3;

        public LoginPage(AccountController accountController, AccountService accountService, SessionService sessionService)
        {
            InitializeComponent();
            _accountController = accountController;
            _accountService = accountService;
            _sessionService = sessionService;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            var controller = _accountController;
            var user = controller.Login(username, password);

            if (user != null)
            {
                if (user.AccountTypeID == ADMIN)
                {
                    AdminDashboard dashboard = new AdminDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else if (user.AccountTypeID == LIBRARIAN)
                {
                    LibrarianDashboard dashboard = new(_sessionService);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MemberDashboard dashboard = new(_sessionService, _accountService, _accountController);
                    dashboard.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxUsername.Focus();
            }

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {

        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            new Register(_accountController, _sessionService, _accountService).Show();
            this.Hide();
        }
    }
}
