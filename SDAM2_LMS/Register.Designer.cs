namespace SDAM2_LMS
{
    partial class Register
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
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            title = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(52, 169);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(78, 32);
            lbl1.TabIndex = 0;
            lbl1.Text = "Name";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(52, 309);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(162, 32);
            lbl2.TabIndex = 1;
            lbl2.Text = "Email Address";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(52, 457);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(111, 32);
            lbl3.TabIndex = 2;
            lbl3.Text = "Password";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(52, 598);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(204, 32);
            lbl4.TabIndex = 3;
            lbl4.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(451, 39);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(277, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(451, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(277, 450);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(451, 39);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(277, 591);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(451, 39);
            textBox4.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(797, 726);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 8;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Arial Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(365, 9);
            title.Name = "title";
            title.Size = new Size(264, 74);
            title.TabIndex = 9;
            title.Text = "Sign up ";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 852);
            Controls.Add(title);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Label title;
    }
}