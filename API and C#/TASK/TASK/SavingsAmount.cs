using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    internal class SavingsAmount : Customer
    {
        private int accno;
        private double amount;
        private string branchname, iFSC_code;

        public SavingsAmount(int accno, double amount, string branchname, string iFSC_code,int customerid,string customername) : base(customerid,customername)
        {
            this.Accno = accno;
            this.Amount = amount;
            this.Branchname = branchname;
            this.IFSC_code = iFSC_code;
        }

        public int Accno { get => accno; set => accno = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Branchname { get => branchname; set => branchname = value; }
        public string IFSC_code { get => iFSC_code; set => iFSC_code = value; }

        public override void display()
        {
            base.display();
            Console.WriteLine($"Account number : {this.Accno}\n Amount : {this.Amount}\nBranch Name : {this.Branchname}\nIFSC code : {this.IFSC_code}");
        }
    }
}
