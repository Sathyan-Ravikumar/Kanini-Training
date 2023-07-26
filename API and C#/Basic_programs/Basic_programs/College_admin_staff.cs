using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class College_admin_staff : College
    {
        private int admins_eid;
        private string admins_name;
        private double admins_salary;

        public College_admin_staff(string collegename, string address, int pincode,int admins_eid, string admins_name, double admins_salary) 
            : base(collegename,address,pincode)
        {
            this.Admins_eid = admins_eid;
            this.Admins_name = admins_name;
            this.Admins_salary = admins_salary;
        }

        public int Admins_eid { get => admins_eid; set => admins_eid = value; }
        public string Admins_name { get => admins_name; set => admins_name = value; }
        public double Admins_salary { get => admins_salary; set => admins_salary = value; }

        public double calculate_salary()
        {
            double da = 0.3;
            double hra = 0.15;
            double allowances = (Admins_salary * da) + (Admins_salary * hra);
            double pf = 0.2;
            double deductions = Admins_salary * pf;
            double net_salary = Admins_salary + allowances - deductions;

            return net_salary;
        }
    }
}
