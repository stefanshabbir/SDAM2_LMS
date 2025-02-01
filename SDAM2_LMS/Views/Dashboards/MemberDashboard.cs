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
        //private readonly SessionService _session;

        internal MemberDashboard(ProfileController profileController)
        {
            InitializeComponent();
            // **--Need to get rid of models in view--**
            _profileController = profileController;
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
            CompleteBookDetails cbd = new CompleteBookDetails();
            cbd.Show();
        }

        private void menuBtn_ViewProfile_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile(_profileController);
            viewProfile.Show();
        }
    }
}
