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
    public partial class Cros_SessionF : UserControl
    {
        MyContext db = new MyContext();
        public Cros_SessionF()
        {
            InitializeComponent();
            Id.Enabled = false;
            LoadData();
        }
        private void LoadData()
        {
            db.CoursesSessions.Load();
            dataGrid.DataSource = db.CoursesSessions.Local.ToBindingList();
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.Columns["Course"].Visible = false;
            dataGrid.Columns["Instructor"].Visible = false;
            dataGrid.Columns["CourseSessionAttendances"].Visible = false;
        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = dataGrid.CurrentRow.Cells["Id"].Value.ToString();
            Date.Text = dataGrid.CurrentRow.Cells["Date"].Value.ToString();
            Crs_Id.Text = dataGrid.CurrentRow.Cells["Course_Id"].Value.ToString();
            Ins_Id.Text = dataGrid.CurrentRow.Cells["Ins_Id"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["Title"].Value != null)
            {
                Title.Text = dataGrid.CurrentRow.Cells["Title"].Value.ToString();
            }
            else
            {
                Title.Text = string.Empty;
            }
        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Id.Text = dataGrid.CurrentRow.Cells["Id"].Value.ToString();
            Date.Text = dataGrid.CurrentRow.Cells["Date"].Value.ToString();
            Crs_Id.Text = dataGrid.CurrentRow.Cells["Course_Id"].Value.ToString();
            Ins_Id.Text = dataGrid.CurrentRow.Cells["Ins_Id"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["Title"].Value != null)
            {
                Title.Text = dataGrid.CurrentRow.Cells["Title"].Value.ToString();
            }
            else
            {
                Title.Text = string.Empty;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Crs_Id.Text, out int crsId))
            {
                MessageBox.Show("Invalid Course Id");
                return;
            }
            if (!int.TryParse(Ins_Id.Text, out int insId))
            {
                MessageBox.Show("Invalid Instructor Id");
                return;
            }
            string[] date = new string[3];
            date = Date.Text.Split('-');
            if (!int.TryParse(date[0], out int day))
            {
                MessageBox.Show("Invalid Date");
                return;
            }
            if (!int.TryParse(date[1], out int month))
            {
                MessageBox.Show("Invalid Date");
                return;
            }
            if (!int.TryParse(date[2], out int year))
            {
                MessageBox.Show("Invalid Date");
                return;
            }

            CourseSession cs = new CourseSession { Course_Id = crsId, Ins_Id = insId, Date = new DateTime(year, month, day), Title = Title.Text };
            db.Add(cs);
            db.SaveChanges();
            LoadData();
            Id.Clear();
            Crs_Id.Clear();
            Ins_Id.Clear();
            Date.Clear();
            Title.Clear();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Crs_Id.Text, out int crsId))
            {
                MessageBox.Show("Invalid Course Id");
                return;
            }
            if (!int.TryParse(Ins_Id.Text, out int insId))
            {
                MessageBox.Show("Invalid Instructor Id");
                return;
            }
            string[] date = new string[3];
            date = Date.Text.Split('-');
            if (!int.TryParse(date[0], out int day))
            {
                MessageBox.Show("Invalid Date");
                return;
            }
            if (!int.TryParse(date[1], out int month))
            {
                MessageBox.Show("Invalid Date");
                return;
            }
            if (!int.TryParse(date[2], out int year))
            {
                MessageBox.Show("Invalid Date");
                return;
            }

            int id = int.Parse(Id.Text);
            var cs = db.CoursesSessions.Find(id);
            if (cs != null)
            {
                cs.Course_Id = crsId;
                cs.Ins_Id = insId;
                cs.Date = new DateTime(year, month, day);
                cs.Title = Title.Text;
                db.SaveChanges();
                LoadData();
                Id.Clear();
                Crs_Id.Clear();
                Ins_Id.Clear();
                Date.Clear();
                Title.Clear();



            }
        }

          private void btnDelete_Click(object sender, EventArgs e)
          {
            if (Id.Text.IsNullOrEmpty())
            {
                return;
            }
            var result = MessageBox.Show("Are you sure you want to delete this record?",
                                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (!int.TryParse(Id.Text, out int id))
                {
                    MessageBox.Show("Invalid Id");
                    return;
                }
                var cs = db.CoursesSessions.Find(id);
                if (cs != null)
                {
                    db.CoursesSessions.Remove(cs);
                    db.SaveChanges();
                    LoadData();
                    Id.Clear();
                    Crs_Id.Clear();
                    Ins_Id.Clear();
                    Date.Clear();
                    Title.Clear();
                }
            }

        }

    }
}
