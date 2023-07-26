using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{ 
    internal class studcalculation : studentmarks
    {
        private double tot, avg;

        public studcalculation(int rno,string name,double mark1, double mark2, double mark3,double tot, double avg) 
            : base(rno, name, mark1, mark2, mark3)

        {
             
            this.Tot = tot;
            this.Avg = avg;
        }

        public double Tot { get => tot; set => tot = value; }
        public double Avg { get => avg; set => avg = value; }

        public void Calculation()
        {
           this.Tot= this.Mark1 + this.Mark2 + this.Mark3;
           this.Avg = this.Tot / 3;
        }


        public override void show()
        {
            Console.WriteLine("Welcome");
        }
    }
}
