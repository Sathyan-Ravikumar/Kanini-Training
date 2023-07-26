using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class studentmarks : studetails
    {
        private double mark1,mark2,mark3;

        public studentmarks(int rno,string name,double mark1,double mark2,double mark3):base(rno,name)
        {
            this.Mark1 = mark1; 
            this.Mark2 = mark2; 
                this.Mark3 = mark3;
        }

        public double Mark1 { get => mark1; set => mark1 = value; }
        public double Mark2 { get => mark2; set => mark2 = value; }
        public double Mark3 { get => mark3; set => mark3 = value; }

        public override void show()
        {
            Console.WriteLine("HIII");
        }
    }
}
