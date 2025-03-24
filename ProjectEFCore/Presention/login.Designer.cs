namespace ProjectEFCore.Presention
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            button1 = new Button();
            emailtxt = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            iconbtn2 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(266, 369);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(204, 52);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = Color.LightSteelBlue;
            emailtxt.Location = new Point(165, 122);
            emailtxt.Margin = new Padding(3, 2, 3, 2);
            emailtxt.Multiline = true;
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(425, 42);
            emailtxt.TabIndex = 1;
            // 
            // password
            // 
            password.BackColor = Color.LightSteelBlue;
            password.Location = new Point(165, 255);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(425, 42);
            password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(139, 61);
            label1.Name = "label1";
            label1.Size = new Size(99, 41);
            label1.TabIndex = 3;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 15F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(113, 198);
            label2.Name = "label2";
            label2.Size = new Size(142, 41);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Script", 15F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(76, 512);
            label3.Name = "label3";
            label3.Size = new Size(336, 41);
            label3.TabIndex = 5;
            label3.Text = "I don't have an account";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe Script", 15F, FontStyle.Bold);
            button2.ForeColor = Color.AliceBlue;
            button2.Location = new Point(439, 506);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(151, 52);
            button2.TabIndex = 6;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // iconbtn2
            // 
            iconbtn2.BackColor = SystemColors.ActiveCaption;
            iconbtn2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconbtn2.IconColor = Color.Black;
            iconbtn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtn2.Location = new Point(510, 255);
            iconbtn2.Name = "iconbtn2";
            iconbtn2.Size = new Size(80, 42);
            iconbtn2.TabIndex = 7;
            iconbtn2.UseVisualStyleBackColor = false;
            iconbtn2.Click += iconbtn2_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(823, 678);
            Controls.Add(iconbtn2);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(emailtxt);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "login";
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox emailtxt;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private FontAwesome.Sharp.IconButton iconbtn2;
    }
}