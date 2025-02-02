using Microsoft.Extensions.DependencyInjection;
using SDAM2_LMS.Controllers;
using SDAM2_LMS.Models.Services;
using SDAM2_LMS.Views;
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
    public partial class MemberDashboard : Form
    {
        private readonly ProfileController _profileController;
        private readonly BorrowController _borrowController;

        internal MemberDashboard(
            ProfileController profileController, BorrowController borrowController)
        {
            InitializeComponent();

            _profileController = profileController;
            _borrowController = borrowController;

            var currentUser = _profileController.GetSessionAccount();
            bool isLoggedIn = currentUser != null;
            if (isLoggedIn)
            {
                MessageBox.Show($"Welcome, {currentUser.Username}!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuBtn_BorrowedReserved_Click(object sender, EventArgs e)
        {
            BorrowedReservedBooks cbd = new BorrowedReservedBooks(_profileController, _borrowController);
            cbd.Show();
        }

        private void menuBtn_ViewProfile_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile(_profileController);
            viewProfile.Show();
        }

        private void menuBtn_ViewBooks_Click(object sender, EventArgs e)
        {
            var viewBooks = new ViewBooks(_borrowController);
            viewBooks.Show();
        }
    }
}
