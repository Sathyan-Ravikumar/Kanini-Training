using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class DataTransfer
    {
        int length;
        int index;
        public void process(string s1, string s2)
        {
            int prefixLen = 0;
            for (int i = 0; i < Math.Min(s1.Length, s2.Length); i++)
            {
                if (s1[i] == s2[i])
                {
                    prefixLen++;
                }
                else
                {
                    break;
                }
            }

            string compressedS1 = s1.Substring(prefixLen);
            string compressedS2 = s2.Substring(prefixLen);

            Console.WriteLine($"{prefixLen} {s1.Substring(0, prefixLen)}");
            Console.WriteLine($"{compressedS1.Length} {compressedS1}");
            Console.WriteLine($"{compressedS2.Length} {compressedS2}");

        }
    }
}
