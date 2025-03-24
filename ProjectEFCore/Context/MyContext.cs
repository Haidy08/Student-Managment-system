using Microsoft.EntityFrameworkCore;
using ProjectEFCore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEFCore.Context
{
    public class MyContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Msi;Database=EFCoreProject;Trusted_Connection=True; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
            .HasKey(c => c.Crs_Id);


            modelBuilder.Entity<Course_Student>()
            .HasKey(c => new { c.St_Id, c.Course_Id });

            modelBuilder.Entity<Instructor>()
          .HasOne(t => t.Department)
          .WithMany(c => c.Instructors)
          .HasForeignKey(t => t.Dept_Id)
          .IsRequired(false)
           .OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<Course>()
          .HasOne(t => t.Department)
          .WithMany(c => c.Courses)
          .HasForeignKey(t => t.dept_Id)
          .IsRequired(false);
          

            modelBuilder.Entity<Course>()
          .HasOne(t => t.Instructor)
          .WithMany(c => c.Courses)
          .HasForeignKey(t => t.ins_Id)
          .IsRequired(false)
              .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CourseSession>()
          .HasOne(t => t.Course)
          .WithMany(c => c.CourseSessions)
          .HasForeignKey(t => t.Course_Id)
          .IsRequired(false);
              

            modelBuilder.Entity<CourseSession>()
          .HasOne(t => t.Instructor)
          .WithMany(c => c.CourseSessions)
          .HasForeignKey(t => t.Ins_Id)
          .IsRequired(false)
              .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CourseSessionAttendance>()
            .HasOne(t => t.CourseSession)
            .WithMany(c => c.CourseSessionAttendances)
            .HasForeignKey(t => t.CourseSession_Id)
            .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CourseSessionAttendance>()
            .HasOne(t => t.Student)
            .WithMany(c => c.CourseSessionAttendances)
            .HasForeignKey(t => t.St_Id)
            .IsRequired(false);
                


            base.OnModelCreating(modelBuilder);
        }

        


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public  DbSet<Course_Student> Courses_Students { get;set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<CourseSession> CoursesSessions { get; set; }
        public DbSet<CourseSessionAttendance> CoursesSessionAttendances { get; set; }

        public DbSet<User> Users { get; set; }











    }
}
