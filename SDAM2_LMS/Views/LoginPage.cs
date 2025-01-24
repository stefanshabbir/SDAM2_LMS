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
        const int ADMIN = 1;
        const int LIBRARIAN = 2;
        const int MEMBER = 3;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            var controller = new AccountController(new AccountService(new DatabaseContext()));
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
                    LibrarianDashboard dashboard = new LibrarianDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MemberDashboard dashboard = new MemberDashboard();
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
            new Register().Show();
            this.Hide();
        }
    }
}
