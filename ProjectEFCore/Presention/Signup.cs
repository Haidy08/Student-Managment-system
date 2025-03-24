using FontAwesome.Sharp;
using Microsoft.VisualBasic.ApplicationServices;
using ProjectEFCore.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjectEFCore.Presention
{
    public partial class Signup : System.Windows.Forms.Form
    {
        MyContext db = new MyContext();
        private bool isPasswordVisible = false;
        private string selectedImagePath = "";
        public Signup()
        {
            InitializeComponent();

            iconbtn1.IconChar = IconChar.EyeSlash;
            iconbtn1.IconColor = Color.Black;
            iconbtn1.FlatStyle = FlatStyle.Flat;
            iconbtn1.FlatAppearance.BorderSize = 0;
            textBox3.PasswordChar = '*';
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        public byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string pass = textBox3.Text;
         
            //var currentImage = imageSlider1.Images[imageSlider1.CurrentImageIndex];
            //var imageBytes = ImageToByteArray(currentImage);

            var validationResult = ValidateUserData(name, email, pass);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(validationResult.ErrorMessage, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (db)
            {
                var incloudeUser = db.Users.SingleOrDefault(u => u.Email == email);
                if (incloudeUser != null)
                {
                    MessageBox.Show("This email is already in use. Please choose another.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                byte[] imageBytes = selectedImagePath != "" ? File.ReadAllBytes(selectedImagePath) : null;

                var newUser = new Models.User
                {
                    Name = name,
                    Email = email,
                    Password = pass,
                    Img = imageBytes

                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Sign up successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                pictureBox1.Image = null;
                login login = new login();
                login.Show();

                this.Hide();



            }




        }



        private (bool IsValid, string ErrorMessage) ValidateUserData(string name, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return (false, "Name cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                return (false, "Please enter a valid email address.");
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                return (false, "Password must be at least 6 characters long.");
            }

            return (true, null); // Return valid result  
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var add = new System.Net.Mail.MailAddress(email);
                return add.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;


            textBox3.UseSystemPasswordChar = isPasswordVisible;


            iconbtn1.IconChar = isPasswordVisible ? IconChar.Eye : IconChar.EyeSlash;

        }

        private void imageSlider1_Click(object sender, EventArgs e)
        {

        }

        private void butbrows_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    selectedImagePath = openFileDialog.FileName;

                    
                    pictureBox1.Image = Image.FromFile(selectedImagePath);
                }
            }
        }
    }
}
