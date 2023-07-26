using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Employee
    {
        private string emp_name;
        private int emp_id;
    

        public Employee(string emp_name, int emp_id)
        {
            
            this.Emp_name = emp_name;
            this.Emp_id = emp_id;
        }

        public string Emp_name { get => emp_name; set => emp_name = value; }
        public int Emp_id { get => emp_id; set => emp_id = value; }

    }
}