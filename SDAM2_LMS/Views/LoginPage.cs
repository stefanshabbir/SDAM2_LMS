using SDAM2_LMS.Controllers;
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
        public LoginPage(AccountController accountController)
        {
            _accountController = accountController;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBoxUsername.Text; 
            string password = textBoxPassword.Text; 

            if (_accountController.Login(username, password))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                MainPage mainPage = new MainPage(); 
                mainPage.Show();
                this.Hide(); 
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
    }
}
