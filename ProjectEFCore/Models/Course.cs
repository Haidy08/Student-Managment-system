using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEFCore.Models
{
    public class Course
    {
        [key]
        public int Crs_Id { get; set; }

        [StringLength(255)]
        public string? Course_Name { get; set; }
        public int? Course_Duration { get; set; }

        public int dept_Id { get; set; }
        public virtual Department? Department { get; set; }
        public int ins_Id { get; set; }
        public virtual Instructor? Instructor { get; set; }

        public virtual ICollection<Course_Student> Course_Students { get; set; } = new HashSet<Course_Student>();
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();

    }
}
