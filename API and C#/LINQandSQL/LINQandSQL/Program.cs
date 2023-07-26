using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQandSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Details gen = new Details();
            //gen.ReadDataFromSqlServer();
            //gen.CountMinMaxAvg();
            gen.Joins();
            Console.ReadLine();
        }
    }
}
