using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class EnumDemo
    {
        enum Colors {Blue,Green,Red,Black,White,Violet,Pink,Orange};
        
        public  void Display()
        {
            int color1= (int)Colors.Blue;
            int  color2=(int) Colors.Green;
            int color3= (int)Colors.Red;
            Console.WriteLine(color1);
        }
    }
}
