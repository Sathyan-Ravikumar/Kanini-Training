/*using System.Numerics;

namespace Assignment4
{
     class Program
    {
        public static void Main(string[] args) 
        {

             //1
             StringFile sf = new StringFile();
             Console.WriteLine("Enter the Ignore string :");
             string ignore = Console.ReadLine();
             Console.WriteLine("Enter the Index :");
             int index=Convert.ToInt32(Console.ReadLine());
             string[] str = new string[index];
             Console.WriteLine("Enter the Strings: ");
             for(int i=0;i<index;i++)
             {
                 str[i] = Console.ReadLine();
             }
             sf.StringWrite(str, ignore,index);
             sf.StringRead(ignore);

           //2
             string str;
             str=Console.ReadLine().ToLower();
             DuplicateChar dc=new DuplicateChar();
             dc.RemoveString(str);

            //3
             StringCountcs stringCountcs = new StringCountcs();
             Console.WriteLine("Enter the String :");
             string str=Console.ReadLine();
             stringCountcs.StrCommpression(str);


             //4
               string s1 = Console.ReadLine();
               string s2 = Console.ReadLine();

               DataTransfer dt = new DataTransfer();
               dt.process(s1, s2);
           

            //6
            int n,k;
               n = Convert.ToInt32(Console.ReadLine());
               k= Convert.ToInt32(Console.ReadLine());
             long p = n;
               for (int i = 1; i < k; i++)
               {
                   p = int.Parse(string.Concat(p,n));
               }
               SuperDigit sd= new SuperDigit(p);
               Console.WriteLine(sd.super_digit());
        }
    }
}
 */
