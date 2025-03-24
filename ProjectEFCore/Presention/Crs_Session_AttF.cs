using DevExpress.Xpo;
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
    public partial class Crs_Session_AttF : UserControl
    {
        MyContext db = new MyContext();
        public Crs_Session_AttF()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            db.CoursesSessionAttendances.ToList();
            dataGrid.DataSource = db.CoursesSessionAttendances.Local.ToBindingList();
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.Columns["CourseSession"].Visible = false;
            dataGrid.Columns["Student"].Visible = false;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = dataGrid.CurrentRow.Cells["Id"].Value.ToString();
            Grade.Text = dataGrid.CurrentRow.Cells["Grade"].Value.ToString();
            Crs_Sess_Id.Text = dataGrid.CurrentRow.Cells["CourseSession_Id"].Value.ToString();
            St_Id.Text = dataGrid.CurrentRow.Cells["St_Id"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["Note"].Value != null)

            {
                Note.Text = dataGrid.CurrentRow.Cells["Note"].Value.ToString();
            }

            else
            {
                Note.Text = string.Empty;
            }
        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id.Text = dataGrid.CurrentRow.Cells["Id"].Value.ToString();
            Grade.Text = dataGrid.CurrentRow.Cells["Grade"].Value.ToString();
            Crs_Sess_Id.Text = dataGrid.CurrentRow.Cells["CourseSession_Id"].Value.ToString();
            St_Id.Text = dataGrid.CurrentRow.Cells["St_Id"].Value.ToString();
            if (dataGrid.CurrentRow.Cells["Note"].Value != null)

            {
                Note.Text = dataGrid.CurrentRow.Cells["Note"].Value.ToString();
            }

            else
            {
                Note.Text = string.Empty;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Crs_Sess_Id.Text, out int CrsSessionId))
            {
                MessageBox.Show("Invalid Session Id");
                return;
            }
            if (!int.TryParse(St_Id.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student Id");
                return;
            }
            if (!int.TryParse(Grade.Text, out int grade))
            {
                MessageBox.Show("Invalid Grade");
                return;
            }
            CourseSessionAttendance att = new CourseSessionAttendance { CourseSession_Id = CrsSessionId, St_Id = studentId, Grade = grade, Note = Note.Text };
            db.Add(att);
            db.SaveChanges();
            LoadData();
            Grade.Clear();
            Crs_Sess_Id.Clear();
            St_Id.Clear();
            Note.Clear();
            Id.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Crs_Sess_Id.Text, out int CrsSessionId))
            {
                MessageBox.Show("Invalid Session Id");
                return;
            }
            if (!int.TryParse(St_Id.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student Id");
                return;
            }
            if (!int.TryParse(Grade.Text, out int grade))
            {
                MessageBox.Show("Invalid Grade");
                return;
            }
            int attId = int.Parse(Id.Text);
            var att1 = db.CoursesSessionAttendances.Find(attId);
            att1.CourseSession_Id = CrsSessionId;
            att1.St_Id = studentId;
            att1.Grade = grade;
            att1.Note = Note.Text;
            db.SaveChanges();
            LoadData();
            Grade.Clear();
            Crs_Sess_Id.Clear();

            St_Id.Clear();
            Note.Clear();
            Id.Clear();

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
                int attId = int.Parse(Id.Text);
                var att1 = db.CoursesSessionAttendances.Find(attId);
                if (att1 != null)
                {
                    db.Remove(att1);
                    db.SaveChanges();
                    LoadData();
                    Grade.Clear();
                    Crs_Sess_Id.Clear();
                    St_Id.Clear();
                    Note.Clear();
                    Id.Clear();

                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }
    }
}
