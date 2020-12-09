using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaEF
{
   public class Student
    {
        [Key]
        public int studentId { get; set; }
        public string Name { get; set; }

        public virtual Course course { get; set ;}
    }
}
