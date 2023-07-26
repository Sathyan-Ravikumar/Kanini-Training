using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class ATM
    {
        private string name;
        private double balance;
        private int accountno;
        
        public ATM(string name, int accountno, double balance)
        {
            this.Name = name;
            this.Accountno = accountno;
            this.Balance = balance;
        }

        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }
        public int Accountno { get => accountno; set => accountno = value; }

        

        public void withdrawal(double withdraw)
        {
            if (withdraw < this.Balance)
            {
                this.Balance = this.Balance - withdraw;
                Console.WriteLine("balance after withdrawal : " + this.Balance);
            }
            else
            {
                Console.WriteLine("Your balance amount {0} is less than widrawal amount {1}", this.Balance, withdraw);
            }
        }
        public void Deposit(double deposit)
        {
            this.Balance += deposit;
            Console.WriteLine("Total balance after Deposit : " + this.balance);
        }
       
    }
}
