using SDAM2_LMS.Controllers;
using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM2_LMS
{
    public partial class Register : Form
    {
        private readonly AuthenticationController _authController;

        internal Register(AuthenticationController authenticationController)
        {
            InitializeComponent();
            _authController = authenticationController;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;
            string confirmPassword = ConfirmPasswordInput.Text;

            string email = EmailInput.Text;
            string phone = PhoneInput.Text;
            string address = addressInput.Text;
            string name = NameInput.Text;


            bool registrationIsSuccessful = _authController.Register(username, password, confirmPassword, email, name, address, phone);
            if (registrationIsSuccessful) { this.Hide(); }
        }
    }
}
