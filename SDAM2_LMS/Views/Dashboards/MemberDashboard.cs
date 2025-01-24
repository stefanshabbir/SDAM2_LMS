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
        internal MemberDashboard(SessionService sessionService, AccountService accountService, AccountController accountController)
        {
            InitializeComponent();

            _sessionService = sessionService;
            _accountService =  accountService;
            _accountController = accountController;
            if (_sessionService.IsLoggedIn)
            {
                MessageBox.Show($"Welcome, {_sessionService.LoggedInAccount.Username}!");
            }
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();

            }

        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks abs = new AddBooks();
            abs.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();

        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember am = new AddMember();
            am.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails cbd = new CompleteBookDetails();
            cbd.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile(_accountController, _sessionService);
            viewProfile.Show();
        }
    }
}
