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
        private readonly BorrowController _borrowController;
        private readonly BookController _bookController;
        private readonly ProfileController _profileController;
        //private readonly SessionService _session;

        internal MemberDashboard(
            ProfileController profileController, BorrowController borrowController, BookController bookController)
        {
            InitializeComponent();
            // **--Need to get rid of models in view--**
            _profileController = profileController;
            _bookController = bookController;
            _borrowController = borrowController;

            //_session = new SessionService();
            //_session.LoggedInAccount = profileController.GetSessionAccount();
            //if (_session.IsLoggedIn)
            //{
            //    MessageBox.Show($"Welcome, {_session.LoggedInAccount.Username}!");
            //}
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails cbd = new CompleteBookDetails(_borrowController, _sessionService);
            cbd.Show();
        }

        private void menuBtn_ViewProfile_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile(_profileController);
            viewProfile.Show();
        }

        private void viewBooksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewBooks = new ViewBooks(_borrowController, _bookController);
            viewBooks.Show();
        }
    }
}
