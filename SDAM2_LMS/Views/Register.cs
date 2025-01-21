using SDAM2_LMS.Controllers;
using SDAM2_LMS.Models.Data;
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
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameInput.Text;
            string email = EmailInput.Text;
            string password = PasswordInput.Text;
            string confirmPassword = ConfirmPasswordInput.Text;

            var controller = new Services.AccountService(new DatabaseContext());
            bool isRegistered = controller.Register(username, password, email);

            if (isRegistered)
            {
                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new Dashboard().Show();
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
