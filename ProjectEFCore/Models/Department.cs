using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEFCore.Models
{
    public class Department
    {
        [Key]   
        public int Dept_Id { get; set; }
        [StringLength(255)]
        public string? Dept_Name { get; set; }
        [StringLength(255)]
        public string? Dept_Location { get; set; }
        [ForeignKey("Manager")]
        public int Manager_Id{ get; set; }
        public virtual Instructor? Manager{ get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();


    }
}
