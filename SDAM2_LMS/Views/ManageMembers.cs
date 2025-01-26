using SDAM2_LMS.Controllers;
using SDAM2_LMS.ErrorLog;
using SDAM2_LMS.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM2_LMS
{
    public partial class ManageMembers : Form
    {
        private Int32 _selectedAccountID { get; set; }
        private readonly ManageMembersController _controller;

        public ManageMembers()
        {
            InitializeComponent();

            var memberController = new ManageMembersController(new DatabaseContext());
            _controller = memberController;

            DataGridViewBooksView.Rows.Clear();
            DataGridViewBooksView.DataSource = _controller.GetMembers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var username = DataGridViewBooksView.SelectedRows[0].Cells["Username"].Value.ToString();
                var confirmation = MessageBox.Show($"Are you sure you want to delete {username}'s account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    _controller.DeleteMemberAccount(_selectedAccountID);
                    DataGridViewBooksView.DataSource = _controller.GetMembers();
                    MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewBooksView_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewBooksView.SelectedRows.Count > 0)
            {
                var selectedRow = DataGridViewBooksView.SelectedRows[0];

                string username = selectedRow.Cells["Username"].Value?.ToString();
                string name = selectedRow.Cells["Name"].Value?.ToString();
                string email = selectedRow.Cells["Email"].Value?.ToString();
                string accountType = selectedRow.Cells["AccountTypeName"].Value?.ToString();
                string phoneNumber = selectedRow.Cells["PhoneNumber"].Value?.ToString();
                string address = selectedRow.Cells["Address"].Value?.ToString();
                string selectedAccID = selectedRow.Cells["AccountID"].Value?.ToString();

                inptUsername.Text = username;
                inptName.Text = name;
                inptEmail.Text = email;
                inptAccountType.Text = accountType;
                inptPhoneNumber.Text = phoneNumber;
                inptAddress.Text = address;

                _selectedAccountID = Convert.ToInt32(selectedAccID);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show($"Are you sure you want to update the selected user's profile?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                //-- NEEDS ERROR HANDLING;
                _controller.EditMemberAccount(
                _selectedAccountID, inptUsername.Text, inptName.Text, inptEmail.Text, inptPhoneNumber.Text, inptAddress.Text, inptAccountType.Text
                    );

                DataGridViewBooksView.DataSource = _controller.GetMembers();
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string search = SearchInput.Text.Trim();

            try
            {
                DataGridViewBooksView.DataSource = _controller.SearchMember(search);
            }
            catch (Exception ex) //Catch block format for error handling
            {
                new WriteErrorLog(ex); //Writes the error to a log at /bin/ErrorLogs
                //Try to following this wording format for the message box
                MessageBox.Show($"Could not refresh, an Error occured. Check logs for more details. \nError:\n {ex}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inptName.Clear();
            inptUsername.Clear();
            inptEmail.Clear();
            inptAccountType.Clear();
            inptPhoneNumber.Clear();
            inptAddress.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMember am = new AddMember(_controller);
            am.Show();
        }
    }
}
