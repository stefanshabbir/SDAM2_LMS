using SDAM2_LMS.Controllers;
using SDAM2_LMS.Models.Data;
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
    public partial class LibrarianDashboard : Form
    {
        private readonly ProfileController _profileController;
        private readonly BookController _bookController;
        private readonly BorrowController _borrowController;

        internal LibrarianDashboard(
            ProfileController profileController, BookController bookController, BorrowController borrowController
            )
        {
            InitializeComponent();

            _profileController = profileController;
            _bookController = bookController;
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

        private void menuBtn_Books_Click(object sender, EventArgs e)
        {
            ManageBooks mb = new ManageBooks(_bookController);
            mb.Show();
        }

        private void menuBtn_Reservations_Click(object sender, EventArgs e)
        {
            ManageReservations mb = new ManageReservations(_borrowController);
            mb.Show();
        }

        private void menuBtn_ViewProfile_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile(_profileController);
            viewProfile.Show();
        }
    }
}
