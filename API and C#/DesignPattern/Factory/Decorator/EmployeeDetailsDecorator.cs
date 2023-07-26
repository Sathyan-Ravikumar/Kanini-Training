using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class EmployeeDetailsDecorator : IEmployeeDetails
    {
        protected IEmployeeDetails decoratedEmployee;

        public EmployeeDetailsDecorator(IEmployeeDetails employee)
        {
            decoratedEmployee = employee;
        }

        public virtual string GetDetails()
        {
            return decoratedEmployee.GetDetails();
        }

    }
}
