using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal /*abstract*/ class BankDetails
    {
        private int accno;
       private string accname;
        private double balance, intamt;

       public BankDetails(int accno, string accname, double balance, double intamt)
        {
            this.Accno = accno;
            this.Accname = accname;
            this.Balance = balance;
            this.Intamt = intamt;
        }

        public int Accno { get => accno; set => accno = value; }
        public string Accname { get => accname; set => accname = value; }
        public double Balance { get => balance; set => balance = value; }
        public double Intamt { get => intamt; set => intamt = value; }

        //public abstract double CalculateInterest();

        public void BD()
        {
            List<BankDetails> accounts= new List<BankDetails>() { new BankDetails(121,"sasa",12012,0), new BankDetails(122, "sbsb", 1212, 0) };

        }
    }
}
