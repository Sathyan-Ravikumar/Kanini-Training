using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class Calculations
    {
        private int num1, num2;

        public Calculations(int num1, int num2) { 
          this.Num1 = num1;
          this.Num2 = num2; 
        
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }


        public int Add()
        {
            return Num1 + Num2;
        }
        public int Sub()
        {
            return Num1 - Num2;
        }
        public int Mul()
        {
            return Num1 * Num2;
        }
    }
}
