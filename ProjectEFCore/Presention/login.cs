using DevExpress.XtraMap.Drawing;
using FontAwesome.Sharp;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Crypto.Generators;
using ProjectEFCore.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEFCore.Presention
{
    public partial class login : System.Windows.Forms.Form
    {
        MyContext db = new MyContext();
        private bool isPasswordVisible = false;
        public login()
        {
            InitializeComponent();
            iconbtn2.IconChar = IconChar.EyeSlash;
            iconbtn2.IconColor = Color.Black;
            iconbtn2.FlatStyle = FlatStyle.Flat;
            iconbtn2.FlatAppearance.BorderSize = 0;
            password.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailtxt.Text.Trim().ToLower();
            string pass = password.Text;

           
            if (email.IsNullOrEmpty() || pass.IsNullOrEmpty())
            {
                MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var user = db.Users.SingleOrDefault(u =>  u.Email.ToLower() == email);

                if (user == null)
                {
                    MessageBox.Show("User not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
              

                if (user != null && user.Password == pass)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 form = new Form1(user);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Signup s = new Signup();
            s.Show();

            this.Hide();

        }

        private void iconbtn2_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;


            password.UseSystemPasswordChar = isPasswordVisible;


            iconbtn2.IconChar = isPasswordVisible ? IconChar.Eye : IconChar.EyeSlash;
        }
    }


}
