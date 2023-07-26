using System;
using System.Collections.Generic;

namespace EfDbApi.Models;

public partial class Emp
{
    public int Empno { get; set; }

    public string? Ename { get; set; }

    public int? Deptno { get; set; }

    public virtual Department? DeptnoNavigation { get; set; }
}
