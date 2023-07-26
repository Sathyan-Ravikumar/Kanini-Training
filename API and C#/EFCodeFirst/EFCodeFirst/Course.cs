using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int CourseID { get; set; }
        public string Name { get; set; }
    }
}
