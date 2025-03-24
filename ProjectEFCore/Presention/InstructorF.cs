using Microsoft.EntityFrameworkCore;
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
    public partial class InstructorF : UserControl
    {
        MyContext db = new MyContext();
        public InstructorF()
        {
            InitializeComponent();
            idtxt.Enabled = false;
            LoadData();
        }
        private void LoadData()
        {
            db.Students.Load();
            dataGrid.DataSource = db.Instructors.Local.ToBindingList();
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.Columns["Courses"].Visible = false;
            dataGrid.Columns["CourseSessions"].Visible = false;
            dataGrid.Columns["Department"].Visible = false;
        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtxt.Text = dataGrid.CurrentRow.Cells["Ins_Id"].Value.ToString();
            deptIdtxt.Text = dataGrid.CurrentRow.Cells["Dept_Id"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["Ins_FName"].Value != null)
            {
                FNtxt.Text = dataGrid.CurrentRow.Cells["Ins_FName"].Value.ToString();
            }
            else
            {
                FNtxt.Text = string.Empty;
            }
            if (dataGrid.CurrentRow.Cells["Ins_LName"].Value != null)
            {
                LNtxt.Text = dataGrid.CurrentRow.Cells["Ins_LName"].Value.ToString();
            }
            else
            {
                LNtxt.Text = string.Empty;
            }
            if (dataGrid.CurrentRow.Cells["Phone"].Value != null)
            {
                phontxt.Text = dataGrid.CurrentRow.Cells["Phone"].Value.ToString();
            }
            else
            {
                phontxt.Text = string.Empty;
            }

        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idtxt.Text = dataGrid.CurrentRow.Cells["Ins_Id"].Value.ToString();
            deptIdtxt.Text = dataGrid.CurrentRow.Cells["Dept_Id"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["Ins_FName"].Value != null)
            {
                FNtxt.Text = dataGrid.CurrentRow.Cells["Ins_FName"].Value.ToString();
            }
            else
            {
                FNtxt.Text = string.Empty;
            }
            if (dataGrid.CurrentRow.Cells["Ins_LName"].Value != null)
            {
                LNtxt.Text = dataGrid.CurrentRow.Cells["Ins_LName"].Value.ToString();
            }
            else
            {
                LNtxt.Text = string.Empty;
            }
            if (dataGrid.CurrentRow.Cells["Phone"].Value != null)
            {
                phontxt.Text = dataGrid.CurrentRow.Cells["Phone"].Value.ToString();
            }
            else
            {
                phontxt.Text = string.Empty;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(deptIdtxt.Text, out int deptId))
            {
                MessageBox.Show("Invalid Dept Id");
                return;
            }


            Instructor ins = new Instructor { Ins_FName = FNtxt.Text, Ins_LName = LNtxt.Text, Phone = phontxt.Text, Dept_Id = deptId };
            db.Add(ins);
            db.SaveChanges();
            LoadData();
            idtxt.Clear();
            FNtxt.Clear();
            LNtxt.Clear();
            phontxt.Clear();
            deptIdtxt.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtxt.Text);
            var ins = db.Instructors.Find(id);
            ins.Ins_FName = FNtxt.Text;
            ins.Ins_LName = LNtxt.Text;
            ins.Phone = phontxt.Text;
            db.SaveChanges();
            LoadData();
            idtxt.Clear();
            FNtxt.Clear();
            LNtxt.Clear();
            phontxt.Clear();
            deptIdtxt.Clear();

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
                var ins = db.Instructors.Find(id);
                if (ins != null)
                {
                    db.Remove(ins);
                    db.SaveChanges();
                    LoadData();
                    idtxt.Clear();
                    FNtxt.Clear();
                    LNtxt.Clear();
                    phontxt.Clear();
                    deptIdtxt.Clear();

                }
                else
                {
                    MessageBox.Show("Student Not Found");
                }

            }
        }
    }
}
