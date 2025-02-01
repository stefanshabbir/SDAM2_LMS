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
        private readonly AuthenticationController _authController;

        public LoginPage(AuthenticationController authenticationController)
        {
            InitializeComponent();
            _authController = authenticationController;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool loginIsSuccessful = _authController.Login(textBoxUsername.Text, textBoxPassword.Text);
            if (loginIsSuccessful) { this.Hide(); }
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {

        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            new Register(_authController).Show();
            this.Hide();
        }
    }
}
