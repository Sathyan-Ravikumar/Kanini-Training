using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class StringCountcs
    {
        public void StrCommpression(string str)
        {
            string str1 = string.Empty;
            int count = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    count++;
                }
                else if(count>1)
                {
                    str1 += str[i - 1] + count.ToString();
                    count = 1;
                }
                else
                {
                    str1 += str[i - 1];
                    count=1;
                }
            }
           str1 += str[str.Length - 1] + count.ToString();

            //Console.WriteLine("Output : ");
            Console.WriteLine(str1.ToLower());

        }
    }
}
