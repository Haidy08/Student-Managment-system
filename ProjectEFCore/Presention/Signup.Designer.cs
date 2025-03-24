namespace ProjectEFCore.Presention
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            iconbtn1 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            butbrows = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(57, 306);
            label1.Name = "label1";
            label1.Size = new Size(144, 29);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(57, 439);
            label2.Name = "label2";
            label2.Size = new Size(79, 29);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(57, 579);
            label3.Name = "label3";
            label3.Size = new Size(128, 29);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            textBox1.ForeColor = Color.Navy;
            textBox1.Location = new Point(271, 302);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Your Name";
            textBox1.Size = new Size(529, 49);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            textBox2.ForeColor = Color.Navy;
            textBox2.Location = new Point(271, 435);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Your Email";
            textBox2.Size = new Size(529, 50);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaption;
            textBox3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            textBox3.ForeColor = Color.Navy;
            textBox3.Location = new Point(271, 575);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter Your password";
            textBox3.Size = new Size(529, 50);
            textBox3.TabIndex = 5;
            textBox3.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(596, 670);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(204, 50);
            button1.TabIndex = 6;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // iconbtn1
            // 
            iconbtn1.BackColor = SystemColors.InactiveCaption;
            iconbtn1.BackgroundImageLayout = ImageLayout.Center;
            iconbtn1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconbtn1.IconColor = Color.Black;
            iconbtn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtn1.Location = new Point(720, 579);
            iconbtn1.Name = "iconbtn1";
            iconbtn1.Size = new Size(80, 46);
            iconbtn1.TabIndex = 8;
            iconbtn1.UseVisualStyleBackColor = false;
            iconbtn1.Click += iconButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 0, 64);
            pictureBox1.Location = new Point(388, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // butbrows
            // 
            butbrows.BackColor = SystemColors.GradientActiveCaption;
            butbrows.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            butbrows.ForeColor = Color.Navy;
            butbrows.Location = new Point(57, 111);
            butbrows.Margin = new Padding(3, 4, 3, 4);
            butbrows.Name = "butbrows";
            butbrows.Size = new Size(204, 50);
            butbrows.TabIndex = 11;
            butbrows.Text = "Browse";
            butbrows.UseVisualStyleBackColor = false;
            butbrows.Click += butbrows_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(993, 818);
            Controls.Add(butbrows);
            Controls.Add(pictureBox1);
            Controls.Add(iconbtn1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Signup";
            Text = "Signup";
            Load += Signup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private FontAwesome.Sharp.IconButton iconbtn1;
        private PictureBox pictureBox1;
        private Button butbrows;
    }
}