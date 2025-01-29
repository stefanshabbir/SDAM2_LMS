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
    public partial class CompleteBookDetails : Form
    {
        private readonly BorrowController _borrowController;
        public CompleteBookDetails(BorrowController borrowController)
        {
            InitializeComponent();
            _borrowController = borrowController;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = _borrowController.GetBorrowedBooks();
        }
    }
}
