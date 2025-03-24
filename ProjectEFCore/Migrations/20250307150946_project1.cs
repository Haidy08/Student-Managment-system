
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectEFCore.Migrations
{
    /// <inheritdoc />
    public partial class project1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    St_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    St_FName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    St_LName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.St_Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Crs_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Course_Duration = table.Column<int>(type: "int", nullable: true),
                    dept_Id = table.Column<int>(type: "int", nullable: false),
                    ins_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Crs_Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses_Students",
                columns: table => new
                {
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    St_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses_Students", x => new { x.St_Id, x.Course_Id });
                    table.ForeignKey(
                        name: "FK_Courses_Students_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "Crs_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Students_Students_St_Id",
                        column: x => x.St_Id,
                        principalTable: "Students",
                        principalColumn: "St_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoursesSessionAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CourseSession_Id = table.Column<int>(type: "int", nullable: false),
                    St_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesSessionAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursesSessionAttendances_Students_St_Id",
                        column: x => x.St_Id,
                        principalTable: "Students",
                        principalColumn: "St_Id");
                });

            migrationBuilder.CreateTable(
                name: "CoursesSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Ins_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursesSessions_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "Crs_Id");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Dept_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dept_Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Manager_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Dept_Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Ins_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ins_FName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ins_LName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dept_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Ins_Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_Dept_Id",
                        column: x => x.Dept_Id,
                        principalTable: "Departments",
                        principalColumn: "Dept_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_dept_Id",
                table: "Courses",
                column: "dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ins_Id",
                table: "Courses",
                column: "ins_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Students_Course_Id",
                table: "Courses_Students",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSessionAttendances_CourseSession_Id",
                table: "CoursesSessionAttendances",
                column: "CourseSession_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSessionAttendances_St_Id",
                table: "CoursesSessionAttendances",
                column: "St_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSessions_Course_Id",
                table: "CoursesSessions",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSessions_Ins_Id",
                table: "CoursesSessions",
                column: "Ins_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Manager_Id",
                table: "Departments",
                column: "Manager_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_Id",
                table: "Instructors",
                column: "Dept_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_dept_Id",
                table: "Courses",
                column: "dept_Id",
                principalTable: "Departments",
                principalColumn: "Dept_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_ins_Id",
                table: "Courses",
                column: "ins_Id",
                principalTable: "Instructors",
                principalColumn: "Ins_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesSessionAttendances_CoursesSessions_CourseSession_Id",
                table: "CoursesSessionAttendances",
                column: "CourseSession_Id",
                principalTable: "CoursesSessions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesSessions_Instructors_Ins_Id",
                table: "CoursesSessions",
                column: "Ins_Id",
                principalTable: "Instructors",
                principalColumn: "Ins_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Manager_Id",
                table: "Departments",
                column: "Manager_Id",
                principalTable: "Instructors",
                principalColumn: "Ins_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors");

            migrationBuilder.DropTable(
                name: "Courses_Students");

            migrationBuilder.DropTable(
                name: "CoursesSessionAttendances");

            migrationBuilder.DropTable(
                name: "CoursesSessions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
