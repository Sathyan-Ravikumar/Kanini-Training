using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Vowels
    {
        private int count=0;
        private string str;

        public Vowels(string str)
        {
            this.Str = str;
        }

        public int Count { get => count; set => count = value; }
        public string Str { get => str; set => str = value; }

        public int str_vowels()
        {
            for (int i = 0; i < Str.Length; i++)
            {
                if (Str[i] == 'a' || Str[i] == 'e' || Str[i] == 'i' || Str[i] == 'o' || Str[i] == 'u')
                {
                    Count++;
                }
            }
            return Count;
        }
        
    }
}
