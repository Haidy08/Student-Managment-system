using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEFCore.Models
{
    public class CourseSession
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [StringLength(255)]
        public string? Title { get; set; }
        public int Course_Id { get; set; }
        public virtual Course? Course { get; set; }

        public int Ins_Id { get; set; }

        public virtual Instructor? Instructor { get; set; }
        public virtual ICollection<CourseSessionAttendance> CourseSessionAttendances { get; set; } = new HashSet<CourseSessionAttendance>();
    }
}
