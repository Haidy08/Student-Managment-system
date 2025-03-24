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
    public partial class DepartmentF : UserControl
    {
        MyContext db = new MyContext();
        public DepartmentF()
        {
            InitializeComponent();
            idtxt.Enabled = false;
            LoadData();
        }
        private void LoadData()
        {
            db.Departments.Load();
            dataGrid.DataSource = db.Departments.Local.ToBindingList();
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.Columns["Courses"].Visible = false;
            dataGrid.Columns["Instructors"].Visible = false;
            dataGrid.Columns["Manager"].Visible = false;
        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtxt.Text = dataGrid.CurrentRow.Cells["Dept_Id"].Value.ToString();
            Managetxt.Text = dataGrid.CurrentRow.Cells["Manager_Id"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["Dept_Name"].Value != null)
            {
                Ntxt.Text = dataGrid.CurrentRow.Cells["Dept_Name"].Value.ToString();
            }
            else
            {
                Ntxt.Text = string.Empty;
            }
            if (dataGrid.CurrentRow.Cells["Dept_Location"].Value != null)
            {
                Ltxt.Text = dataGrid.CurrentRow.Cells["Dept_Location"].Value.ToString();
            }
            else
            {
                Ltxt.Text = string.Empty;
            }
        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idtxt.Text = dataGrid.CurrentRow.Cells["Dept_Id"].Value.ToString();
            Managetxt.Text = dataGrid.CurrentRow.Cells["Manager_Id"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["Dept_Name"].Value != null)
            {
                Ntxt.Text = dataGrid.CurrentRow.Cells["Dept_Name"].Value.ToString();
            }
            else
            {
                Ntxt.Text = string.Empty;
            }
            if (dataGrid.CurrentRow.Cells["Dept_Location"].Value != null)
            {
                Ltxt.Text = dataGrid.CurrentRow.Cells["Dept_Location"].Value.ToString();
            }
            else
            {
                Ltxt.Text = string.Empty;
            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Managetxt.Text, out int managId))
            {
                MessageBox.Show("Invalid Manager Id");
                return;
            }

            Department dept = new Department { Dept_Name = Ntxt.Text, Dept_Location = Ltxt.Text, Manager_Id = managId };
            db.Departments.Add(dept);
            db.SaveChanges();
            LoadData();
            idtxt.Clear();
            Ntxt.Clear();
            Ltxt.Clear();
            Managetxt.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Managetxt.Text, out int managId))
            {
                MessageBox.Show("Invalid Manager Id");
                return;
            }
            int id = int.Parse(idtxt.Text);
            var d = db.Departments.Find(id);
            d.Dept_Name = Ntxt.Text;
            d.Dept_Location = Ltxt.Text;
            d.Manager_Id = managId;
            db.SaveChanges();
            LoadData();
            idtxt.Clear();
            Ntxt.Clear();
            Ltxt.Clear();
            Managetxt.Clear();

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (idtxt.Text.IsNullOrEmpty())
            {
                return;
            }
            var result = MessageBox.Show("Are you sure you want to delete this record?",
                                 "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int id = int.Parse(idtxt.Text);
                var d = db.Departments.Find(id);
                db.Departments.Remove(d);
                db.SaveChanges();
                LoadData();
                idtxt.Clear();
                Ntxt.Clear();
                Ltxt.Clear();
                Managetxt.Clear();
            }

        }
    }
}
  
