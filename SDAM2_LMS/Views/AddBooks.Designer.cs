namespace SDAM2_LMS
{
    partial class AddBooks
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            lbl_language = new Label();
            inpt_genre = new TextBox();
            lbl_genre = new Label();
            btn_cancel = new Button();
            btn_save = new Button();
            inpt_quantity = new TextBox();
            inpt_isbn = new TextBox();
            inpt_publisher = new TextBox();
            inpt_author = new TextBox();
            inpt_bookTitle = new TextBox();
            lbl_quantity = new Label();
            lbl_isbn = new Label();
            lbl_publisher = new Label();
            lbl_author = new Label();
            lbl_bookTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(188, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 37);
            label1.TabIndex = 0;
            label1.Text = "ADD BOOKS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lbl_language);
            panel2.Controls.Add(inpt_genre);
            panel2.Controls.Add(lbl_genre);
            panel2.Controls.Add(btn_cancel);
            panel2.Controls.Add(btn_save);
            panel2.Controls.Add(inpt_quantity);
            panel2.Controls.Add(inpt_isbn);
            panel2.Controls.Add(inpt_publisher);
            panel2.Controls.Add(inpt_author);
            panel2.Controls.Add(inpt_bookTitle);
            panel2.Controls.Add(lbl_quantity);
            panel2.Controls.Add(lbl_isbn);
            panel2.Controls.Add(lbl_publisher);
            panel2.Controls.Add(lbl_author);
            panel2.Controls.Add(lbl_bookTitle);
            panel2.Location = new Point(47, 71);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 406);
            panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 211);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 18;
            // 
            // lbl_language
            // 
            lbl_language.AutoSize = true;
            lbl_language.Location = new Point(46, 211);
            lbl_language.Margin = new Padding(2, 0, 2, 0);
            lbl_language.Name = "lbl_language";
            lbl_language.Size = new Size(59, 15);
            lbl_language.TabIndex = 17;
            lbl_language.Text = "Language";
            // 
            // inpt_genre
            // 
            inpt_genre.Location = new Point(181, 167);
            inpt_genre.Margin = new Padding(2, 1, 2, 1);
            inpt_genre.Name = "inpt_genre";
            inpt_genre.Size = new Size(234, 23);
            inpt_genre.TabIndex = 16;
            // 
            // lbl_genre
            // 
            lbl_genre.AutoSize = true;
            lbl_genre.Location = new Point(45, 167);
            lbl_genre.Margin = new Padding(2, 0, 2, 0);
            lbl_genre.Name = "lbl_genre";
            lbl_genre.Size = new Size(38, 15);
            lbl_genre.TabIndex = 15;
            lbl_genre.Text = "Genre";
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancel.Location = new Point(325, 345);
            btn_cancel.Margin = new Padding(2, 1, 2, 1);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(90, 26);
            btn_cancel.TabIndex = 14;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.Location = new Point(182, 345);
            btn_save.Margin = new Padding(2, 1, 2, 1);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(101, 26);
            btn_save.TabIndex = 13;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // inpt_quantity
            // 
            inpt_quantity.Location = new Point(182, 300);
            inpt_quantity.Margin = new Padding(2, 1, 2, 1);
            inpt_quantity.Name = "inpt_quantity";
            inpt_quantity.Size = new Size(234, 23);
            inpt_quantity.TabIndex = 11;
            // 
            // inpt_isbn
            // 
            inpt_isbn.Location = new Point(182, 255);
            inpt_isbn.Margin = new Padding(2, 1, 2, 1);
            inpt_isbn.Name = "inpt_isbn";
            inpt_isbn.Size = new Size(234, 23);
            inpt_isbn.TabIndex = 10;
            // 
            // inpt_publisher
            // 
            inpt_publisher.Location = new Point(182, 121);
            inpt_publisher.Margin = new Padding(2, 1, 2, 1);
            inpt_publisher.Name = "inpt_publisher";
            inpt_publisher.Size = new Size(234, 23);
            inpt_publisher.TabIndex = 8;
            // 
            // inpt_author
            // 
            inpt_author.Location = new Point(182, 72);
            inpt_author.Margin = new Padding(2, 1, 2, 1);
            inpt_author.Name = "inpt_author";
            inpt_author.Size = new Size(234, 23);
            inpt_author.TabIndex = 7;
            // 
            // inpt_bookTitle
            // 
            inpt_bookTitle.Location = new Point(182, 26);
            inpt_bookTitle.Margin = new Padding(2, 1, 2, 1);
            inpt_bookTitle.Name = "inpt_bookTitle";
            inpt_bookTitle.Size = new Size(234, 23);
            inpt_bookTitle.TabIndex = 6;
            // 
            // lbl_quantity
            // 
            lbl_quantity.AutoSize = true;
            lbl_quantity.Location = new Point(46, 302);
            lbl_quantity.Margin = new Padding(2, 0, 2, 0);
            lbl_quantity.Name = "lbl_quantity";
            lbl_quantity.Size = new Size(53, 15);
            lbl_quantity.TabIndex = 5;
            lbl_quantity.Text = "Quantity";
            // 
            // lbl_isbn
            // 
            lbl_isbn.AutoSize = true;
            lbl_isbn.Location = new Point(46, 255);
            lbl_isbn.Margin = new Padding(2, 0, 2, 0);
            lbl_isbn.Name = "lbl_isbn";
            lbl_isbn.Size = new Size(32, 15);
            lbl_isbn.TabIndex = 4;
            lbl_isbn.Text = "ISBN";
            // 
            // lbl_publisher
            // 
            lbl_publisher.AutoSize = true;
            lbl_publisher.Location = new Point(46, 124);
            lbl_publisher.Margin = new Padding(2, 0, 2, 0);
            lbl_publisher.Name = "lbl_publisher";
            lbl_publisher.Size = new Size(56, 15);
            lbl_publisher.TabIndex = 2;
            lbl_publisher.Text = "Publisher";
            // 
            // lbl_author
            // 
            lbl_author.AutoSize = true;
            lbl_author.Location = new Point(46, 75);
            lbl_author.Margin = new Padding(2, 0, 2, 0);
            lbl_author.Name = "lbl_author";
            lbl_author.Size = new Size(44, 15);
            lbl_author.TabIndex = 1;
            lbl_author.Text = "Author";
            // 
            // lbl_bookTitle
            // 
            lbl_bookTitle.AutoSize = true;
            lbl_bookTitle.Location = new Point(46, 28);
            lbl_bookTitle.Margin = new Padding(2, 0, 2, 0);
            lbl_bookTitle.Name = "lbl_bookTitle";
            lbl_bookTitle.Size = new Size(59, 15);
            lbl_bookTitle.TabIndex = 0;
            lbl_bookTitle.Text = "Book Title";
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 1, 2, 1);
            Name = "AddBooks";
            Text = "AddBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox inpt_bookTitle;
        private Label lbl_quantity;
        private Label lbl_publisher;
        private Label lbl_author;
        private Label lbl_bookTitle;
        private Button btn_cancel;
        private Button btn_save;
        private TextBox inpt_quantity;
        private TextBox inpt_publisher;
        private TextBox inpt_author;
        private TextBox inpt_isbn;
        private Label lbl_isbn;
        private TextBox inpt_genre;
        private Label lbl_genre;
        private TextBox textBox1;
        private Label lbl_language;
    }
}