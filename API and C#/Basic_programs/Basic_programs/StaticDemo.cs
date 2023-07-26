using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal static class StaticDemo
    {
        static int cno=100, pre=200, curr=300;
        static double amt;

        public static int Cno { get => cno; set => cno = value; }
        public static int Pre { get => pre; set => pre = value; }
        public static int Curr { get => curr; set => curr = value; }
        public static double Amt { get => amt; set => amt = value; }


        static StaticDemo()
        {
            if ((Curr - Pre) <= 100)
            {
                Amt = 0;
            }
        }
        public static void cal()
        {
            int usage = Curr - Pre;
            if(usage >100 && usage <=200 )
            {
                Amt = usage* 12;
            }
            else
            {
                Amt= usage*5;
            }
            
        }
        public static void display()
        {
            Console.WriteLine("It can also have non static Method which is accessed by object");
        }
    }
}
