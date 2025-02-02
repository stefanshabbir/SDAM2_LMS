using SDAM2_LMS.Controllers;
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
    public partial class ManageBorrowed : Form
    {
        private readonly BorrowController _borrowController;

        public ManageBorrowed(BorrowController borrowController)
        {
            InitializeComponent();
            _borrowController = borrowController;
        }

        private void borrowedBooksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void ManageBorrowed_Load(object sender, EventArgs e)
        {
            borrowedBooksDataGrid.DataSource = _borrowController.GetBorrowings();
            borrowedBooksDataGrid.Columns["BookID"].Visible = false;


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

            ReservedBooksDataGrid.DataSource = _borrowController.GetReservations();
            ReservedBooksDataGrid.Columns["BookID"].Visible = false;

            

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

        }
    }
}
