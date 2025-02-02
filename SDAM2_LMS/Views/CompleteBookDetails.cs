using SDAM2_LMS.Controllers;
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
    public partial class CompleteBookDetails : Form
    {
        private readonly BookController _bookController;
        private readonly ProfileController _profileController;
        public CompleteBookDetails(ProfileController profileController, BookController bookController)
        {
            InitializeComponent();
            _profileController = profileController;
            _bookController = bookController;
        }

        private void CompleteBookDetails_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _bookController.GetBorrowings(_profileController.GetSessionAccount().AccountID);
            dataGridView1.Columns["BookID"].Visible = false;

            if (!dataGridView1.Columns.Contains("Return"))
            {
                DataGridViewButtonColumn returnColumn = new DataGridViewButtonColumn
                {
                    Name = "Return",
                    HeaderText = "Return",
                    Text = "Return",
                    UseColumnTextForButtonValue = true
                };

                dataGridView1.Columns.Add(returnColumn);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Return")
            {
                var bookID = (int)dataGridView1.Rows[e.RowIndex].Cells["BookID"].Value;

                bool successful = _bookController.ReturnBook(bookID);
                if (successful)
                {
                    dataGridView1.DataSource = _bookController.GetBorrowings(_profileController.GetSessionAccount().AccountID);
                }
            }
        }
    }
}


