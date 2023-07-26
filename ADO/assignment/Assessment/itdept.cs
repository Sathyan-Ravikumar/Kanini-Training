using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class ItDept : Employee
    {
        double salary;
        static double bonus=10;

        public ItDept(double salary, string emp_name, int emp_id) : base(emp_name, emp_id)
        {
            this.Salary = salary;
            
        }

        public double Salary { get => salary; set => salary = value; }

        public double  salary_bonus()
        {

            return this.Salary * (bonus/ 100); ;
        }
    }
}