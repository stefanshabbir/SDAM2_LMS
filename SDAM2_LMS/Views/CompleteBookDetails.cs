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
        private readonly SessionService _sessionService;
        public CompleteBookDetails(BorrowController borrowController, SessionService sessionService)
        {
            InitializeComponent();
            _borrowController = borrowController;
            _sessionService = sessionService;
        }

        private void CompleteBookDetails_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _borrowController.GetBorrowings(_sessionService.LoggedInAccount.AccountID);
            dataGridView1.Columns["BookID"].Visible = false;
        }
    }
}


