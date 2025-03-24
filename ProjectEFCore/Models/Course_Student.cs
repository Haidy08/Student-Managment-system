using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEFCore.Models
{
    public class Course_Student
    {

        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        [ForeignKey("Student")]
        public int St_Id { get; set; }

        public virtual Student? Student { get; set; }
        public virtual Course? Course { get; set; }
    }
}
