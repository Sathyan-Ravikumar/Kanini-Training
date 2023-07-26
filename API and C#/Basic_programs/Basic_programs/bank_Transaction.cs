using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    public class bank_Transaction
    {
        private int custid;
        private long accno;
        private string accname,status;
        private decimal balance, creditamt, debitamt;

       public bank_Transaction(int custid,long accno,string accname,decimal balance) 
        {
            this.Balance = balance;
            this.Accno = accno;
            this.Custid = custid;
            this.Accname = accname;
            this.Status = "InActive";
            this.Creditamt = Debitamt = 0;

        }

        public int Custid { get => custid; set => custid = value; }
        public long Accno { get => accno; set => accno = value; }
        public string Accname { get => accname; set => accname = value; }
        public string Status { get => status; set => status = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public decimal Creditamt { get => creditamt; set => creditamt = value; }
        public decimal Debitamt { get => debitamt; set => debitamt = value; }

        internal decimal PerformTransaction() 
        {
            Console.WriteLine("1. Credit 2.Debit");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Credit amt :");
                    this.Creditamt=Convert.ToDecimal(Console.ReadLine());
                   this.Balance += this.Creditamt;
                    Status = "Active";
                    break;
                case 2:
                    Console.WriteLine("Enter debit amt :");
                    this.Debitamt = Convert.ToDecimal(Console.ReadLine());
                   this.Balance -= this.Debitamt;
                    Status = "Active";
                    break;
                default:
                    Console.WriteLine("enter 1 or 2 only");
                    break;
            }
            return Balance;
        }

        /*internal void WriteCustomerDetails()
        {     
               PerformTransaction();
            Console.WriteLine($"Name : {accname}\n balance : {balance}\n Status :{status}");
        }*/
    }
}
