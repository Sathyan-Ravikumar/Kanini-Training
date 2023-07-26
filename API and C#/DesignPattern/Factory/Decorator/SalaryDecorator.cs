using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SalaryDecorator :EmployeeDetailsDecorator

    {
        private decimal salary;

        public SalaryDecorator(IEmployeeDetails employee, decimal salary) : base(employee)
        {
            this.salary = salary;
        }

        public override string GetDetails()
        {
            string baseDetails = base.GetDetails();
            return $"{baseDetails}, Salary: {salary:C}";
        }

    }
}
