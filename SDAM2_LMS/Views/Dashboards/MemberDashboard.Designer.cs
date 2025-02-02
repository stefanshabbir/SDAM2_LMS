namespace SDAM2_LMS
{
    partial class MemberDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDashboard));
            menuStrip1 = new MenuStrip();
            menuBtn_ViewBooks = new ToolStripMenuItem();
            menuBtn_BorrowedReserved = new ToolStripMenuItem();
            menuBtn_ViewProfile = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuBtn_ViewBooks, menuBtn_BorrowedReserved, menuBtn_ViewProfile, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(746, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuBtn_ViewBooks
            // 
            menuBtn_ViewBooks.Image = (Image)resources.GetObject("menuBtn_ViewBooks.Image");
            menuBtn_ViewBooks.Name = "menuBtn_ViewBooks";
            menuBtn_ViewBooks.Size = new Size(111, 36);
            menuBtn_ViewBooks.Text = "View Books";
            menuBtn_ViewBooks.Click += menuBtn_ViewBooks_Click;
            // 
            // menuBtn_BorrowedReserved
            // 
            menuBtn_BorrowedReserved.Image = (Image)resources.GetObject("menuBtn_BorrowedReserved.Image");
            menuBtn_BorrowedReserved.Name = "menuBtn_BorrowedReserved";
            menuBtn_BorrowedReserved.Size = new Size(189, 36);
            menuBtn_BorrowedReserved.Text = "Borrowed/Reserved Books";
            menuBtn_BorrowedReserved.Click += menuBtn_BorrowedReserved_Click;
            // 
            // menuBtn_ViewProfile
            // 
            menuBtn_ViewProfile.Image = (Image)resources.GetObject("menuBtn_ViewProfile.Image");
            menuBtn_ViewProfile.Name = "menuBtn_ViewProfile";
            menuBtn_ViewProfile.Size = new Size(113, 36);
            menuBtn_ViewProfile.Text = "View Profile";
            menuBtn_ViewProfile.Click += menuBtn_ViewProfile_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(70, 36);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(32, 19);
            // 
            // MemberDashboard
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
            Name = "MemberDashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuBtn_BorrowedReserved;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem menuBtn_ViewProfile;
        private ToolStripMenuItem menuBtn_ViewBooks;
    }
}