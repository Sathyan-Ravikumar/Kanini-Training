using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
