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
    public partial class StudentF : UserControl
    {
        MyContext db = new MyContext();
        public StudentF()
        {
            InitializeComponent();
            idtxt.Enabled = false;
            LoadData();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtxt.Text = dataGrid.CurrentRow.Cells["St_Id"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["St_FName"].Value != null)
            {
                FNtxt.Text = dataGrid.CurrentRow.Cells["St_FName"].Value.ToString();
            }
            else
            {
                FNtxt.Text = string.Empty;
            }
            if (dataGrid.CurrentRow.Cells["St_LName"].Value != null)
            {
                LNtxt.Text = dataGrid.CurrentRow.Cells["St_LName"].Value.ToString();
            }
            else
            {
                LNtxt.Text = string.Empty;
            }
            if (dataGrid.CurrentRow.Cells["Phone"].Value != null)
            {
                Phontxt.Text = dataGrid.CurrentRow.Cells["Phone"].Value.ToString();
            }
            else
            {
                Phontxt.Text = string.Empty;
            }
        }
        private void LoadData()
        {
            db.Students.Load();
            dataGrid.DataSource = db.Students.Local.ToBindingList();
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.Columns["Course_Students"].Visible = false;
            dataGrid.Columns["CourseSessionAttendances"].Visible = false;
        }

    private void btnInsert_Click(object sender, EventArgs e)
        {
            Student st = new Student { St_FName = FNtxt.Text, St_LName = LNtxt.Text, Phone = Phontxt.Text };
            db.Add(st);
            db.SaveChanges();
            LoadData();

            idtxt.Clear();
            FNtxt.Clear();
            LNtxt.Clear();
            Phontxt.Clear();

        }

    private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtxt.Text);
            var st = db.Students.Find(id);
            st.St_FName = FNtxt.Text;
            st.St_LName = LNtxt.Text;
            st.Phone = Phontxt.Text;
            db.SaveChanges();
            LoadData();
            idtxt.Clear();
            FNtxt.Clear();
            LNtxt.Clear();
            Phontxt.Clear();
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
                var st = db.Students.Find(id);
                if (st != null)
                {
                    db.Remove(st);
                    db.SaveChanges();
                    LoadData();
                    idtxt.Clear();
                    FNtxt.Clear();
                    LNtxt.Clear();
                    Phontxt.Clear();

                }
                else
                {
                    MessageBox.Show("Student Not Found");
                }

            }
        }

    private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idtxt.Text = dataGrid.CurrentRow.Cells["St_Id"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["St_FName"].Value != null)
            {
                FNtxt.Text = dataGrid.CurrentRow.Cells["St_FName"].Value.ToString();
            }
            else
            {
                FNtxt.Text = string.Empty;
            }
            if (dataGrid.CurrentRow.Cells["St_LName"].Value != null)
            {
                LNtxt.Text = dataGrid.CurrentRow.Cells["St_LName"].Value.ToString();
            }
            else
            {
                LNtxt.Text = string.Empty;
            }
            if (dataGrid.CurrentRow.Cells["Phone"].Value != null)
            {
                Phontxt.Text = dataGrid.CurrentRow.Cells["Phone"].Value.ToString();
            }
            else
            {
                Phontxt.Text = string.Empty;
            }
        }
    } 
}
