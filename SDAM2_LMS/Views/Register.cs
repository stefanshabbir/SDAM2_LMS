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

        private void button2_Click(object sender, EventArgs e)
        {
            if (PasswordInput.Text == ConfirmPasswordInput.Text) 
            {
                string username = UsernameInput.Text;
                string password = PasswordInput.Text;
                string email = EmailInput.Text;
                

            }

           
            //this.Hide();
        }
    }
}
