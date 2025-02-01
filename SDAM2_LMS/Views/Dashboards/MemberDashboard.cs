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
        private readonly SessionService _sessionService;
        private readonly AccountService _accountService;
        private readonly AccountController _accountController;
        private readonly BorrowController _borrowController;
        private readonly BookController _bookController;
        internal MemberDashboard(SessionService sessionService, AccountService accountService, AccountController accountController, BookController bookController, BorrowController borrowController)
        {
            InitializeComponent();

            _sessionService = sessionService;
            _accountService = accountService;
            _accountController = accountController;
            _bookController = bookController;
            _borrowController = borrowController;
            if (_sessionService.IsLoggedIn)
            {
                MessageBox.Show($"Welcome, {_sessionService.LoggedInAccount.Username}!");
            }

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
            CompleteBookDetails cbd = new CompleteBookDetails(_borrowController);
            cbd.Show();
        }

        private void menuBtn_ViewProfile_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile(_accountController, _sessionService);
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
