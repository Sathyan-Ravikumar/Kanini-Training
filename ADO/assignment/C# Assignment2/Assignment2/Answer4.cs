using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Answer4
    {
        private int number;

        public Answer4(int number)
        {
           this.Number = number;
           
        }

        public int Number { get => number; set => number = value; }

        public int StackBoxes()
        {
            return this.Number * this.Number;
        }

    }
}
