using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Methods:Calculator
    {
        private int num1, num2;

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
      

        public Methods(int num1,int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }
        public  int add()
        {
            return Num1 + Num2;
        }
        public int sub()
        {
            return Num1 - Num2;
        }
        public int multiply()
        {
            return Num1 * Num2;
        }
        public int divide()
        {
            return Num1 / Num2;
        }
    }
}
