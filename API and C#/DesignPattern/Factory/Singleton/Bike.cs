using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Bike");
        }
    }
}
