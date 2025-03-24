using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEFCore.Models
{
    public class Instructor
    {
        [Key]
        public int Ins_Id { get; set; }
        [StringLength(255)]
        public string? Ins_FName { get; set; }
        [StringLength(255)]
        public string? Ins_LName { get; set; }
        [StringLength(255)]
        public string? Phone { get; set; }

        public int? Dept_Id { get; set; }
        public virtual Department? Department { get; set; }

        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();
    }
}
