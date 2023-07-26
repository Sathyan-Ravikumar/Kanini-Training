using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class StringFile
    {
        public void StringWrite(string[] str,string ignore,int index)
        {
            FileStream fc = new FileStream("D:\\c#\\text.txt", FileMode.Create, FileAccess.Write);
       
            StreamWriter sw = new StreamWriter(fc);
            
            for (int i = 0; i < index; i++)
            {
                    sw.WriteLine(str[i]);
            }
            Console.WriteLine("output : ");
            for(int i = 0; i < index; i++)
            {
                if (!str[i].Contains(ignore))
                {
                    Console.WriteLine(str[i]);
                }
            }
            sw.Close();
            fc.Close();
           
        }
        public void StringRead(string ignore)
        {
            FileStream fs = new FileStream("D:\\C#\\text.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string filestr = sr.ReadLine();
            while (filestr != null)
            {
                if (!filestr.Contains(ignore))
                {
                    Console.WriteLine(filestr);
                }
            }
            sr.Close();
            fs.Close();
        }
    }
}
