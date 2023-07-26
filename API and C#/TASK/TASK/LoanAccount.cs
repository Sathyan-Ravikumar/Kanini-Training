using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    internal class LoanAccount : Customer
    {
        private int loanAccno;
        private double loanamount;
        private int loanTenureinyrs;

        public LoanAccount(int loanAccno, double loanamount, int loanTenureinyrs, int customerid, string customername) : base(customerid, customername)
        {
            
            this.LoanAccno = loanAccno;
            this.Loanamount = loanamount;
            this.LoanTenureinyrs = loanTenureinyrs;
        }

        public int LoanAccno { get => loanAccno; set => loanAccno = value; }
        public double Loanamount { get => loanamount; set => loanamount = value; }
        public int LoanTenureinyrs { get => loanTenureinyrs; set => loanTenureinyrs = value; }

        public override void display()
        {
            base.display();
            Console.WriteLine($"Loan account number : {this.LoanAccno}\n Loan amount : {this.Loanamount}\nLoan Tenur in Yrs : {this.LoanTenureinyrs}");
        }
    }
}
