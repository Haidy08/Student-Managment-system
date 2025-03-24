using Microsoft.IdentityModel.Tokens;
using ProjectEFCore.Context;
using ProjectEFCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ProjectEFCore.Presention
{
    public partial class Cros_StuF : System.Windows.Forms.UserControl
    {
        MyContext db = new MyContext();
        public Cros_StuF()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            db.Courses_Students.ToList();
            dataGrid.DataSource = db.Courses_Students.Local.ToBindingList();
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.Columns["Course"].Visible = false;
            dataGrid.Columns["Student"].Visible = false;
        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            St_Id.Text = dataGrid.CurrentRow.Cells["St_Id"].Value.ToString();
            Crs_Id.Text = dataGrid.CurrentRow.Cells["Course_Id"].Value.ToString();


        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            St_Id.Text = dataGrid.CurrentRow.Cells["St_Id"].Value.ToString();
            Crs_Id.Text = dataGrid.CurrentRow.Cells["Course_Id"].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(St_Id.Text, out int StId))
            {
                MessageBox.Show("Please Enter Valid Student Id");
                return;
            }
            if (!int.TryParse(Crs_Id.Text, out int CrsId))
            {
                MessageBox.Show("Please Enter Valid course Id");
                return;
            }
            Course_Student Crs_St = new Course_Student
            {
                St_Id = StId,
                Course_Id = CrsId
            };
            db.Courses_Students.Add(Crs_St);
            db.SaveChanges();
            LoadData();
            St_Id.Clear();
            Crs_Id.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(St_Id.Text, out int StId))
            {
                MessageBox.Show("Please Enter Valid Student Id");
                return;
            }
            if (!int.TryParse(Crs_Id.Text, out int CrsId))
            {
                MessageBox.Show("Please Enter Valid course Id");
                return;
            }
            var cs = db.Courses_Students.FirstOrDefault(cs => cs.St_Id == StId && cs.Course_Id == CrsId);
            cs.St_Id = StId;
            cs.Course_Id = CrsId;
            db.SaveChanges();
            LoadData();
            St_Id.Clear();
            Crs_Id.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Crs_Id.Text.IsNullOrEmpty() || St_Id.Text.IsNullOrEmpty())
            {
                return;
            }
            var result = MessageBox.Show("Are you sure you want to delete this record?",
                                 "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (!int.TryParse(Crs_Id.Text, out int crsId))
                {
                    MessageBox.Show("Invalid Course Id");
                    return;
                }
                if (!int.TryParse(St_Id.Text, out int studId))
                {
                    MessageBox.Show("Invalid Student Id");
                    return;
                }
                var cs = db.Courses_Students.FirstOrDefault(cs => cs.Course_Id == crsId && cs.St_Id == studId);
                if (cs != null)
                {
                    db.Remove(cs);
                    db.SaveChanges();
                    LoadData();
                    St_Id.Clear();
                    Crs_Id.Clear();
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }

    }
}
