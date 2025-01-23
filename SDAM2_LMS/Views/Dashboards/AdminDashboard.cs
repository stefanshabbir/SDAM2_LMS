﻿using System;
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
        public AdminDashboard()
        {
            InitializeComponent();
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

        private void ViewBooks_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();

        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails cbd = new CompleteBookDetails();
            cbd.Show();
        }

        private void ViewMembers_Click(object sender, EventArgs e)
        {
            ViewMember vm = new ViewMember();
            vm.Show();
        }

        private void AddMembers_Click(object sender, EventArgs e)
        {
            AddMember am = new AddMember();
            am.Show();
        }

        private void RemoveMembers_Click(object sender, EventArgs e)
        {

        }

        private void EditMembers_Click(object sender, EventArgs e)
        {

        }
    }
}
