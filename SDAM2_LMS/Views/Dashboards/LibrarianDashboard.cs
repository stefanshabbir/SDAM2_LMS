using SDAM2_LMS.Models;
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
        public LibrarianDashboard()
        {
            InitializeComponent();
            if (AppSession.IsLoggedIn)
            {
                MessageBox.Show($"Welcome, {AppSession.LoggedInAccount.Username}!");
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

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBooks vb = new ManageBooks();
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

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBooks mb = new ManageBooks();
            mb.Show();
        }
    }
}
