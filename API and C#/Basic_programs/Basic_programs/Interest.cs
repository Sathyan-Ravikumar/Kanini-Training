using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class Interest : BankDetails
    {
        private double interestpercentage;

        public Interest(double interestpercentage, int accno,string accname,double balance,double intamt)
            :base(accno,accname,balance,intamt)
        {
            this.Interestpercentage = interestpercentage;
          
        }

        public double Interestpercentage { get => interestpercentage; set => interestpercentage = value; }

       // public override double CalculateInterest()
        //{
        //    return Balance*1*(Interestpercentage/100);
      //  }
    }
}
