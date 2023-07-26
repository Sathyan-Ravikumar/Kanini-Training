using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public void ChangeDepartment(string newDepartment)
        {
            Console.WriteLine($"Changing department of employee {Name} from {Department} to {newDepartment}");
            Department = newDepartment;
        }

    }
}
