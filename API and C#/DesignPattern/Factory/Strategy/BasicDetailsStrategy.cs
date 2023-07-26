using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class BasicDetailsStrategy : IEmployeeDetailsStrategy
    {
        public void DisplayDetails(Employee employee)
        {
            Console.WriteLine($"Employee: {employee.Name}");
        }

    }
}
