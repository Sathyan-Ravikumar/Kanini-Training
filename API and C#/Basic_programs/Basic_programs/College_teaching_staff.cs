 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class College_teaching_staff : College
    {
        private int eid;
        private string name,department,favsub;
        private double salary;

        public College_teaching_staff(string collegename, string address, int pincode,int eid, string name, string department, string favsub, double salary)
            :base(collegename,address,pincode)
        {
            this.Eid = eid;
            this.Name = name;
            this.Department = department;
            this.Favsub = favsub;
            this.Salary = salary;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public string Favsub { get => favsub; set => favsub = value; }
        public double Salary { get => salary; set => salary = value; }
        
        public double calculate_salary()
        {
            double da = 0.4;
            double hra = 0.2;
            double allowances =(salary*da)+(salary*hra);
            double pf = 0.25;
            double deductions = salary * pf;
            double net_salary = salary + allowances - deductions;

            return net_salary;
        }

    }
}
