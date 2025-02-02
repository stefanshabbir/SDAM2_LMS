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
        private readonly BorrowController _borrowController;
        private readonly ProfileController _profileController;
        public CompleteBookDetails(ProfileController profileController, BorrowController borrowController)
        {
            InitializeComponent();
            _profileController = profileController;
            _borrowController = borrowController;
        }

        private void CompleteBookDetails_Load_1(object sender, EventArgs e)
        {
            borrowedDataGrid.DataSource = _borrowController.GetBorrowings(_profileController.GetSessionAccount().AccountID);
            borrowedDataGrid.Columns["BookID"].Visible = false;

            reservedDataGrid.DataSource = _borrowController.GetReservations(_profileController.GetSessionAccount().AccountID);
            reservedDataGrid.Columns["BookID"].Visible = false;

            if (!borrowedDataGrid.Columns.Contains("Return"))
            {
                DataGridViewButtonColumn returnColumn = new DataGridViewButtonColumn
                {
                    Name = "Return",
                    HeaderText = "Return",
                    Text = "Return",
                    UseColumnTextForButtonValue = true
                };

                borrowedDataGrid.Columns.Add(returnColumn);
            }

            if (!reservedDataGrid.Columns.Contains("Cancel"))
            {
                DataGridViewButtonColumn cancelColumn = new DataGridViewButtonColumn
                {
                    Name = "Cancel",
                    HeaderText = "Cancel Reservation",
                    Text = "Cancel",
                    UseColumnTextForButtonValue = true
                };

                reservedDataGrid.Columns.Add(cancelColumn);
            }
        }

        private void borrowedDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (borrowedDataGrid.Columns[e.ColumnIndex].Name == "Return")
            {
                var bookID = (int)borrowedDataGrid.Rows[e.RowIndex].Cells["BookID"].Value;

                bool successful = _borrowController.ReturnBook(bookID);
                if (successful)
                {
                    borrowedDataGrid.DataSource = _borrowController.GetBorrowings(_profileController.GetSessionAccount().AccountID);
                }
            }
        }
        private void reservedDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (reservedDataGrid.Columns[e.ColumnIndex].Name == "Cancel")
            {
                var bookID = (int)reservedDataGrid.Rows[e.RowIndex].Cells["BookID"].Value;
                var accID = _profileController.GetSessionAccount().AccountID;

                bool successful = _borrowController.DeleteReservations(bookID, accID);
                if (successful)
                {
                    reservedDataGrid.DataSource = _borrowController.GetReservations(_profileController.GetSessionAccount().AccountID);
                }
            }
        }
    }
}


