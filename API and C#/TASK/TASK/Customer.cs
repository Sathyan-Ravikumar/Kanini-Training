using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    internal class Customer
    {
        private int customerid;
        private string customername;

        public Customer(int customerid, string customername)
        {
            this.Customerid = customerid;
            this.Customername = customername;
        }

        public int Customerid { get => customerid; set => customerid = value; }
        public string Customername { get => customername; set => customername = value; }

        public virtual void display()
        {
            Console.WriteLine($"Customer ID : {this.Customerid}\n Customer Name : {Customername}");
        }
    }
}
