using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Answer3
    {
        private double prob;
        private int prize;
        private int pay;

        public Answer3(double prob, int prize, int pay)
        {
            this.Prob = prob;
            this.Prize = prize;
            this.Pay = pay;
        }

        public double Prob { get => prob; set => prob = value; }
        public int Prize { get => prize; set => prize = value; }
        public int Pay { get => pay; set => pay = value; }

        public bool ProfitableGamble()
        {
            if (this.Prob * this.Prize > this.Pay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
