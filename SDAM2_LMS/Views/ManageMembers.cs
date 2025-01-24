using SDAM2_LMS.Controllers;
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
        private readonly MangeMembersController _controller;
        public ManageMembers()
        {
            InitializeComponent();

            var memberController = new MangeMembersController(new DatabaseContext());
            _controller = memberController;
            var members = _controller.GetMembers();
            DataGridViewBooksView.Rows.Clear();
            DataGridViewBooksView.DataSource = members;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var memberID = DataGridViewBooksView.SelectedRows[0].Cells["PersonalID_Info"].Value.ToString();

                //var confirmation = MessageBox.Show($"Are you sure you want to delete the book with ISBN: {memberID}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //if (confirmation == DialogResult.Yes)
                //{
                //    _controller.DeleteBook(bookId);
                //    DataGridViewBooksView.DataSource = _controller.GetMembers();
                //    MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
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

                string name = selectedRow.Cells["PersonalID_Info"].Value?.ToString();
                string username = selectedRow.Cells["Username"].Value?.ToString();
                string email = selectedRow.Cells["PersonalID_Info"].Value?.ToString();
                string accountType = selectedRow.Cells["AccountType"].Value?.ToString();
                string phoneNumber = selectedRow.Cells["PersonalID_Info"].Value?.ToString();

                inptName.Text = name;
                inptUsername.Text = username;
                inptEmail.Text = email;
                inptAccountType.Text = accountType;
                inptPhoneNumber.Text = phoneNumber;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //var confirmation = MessageBox.Show($"Are you sure you want to update the selected book?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (confirmation == DialogResult.Yes)
            //{
            //    _controller.EditBook(inptUsername.Text, inptName.Text, inptEmail.Text, GenreTextBox.Text, inptPhoneNumber.Text, LanguageTextBox.Text, Convert.ToInt32(inptAccountType.Text));

            //    DataGridViewBooksView.DataSource = _controller.GetBooks();
            //    MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //string search = SearchInput.Text.Trim();

            //try
            //{
            //    DataGridViewBooksView.DataSource = _controller.SearchBook(search);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex}");
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inptName.Clear();
            inptUsername.Clear();
            inptEmail.Clear();
            inptAccountType.Clear();
            inptPhoneNumber.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ////TODO: NEEDS ERROR CHECKING--
            //string title = inptName.Text;
            //string author = inptEmail.Text;
            //string publisher = inptPhoneNumber.Text;
            //string isbn = inptUsername.Text;
            //int quantity = int.Parse(inptAccountType.Text);
            //// --

            //var controller = new BookController(new DatabaseContext());
            //bool bookIsAdded = controller.AddBook(title, author, genre, publisher, language, isbn, quantity);
            //if (bookIsAdded)
            //{
            //    DataGridViewBooksView.DataSource = _controller.GetBooks();
            //    MessageBox.Show("Book Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("An Unexpected error occured, Check error logs. Book couldn't be added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
