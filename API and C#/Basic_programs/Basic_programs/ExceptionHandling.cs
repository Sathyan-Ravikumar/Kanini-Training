using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class ExceptionHandling
    {
        private int n1, n2,ans=0;

        public int N1 { get => n1; set => n1 = value;   }
        public int N2 { get => n2; set => n2 = value; }
        public int Ans { get => ans; set => ans = value; }

        public ExceptionHandling()
        {
            this.N1 = n1;
            this.N2 = n2;
        }
        public int add()
        {
            this.Ans = this.N1 + this.N2;
            return this.Ans;
        }
        public int mul()
        {
            this.Ans= this.N1*this.N2;
            return this.Ans;
        }
        public int div() {
            int[] arr = { 12, 3 };
            try
            {
                this.Ans = this.N1 / this.N2;

                int num = arr[0] / arr[1];
            }
            catch(DivideByZeroException ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Don't give Zero in denominator ╰(*°▽°*)╯");
            }
            catch(Exception ex)
            {
                Console.WriteLine("\n The second exception : ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Completed");
            }
            return this.Ans;
        }

        public void Checkval(int val)
        {
            if (val < 0)
            {
                throw new ArgumentException("Don't pass zero or less than zero");
            }
            else if (val < 18)
            {
                throw new ArgumentException("val should be 18 or more");
            }
            else
            {
                Console.WriteLine("eligible");
            }
        }
       
    }
}
