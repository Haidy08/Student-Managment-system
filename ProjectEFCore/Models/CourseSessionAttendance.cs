using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEFCore.Models
{
    public class CourseSessionAttendance
    {
        [key]
        public int Id { get; set; }
        public int? Grade { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        public int CourseSession_Id { get; set; }
        public virtual CourseSession? CourseSession { get; set; }

        public int St_Id { get; set; }
        public virtual Student? Student { get; set; }

    }
}
