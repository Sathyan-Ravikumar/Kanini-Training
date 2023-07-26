using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class SuperDigit
    {
        private long p;
        public SuperDigit(long p)
        {
            this.p = p;
        }
        public long super_digit()
        {
            long sum=0;
            while (true)
            {
                sum = 0;
                while (p != 0)
                {
                    sum += p % 10;
                    p /= 10;
                }
                if (sum >= 10)
                    p = sum;
                else
                    break;
            }
            return sum;
        }
       
    }
}
