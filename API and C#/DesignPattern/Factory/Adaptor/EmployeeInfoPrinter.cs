using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    public class EmployeeInfoPrinter
    {
        public void PrintEmployeeDetails(IEmployeeDetails employee)
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {employee.GetName()}");
            Console.WriteLine($"Position: {employee.GetPosition()}");
            Console.WriteLine($"Salary: {employee.GetSalary()}");
        }

    }
}
