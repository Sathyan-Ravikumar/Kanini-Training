
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relation2.Models
{
    public class Emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Empno { get; set; }
        [Required]
        public string Empname { get; set; } = string.Empty;
        
        public int? Deptno { get; set; }

        public virtual Dept? DeptnoNavigation { get; set; }

        
    }
}
