using SDAM2_LMS.Controllers;
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
    public partial class AdminDashboard : Form
    {
        private readonly ProfileController _profileController;
        private readonly BookController _bookController;
        private readonly BorrowController _borrowController;
        private readonly UsersController _usersController;

        internal AdminDashboard(
            ProfileController profileController, BookController bookController,
            BorrowController borrowController, UsersController usersController
            )
        {
            InitializeComponent();

            _profileController = profileController;
            _bookController = bookController;
            _borrowController = borrowController;
            _usersController = usersController;
        }

        private void menuBtn_Users_Click(object sender, EventArgs e)
        {
            var mu = new ManageUsers(_usersController);
            mu.Show();
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
            var mb = new ManageBooks(_bookController);
            mb.Show();
        }

        private void menuBtn_Reservations_Click(object sender, EventArgs e)
        {
            var mb = new ManageReservations(_borrowController);
            mb.Show();
        }
    }
}
