using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class FileOperation
    {
        public void CreateFile()
        {
            FileInfo fileInfo= new FileInfo("D:\\C#"+"sample.txt");
            StreamWriter stwr=fileInfo.CreateText();
            Console.WriteLine("File has been Created");

            stwr.WriteLine("Hello Sathyan");
            
        }
        public void Deletefile()
        {
            FileInfo fi = new FileInfo("D:\\c#\\"+"sample.txt");
            fi.Delete();
            Console.WriteLine("File has been Deleted");

        }

        public void CopyMovefile()
        {
            FileInfo fi1 = new FileInfo("D:\\C#" + "sample.txt");
            //fi1.CopyTo("D:\\C#\\sample.txt");
            //Console.WriteLine("file Copied");
            fi1.MoveTo("D:\\C#\\sample.txt");
        }

        public void WriteData()
        {
            FileStream fs = new FileStream("D:\\C#sample.txt",
                FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("enter text :");
            string str=Console.ReadLine();  
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();

        }

        public void ReadData()
        {
            FileStream fs = new FileStream("D:\\C#sample.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while(str != null) {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        public void fileproperties()
        {
            FileInfo fi = new FileInfo("D:\\C#sample.txt");
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.Length.ToString());
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.Exists);
            Console.WriteLine(fi.DirectoryName);

        }
    }
}
