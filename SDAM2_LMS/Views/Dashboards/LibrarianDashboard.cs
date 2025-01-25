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
    public partial class LibrarianDashboard : Form
    {
        private readonly SessionService _sessionService;
        internal LibrarianDashboard(SessionService sessionService)
        {
            InitializeComponent();
            if (_sessionService.IsLoggedIn)
            {
                MessageBox.Show($"Welcome, {_sessionService.LoggedInAccount.Username}!");
            }

            _sessionService = sessionService;
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
            CompleteBookDetails cbd = new CompleteBookDetails();
            cbd.Show();
        }

        private void menuBtn_Books_Click(object sender, EventArgs e)
        {
            ManageBooks mb = new ManageBooks();
            mb.Show();
        }
    }
}
