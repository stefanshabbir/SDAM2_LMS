﻿using SDAM2_LMS.Controllers;
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
    public partial class ManageReservations : Form
    {
        private readonly BorrowController _borrowController;

        public ManageReservations(BorrowController borrowController)
        {
            InitializeComponent();
            _borrowController = borrowController;
        }

        private void borrowedBooksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex < 0)
            {
                return;
            };

            if (borrowedBooksDataGrid.Columns[e.ColumnIndex].Name == "Return")
            {
                var bookID = (int)borrowedBooksDataGrid.Rows[e.RowIndex].Cells["BookID"].Value;

                bool successful = _borrowController.ReturnBook(bookID);
                if (successful)
                {
                    borrowedBooksDataGrid.DataSource = _borrowController.GetBorrowings();
                }
            }
            if (borrowedBooksDataGrid.Columns[e.ColumnIndex].Name == "Extend")
            {
                var bookID = (int)borrowedBooksDataGrid.Rows[e.RowIndex].Cells["BookID"].Value;

                bool successful = _borrowController.ExtendBorrowing(bookID);
                if (successful)
                {
                    borrowedBooksDataGrid.DataSource = _borrowController.GetBorrowings();
                }
            }
        }

        private void ManageBorrowed_Load(object sender, EventArgs e)
        {
            borrowedBooksDataGrid.DataSource = _borrowController.GetBorrowings();
            borrowedBooksDataGrid.Columns["BookID"].Visible = false;
            //borrowedBooksDataGrid.Columns["AccountID"].Visible = false;


            if (!borrowedBooksDataGrid.Columns.Contains("Return"))
            {
                DataGridViewButtonColumn returnColumn = new DataGridViewButtonColumn
                {
                    Name = "Return",
                    HeaderText = "Return",
                    Text = "Return",
                    UseColumnTextForButtonValue = true
                };

                borrowedBooksDataGrid.Columns.Add(returnColumn);
            }

            if (!borrowedBooksDataGrid.Columns.Contains("Extend"))
            {
                DataGridViewButtonColumn extendColumn = new DataGridViewButtonColumn
                {
                    Name = "Extend",
                    HeaderText = "Extend Borrow",
                    Text = "Extend",
                    UseColumnTextForButtonValue = true
                };
                borrowedBooksDataGrid.Columns.Add(extendColumn);
            }

            ReservedBooksDataGrid.DataSource = _borrowController.GetReservations();
            ReservedBooksDataGrid.Columns["BookID"].Visible = false;
            ReservedBooksDataGrid.Columns["AccountID"].Visible = false;


            if (!ReservedBooksDataGrid.Columns.Contains("Cancel"))
            {
                DataGridViewButtonColumn cancelColumn = new DataGridViewButtonColumn
                {
                    Name = "Cancel",
                    HeaderText = "Cancel Reservation",
                    Text = "Cancel",
                    UseColumnTextForButtonValue = true
                };

                ReservedBooksDataGrid.Columns.Add(cancelColumn);
            }
        }

        private void ReservedBooksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            };

            if (ReservedBooksDataGrid.Columns[e.ColumnIndex].Name == "Cancel")
            {
                var bookID = (int)ReservedBooksDataGrid.Rows[e.RowIndex].Cells["BookID"].Value;
                var accID = (int)ReservedBooksDataGrid.Rows[e.RowIndex].Cells["AccountID"].Value;

                bool successful = _borrowController.DeleteReservations(bookID, accID);
                if (successful)
                {
                    ReservedBooksDataGrid.DataSource = _borrowController.GetReservations();
                }
            }
        }
    }
}
