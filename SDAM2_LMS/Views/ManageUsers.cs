using SDAM2_LMS.Controllers;
using SDAM2_LMS.ErrorLog;
using SDAM2_LMS.Models.Data;
using SDAM2_LMS.Models.Services;
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
    public partial class ManageUsers : Form
    {
        private Int32 _selectedAccountID { get; set; }
        private readonly UsersController _controller;

        public ManageUsers(UsersController userController)
        {
            InitializeComponent();

            _controller = userController;

            DataGridViewBooksView.Rows.Clear();
            DataGridViewBooksView.DataSource = _controller.GetUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var username = DataGridViewBooksView.SelectedRows[0].Cells["Username"].Value.ToString();

            var confirmation = MessageBox.Show($"Are you sure you want to delete {username}'s account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                _controller.DeleteUser(_selectedAccountID);
                DataGridViewBooksView.DataSource = _controller.GetUsers();
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
                string phoneNumber = selectedRow.Cells["PhoneNumber"].Value?.ToString();
                string address = selectedRow.Cells["Address"].Value?.ToString();
                string selectedAccID = selectedRow.Cells["AccountID"].Value?.ToString();
                string accountType = selectedRow.Cells["AccountTypeName"].Value?.ToString();

                inptUsername.Text = username;
                inptName.Text = name;
                inptEmail.Text = email;
                inputAccountType.Text = accountType;
                inptPhoneNumber.Text = phoneNumber;
                inptAddress.Text = address;

                _selectedAccountID = Convert.ToInt32(selectedAccID);

                inputAccountType.Items.Clear();
                inputAccountType.Items.Add("Admin");
                inputAccountType.Items.Add("Librarian");
                inputAccountType.Items.Add("Member");

                inputAccountType.SelectedItem = accountType switch
                {
                    "Admin" => inputAccountType.SelectedItem = "Admin",
                    "Librarian" => inputAccountType.SelectedItem = "Librarian",
                    "Member" => inputAccountType.SelectedItem = "Member",
                    _ => inputAccountType.SelectedItem = "Member" //default value
                };
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show($"Are you sure you want to update the selected user's profile?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {

                _controller.EditUser
                    (
                _selectedAccountID, inptUsername.Text,
                inptName.Text, inptEmail.Text,
                inptPhoneNumber.Text, inptAddress.Text,
                inputAccountType.SelectedItem.ToString()
                    );

                DataGridViewBooksView.DataSource = _controller.GetUsers();
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string search = SearchInput.Text.Trim();
            DataGridViewBooksView.DataSource = _controller.SearchUser(search);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inptName.Clear();
            inptUsername.Clear();
            inptEmail.Clear();
            inputAccountType.Items.Clear();
            inptPhoneNumber.Clear();
            inptAddress.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser am = new AddUser(_controller);
            am.Show();
        }
    }
}
