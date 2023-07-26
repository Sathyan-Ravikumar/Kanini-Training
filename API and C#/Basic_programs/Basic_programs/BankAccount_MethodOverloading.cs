using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class BankAccount_MethodOverloading
    {
        private string name, status;
        double balance;
        int customerid;
        private long accountnumber;

        public BankAccount_MethodOverloading(string name, string status, double balance, int customerid, long accountnumber)
        {
            this.Name = name;
            this.Status = status;
            this.Balance = balance;
            this.Customerid = customerid;
            this.Accountnumber = accountnumber;
        }

        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public double Balance { get => balance; set => balance = value; }
        public int Customerid { get => customerid; set => customerid = value; }
        public long Accountnumber { get => accountnumber; set => accountnumber = value; }


        public void checkaccountstatus(int customerid)
        {
            if (customerid == this.Customerid)
            {
                name = Name;
                accountnumber = Accountnumber;
                balance = Balance;
                status = Status;
                
            }
        }
        public void checkaccountstatus(long accountnumber)
        {
            if (accountnumber == this.Accountnumber)
            {
                name = Name;
                customerid = Customerid;
                balance = Balance;
                status = Status;

            }
        }
    }
}
