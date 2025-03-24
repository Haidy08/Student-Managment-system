using DevExpress.XtraMap.Drawing;
using ProjectEFCore.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEFCore.Presention

{
    public partial class Form1 : System.Windows.Forms.Form
    {
        MyContext db = new MyContext();
        private Models.User currentUser;

        public Form1(Models.User user)
        {
            InitializeComponent();
            //this.studentf3.BringToFront();
            if (user == null)
            {
                MessageBox.Show("User data is missing. Please login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            currentUser = user;
            labUser.Text = currentUser.Name;

            if (currentUser.Img != null)
            {
                using (MemoryStream ms = new MemoryStream(currentUser.Img))
                {
                    pcBox.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pcBox.Image = Properties.Resources.download__5_1;
            }


        }

        private void instructorf1_Load(object sender, EventArgs e)
        {


        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.studentf1.BringToFront();
        }

        private void btncourse_Click(object sender, EventArgs e)
        {
            this.coursf1.BringToFront();
        }

        private void btnSt_Crs_Click(object sender, EventArgs e)
        {
            this.cros_Stuf1.BringToFront();
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            this.departmentf1.BringToFront();
        }

        private void btnCr_Sess_Click(object sender, EventArgs e)
        {
            this.cros_Sessionf1.BringToFront();

        }

        private void btnCr_Sess_Att_Click(object sender, EventArgs e)
        {
            this.crs_Session_Attf1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.userControl12.BringToFront();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            this.instructorf1.BringToFront();
        }

        private void back_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
