using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Answer7
    {
        public void AddEnding(string[] str, string end)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i] + end;
            }
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
        }

    }
}
