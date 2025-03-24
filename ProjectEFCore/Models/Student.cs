using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEFCore.Models
{
    public class Student
    {
        [Key]   
        public int St_Id { get; set; }
        [StringLength(255)]
        public string? St_FName { get; set; }
        [StringLength(255)]
        public string? St_LName { get; set; }
        [StringLength(255)]
        public string? Phone { get; set; }

        public virtual ICollection<Course_Student> Course_Students { get; set; } = new HashSet<Course_Student>();
        public virtual ICollection<CourseSessionAttendance> CourseSessionAttendances { get; set; } = new HashSet<CourseSessionAttendance>();

    }
}
