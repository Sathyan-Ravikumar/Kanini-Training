using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FullDetailsStrategy : IEmployeeDetailsStrategy
    {
        public void DisplayDetails(Employee employee)
        {
            Console.WriteLine($"Employee: {employee.Name}");
            Console.WriteLine($"Department: {employee.Department}");
            Console.WriteLine($"Position: {employee.Position}");
            Console.WriteLine($"Salary: {employee.Salary}");
        }

    }
}
