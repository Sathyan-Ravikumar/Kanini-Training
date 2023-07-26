using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    partial class PartialDemo
    {
        int num3,ans=0;
        public PartialDemo(int num1,int num2, int num3, int ans)
        {
            Num1 = num1;
            Num2 = num2;
            Num3 = num3;
            this.ans = ans;
        }

        public int Num3 { get => num3; set => num3 = value; }

        public partial int calc()
        {
            ans = Num1 + Num2 + Num3 ;
            return ans;
        }
    }
}
