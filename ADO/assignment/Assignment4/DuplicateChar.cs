using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class DuplicateChar
    {
        public void RemoveString(string str)
        {
            string str1=string.Empty;
           
            for(int i=0;i<str.Length;i++)
            {
                if (!str1.Contains(str[i]))
                {
                    str1=str1+ str[i];
                }
            }
            Console.WriteLine(str1);
        }
    }
}
