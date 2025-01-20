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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // NO ERROR CHECKING--
            string title = inpt_bookTitle.Text;
            string author = inpt_author.Text;
            string genre = inpt_genre.Text;
            string publisher = inpt_publisher.Text;
            string language = inpt_language.Text;
            string isbn = inpt_isbn.Text;
            int quantity = int.TryParse(inpt_quantity);
            // --
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
