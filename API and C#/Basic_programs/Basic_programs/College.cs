using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class College
    {
        private string collegename, address;
        private int pincode;

        public College(string collegename,string address, int pincode)
        {
            this.Collegename = collegename;
            this.Address = address;
            this.Pincode = pincode;
        }

        public string Collegename { get => collegename; set => collegename = value; }
        public string Address { get => address; set => address = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
}
