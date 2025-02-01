﻿using SDAM2_LMS.Controllers;
using SDAM2_LMS.Models.Data;
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
        private readonly ProfileController _profileController;

        internal LibrarianDashboard(ProfileController profileController)
        {
            InitializeComponent();
            // **--Need to get rid of models in view--**
            _profileController = profileController;

            //if (_sessionService.IsLoggedIn)
            //{
            //    MessageBox.Show($"Welcome, {_sessionService.LoggedInAccount.Username}!");
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

        private void menuBtn_Books_Click(object sender, EventArgs e)
        {
            //Check if this is correct
            ManageBooks mb = new ManageBooks
                (
                new BookController(new BookService(new DatabaseContext()))
                );
            mb.Show();
        }
    }
}
