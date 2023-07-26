using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Answer5
    {
        private int age;
        private bool breaktime;

        public Answer5(int age, bool breaktime)
        {
            Age = age;
            Breaktime = breaktime;
           
        }

        public int Age { get => age; set => age = value; }
        public bool Breaktime { get => breaktime; set => breaktime = value; }

        public bool ShouldServeDrinks()
        {
            if ((this.Age >= 18) && (this.Breaktime == false))
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
