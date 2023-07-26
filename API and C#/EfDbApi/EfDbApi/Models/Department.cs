using System;
using System.Collections.Generic;

namespace EfDbApi.Models;

public partial class Department
{
    public int Deptno { get; set; }

    public string? Deptname { get; set; }

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();
}
