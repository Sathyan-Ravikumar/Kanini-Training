using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class Answer1
    {
        private int chickens;
        private int cows;
        private int pigs;

        public Answer1(int chickens, int cows, int pigs)
        {
            this.Chickens = chickens;
            this.Cows = cows;
            this.Pigs = pigs;
        }

        public int Chickens { get => chickens; set => chickens = value; }
        public int Cows { get => cows; set => cows = value; }
        public int Pigs { get => pigs; set => pigs = value; }

        public int legsCount()
        {
            int result = (this.Chickens * 2) + (this.Cows * 4) + (this.Pigs * 4);
            return result;
        }

    }
}
