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
using System.Windows.Forms;

namespace ProjectEFCore.Presention
{
    public partial class CoursF : UserControl
    {
        MyContext db = new MyContext();
        public CoursF()
        {
            InitializeComponent();
            idtxt.Enabled = false;
            LoadData();
        }
        private void LoadData()
        {
            db.Courses.ToList();
            dataGrid.DataSource = db.Courses.Local.ToBindingList();
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.Columns["Instructor"].Visible = false;
            dataGrid.Columns["CourseSessions"].Visible = false;
            dataGrid.Columns["Course_Students"].Visible = false;
            dataGrid.Columns["Department"].Visible = false;

        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtxt.Text = dataGrid.CurrentRow.Cells["Crs_Id"].Value.ToString();
            Dept_Idtxt.Text = dataGrid.CurrentRow.Cells["dept_Id"].Value.ToString();
            Ins_Idtxt.Text = dataGrid.CurrentRow.Cells["ins_Id"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["Course_Name"].Value != null)
            {
                Ntxt.Text = dataGrid.CurrentRow.Cells["Course_Name"].Value.ToString();
            }
            else
            {
                Ntxt.Text = string.Empty;
            }
            if (dataGrid.CurrentRow.Cells["Course_Duration"].Value != null)
            {
                Durtxt.Text = dataGrid.CurrentRow.Cells["Course_Duration"].Value.ToString();
            }
            else
            {
                Durtxt.Text = string.Empty;
            }


        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idtxt.Text = dataGrid.CurrentRow.Cells["Crs_Id"].Value.ToString();
            Dept_Idtxt.Text = dataGrid.CurrentRow.Cells["dept_Id"].Value.ToString();
            Ins_Idtxt.Text = dataGrid.CurrentRow.Cells["ins_Id"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["Course_Name"].Value != null)
            {
                Ntxt.Text = dataGrid.CurrentRow.Cells["Course_Name"].Value.ToString();
            }
            else
            {
                Ntxt.Text = string.Empty;
            }
            if (dataGrid.CurrentRow.Cells["Course_Duration"].Value != null)
            {
                Durtxt.Text = dataGrid.CurrentRow.Cells["Course_Duration"].Value.ToString();
            }
            else
            {
                Durtxt.Text = string.Empty;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Dept_Idtxt.Text, out int deptId))
            {
                MessageBox.Show("Invalid Dept Id");
                return;
            }
            if (!int.TryParse(Ins_Idtxt.Text, out int insId))
            {
                MessageBox.Show("Invalid Instructor Id");
                return;
            }
            if (!int.TryParse(Durtxt.Text, out int duration))
            {
                MessageBox.Show("Invalid Duration");
                return;
            }
            Course crs = new Course { Course_Name = Ntxt.Text, Course_Duration = duration, dept_Id = deptId, ins_Id = insId };
            db.Courses.Add(crs);
            db.SaveChanges();
            LoadData();
            idtxt.Clear();
            Ntxt.Clear();
            Durtxt.Clear();
            Dept_Idtxt.Clear();
            Ins_Idtxt.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Dept_Idtxt.Text, out int deptId))
            {
                MessageBox.Show("Invalid Dept Id");
                return;
            }
            if (!int.TryParse(Ins_Idtxt.Text, out int insId))
            {
                MessageBox.Show("Invalid Instructor Id");
                return;
            }
            if (!int.TryParse(Durtxt.Text, out int duration))
            {
                MessageBox.Show("Invalid Duration");
                return;
            }
            int id = int.Parse(idtxt.Text);
            var crs = db.Courses.Find(id);
            if (crs != null)
            {
                crs.ins_Id = insId;
                crs.dept_Id = deptId;
                crs.Course_Duration = duration;
                crs.Course_Name = Ntxt.Text;
                db.SaveChanges();
                LoadData();
                idtxt.Clear();
                Ntxt.Clear();
                Durtxt.Clear();
                Dept_Idtxt.Clear();
                Ins_Idtxt.Clear();

            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idtxt.Text.IsNullOrEmpty())
            { return; }
            var result = MessageBox.Show("Are you sure you want to delete this record?",
                                 "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int id = int.Parse(idtxt.Text);
                var crs = db.Courses.Find(id);
                if (crs != null)
                {
                    db.Remove(crs);
                    db.SaveChanges();
                    LoadData();
                    idtxt.Clear();
                    Ntxt.Clear();
                    Durtxt.Clear();
                    Dept_Idtxt.Clear();
                    Ins_Idtxt.Clear();

                }
                else
                {
                    MessageBox.Show("Student Not Found");
                }
            }
        }
    }
}
