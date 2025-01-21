using SDAM2_LMS.Controllers;
using SDAM2_LMS.Models.Data;
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
            //TODO: NEEDS ERROR CHECKING--
            string title = inpt_bookTitle.Text;
            string author = inpt_author.Text;
            string genre = inpt_genre.Text;
            string publisher = inpt_publisher.Text;
            string language = inpt_language.Text;
            string isbn = inpt_isbn.Text;
            int quantity = int.Parse(inpt_quantity.Text);
            // --

            var controller = new BookController(new DatabaseContext());
            bool bookIsAdded = controller.AddBook(title, author, genre, publisher, language, isbn, quantity);
            if (bookIsAdded)
            {
                MessageBox.Show("Book Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An Error occured. Book couldn't be added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
