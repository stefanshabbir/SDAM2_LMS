namespace SDAM2_LMS
{
    partial class LibrarianDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianDashboard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            addNewBooksToolStripMenuItem = new ToolStripMenuItem();
            RemoveBooks = new ToolStripMenuItem();
            EditBooks = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            AddReservations = new ToolStripMenuItem();
            RemoveReservations = new ToolStripMenuItem();
            EditReservations = new ToolStripMenuItem();
            ViewReservations = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            completeBookDetailsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, issueBooksToolStripMenuItem, returnBooksToolStripMenuItem, completeBookDetailsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(746, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewBooksToolStripMenuItem, addNewBooksToolStripMenuItem, RemoveBooks, EditBooks });
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(83, 36);
            booksToolStripMenuItem.Text = "Books";
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Image = (Image)resources.GetObject("viewBooksToolStripMenuItem.Image");
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(152, 22);
            viewBooksToolStripMenuItem.Text = "View Books";
            viewBooksToolStripMenuItem.Click += this.viewBooksToolStripMenuItem_Click;
            // 
            // addNewBooksToolStripMenuItem
            // 
            addNewBooksToolStripMenuItem.Image = (Image)resources.GetObject("addNewBooksToolStripMenuItem.Image");
            addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
            addNewBooksToolStripMenuItem.Size = new Size(152, 22);
            addNewBooksToolStripMenuItem.Text = "Add Books";
            addNewBooksToolStripMenuItem.Click += this.addNewBooksToolStripMenuItem_Click;
            // 
            // RemoveBooks
            // 
            RemoveBooks.Name = "RemoveBooks";
            RemoveBooks.Size = new Size(152, 22);
            RemoveBooks.Text = "Remove Books";
            // 
            // EditBooks
            // 
            EditBooks.Name = "EditBooks";
            EditBooks.Size = new Size(152, 22);
            EditBooks.Text = "Edit Books";
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddReservations, RemoveReservations, EditReservations, ViewReservations });
            issueBooksToolStripMenuItem.Image = (Image)resources.GetObject("issueBooksToolStripMenuItem.Image");
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Size = new Size(117, 36);
            issueBooksToolStripMenuItem.Text = "Reservations";
            // 
            // AddReservations
            // 
            AddReservations.Name = "AddReservations";
            AddReservations.Size = new Size(186, 22);
            AddReservations.Text = "Add Reservations";
            // 
            // RemoveReservations
            // 
            RemoveReservations.Name = "RemoveReservations";
            RemoveReservations.Size = new Size(186, 22);
            RemoveReservations.Text = "Remove Reservations";
            // 
            // EditReservations
            // 
            EditReservations.Name = "EditReservations";
            EditReservations.Size = new Size(186, 22);
            EditReservations.Text = "Edit Reservations";
            // 
            // ViewReservations
            // 
            ViewReservations.Name = "ViewReservations";
            ViewReservations.Size = new Size(186, 22);
            ViewReservations.Text = "View Reservations";
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(121, 36);
            returnBooksToolStripMenuItem.Text = "Return Books";
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            completeBookDetailsToolStripMenuItem.Image = (Image)resources.GetObject("completeBookDetailsToolStripMenuItem.Image");
            completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            completeBookDetailsToolStripMenuItem.Size = new Size(171, 36);
            completeBookDetailsToolStripMenuItem.Text = "Complete Book Details";
            completeBookDetailsToolStripMenuItem.Click += this.completeBookDetailsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(70, 36);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += this.exitToolStripMenuItem_Click;
            // 
            // LibrarianDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(746, 369);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
            Name = "LibrarianDashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBooksToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem RemoveBooks;
        private ToolStripMenuItem EditBooks;
        private ToolStripMenuItem RemoveReservations;
        private ToolStripMenuItem AddReservations;
        private ToolStripMenuItem EditReservations;
        private ToolStripMenuItem ViewReservations;
    }
}