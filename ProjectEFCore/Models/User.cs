using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
namespace ProjectEFCore.Models
{
    public class User
    {
        [key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(50)]
        public string? Email { get; set; }
        [MaxLength(50)]
        public string? Password { get; set; }

        [Display(Name = " Image")]
        public byte[]? Img { get; set; }


      

    }
}
