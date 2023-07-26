using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Answer6
    {
        private int cups;

        public Answer6(int cups)
        {
            this.Cups = cups;
            
        }

        public int Cups { get => cups; set => cups = value; }

        public int TotalCups()
        {
            int totalcups = (this.Cups / 6) + this.Cups;
            return totalcups;
        }

    }
}
