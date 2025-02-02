namespace SDAM2_LMS
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            menuStrip1 = new MenuStrip();
            menuBtn_Books = new ToolStripMenuItem();
            menuBtn_Users = new ToolStripMenuItem();
            menuBtn_Reservations = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuBtn_Books, menuBtn_Users, menuBtn_Reservations, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(746, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuBtn_Books
            // 
            menuBtn_Books.CheckOnClick = true;
            menuBtn_Books.Image = (Image)resources.GetObject("menuBtn_Books.Image");
            menuBtn_Books.Name = "menuBtn_Books";
            menuBtn_Books.Size = new Size(83, 36);
            menuBtn_Books.Text = "Books";
            menuBtn_Books.Click += menuBtn_Books_Click;
            // 
            // menuBtn_Users
            // 
            menuBtn_Users.CheckOnClick = true;
            menuBtn_Users.Name = "menuBtn_Users";
            menuBtn_Users.Size = new Size(47, 36);
            menuBtn_Users.Text = "Users";
            menuBtn_Users.Click += menuBtn_Users_Click;
            // 
            // menuBtn_Reservations
            // 
            menuBtn_Reservations.Image = (Image)resources.GetObject("menuBtn_Reservations.Image");
            menuBtn_Reservations.Name = "menuBtn_Reservations";
            menuBtn_Reservations.Size = new Size(117, 36);
            menuBtn_Reservations.Text = "Reservations";
            menuBtn_Reservations.Click += menuBtn_Reservations_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(70, 36);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // AdminDashboard
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
            Name = "AdminDashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuBtn_Books;
        private ToolStripMenuItem menuBtn_Users;
        private ToolStripMenuItem menuBtn_Reservations;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}