using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assessment
{
   class Program
    {
        public static void Main(string[] args)
        {
            // (a)
            /*string str;
            Console.WriteLine("Enter the string :");
            str = Console.ReadLine().ToLower();
            Vowels vowels = new Vowels(str);
            Console.WriteLine("NUmber of Vowels in the Given String is : "+ vowels.str_vowels());*/

            //(b)
            double balance,withdraw,deposit;
           int accountno;
           string name;
           Console.WriteLine("Enter the account number :");
           accountno = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter the Name : ");
           name = Console.ReadLine();
           Console.WriteLine("Enter the Initial balance : ");
           balance= Convert.ToDouble(Console.ReadLine());

           ATM atm = new ATM(name, accountno, balance);


           Console.WriteLine("Enter the Withdrawal Amount :");
           withdraw= Convert.ToDouble(Console.ReadLine());
           atm.withdrawal(withdraw);

           Console.WriteLine("Enter the Deposit Amount :");
           deposit = Convert.ToDouble(Console.ReadLine());
           atm.Deposit(deposit);

            ///3
            /* DeathStar ds = new DeathStar();
            ds.FireLaser();

           int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            Methods cal = new Methods(num1, num2);
            Console.WriteLine("ADD : " + cal.add());
            Console.WriteLine("multiply : " + cal.multiply());
            Console.WriteLine("subract : " + cal.sub());
            Console.WriteLine("divide : " + cal.divide());

            //2
            string emp_name;
                  int emp_id;
                  double salary;

                  Console.WriteLine("emp_name");
                  emp_name = Console.ReadLine();

                  Console.WriteLine("emp_id");
                  emp_id = Convert.ToInt32(Console.ReadLine());



                  Console.WriteLine("Enter i for it department and c for cleaning department");
                  char ch = Convert.ToChar(Console.ReadLine());

                  switch (ch)
                  {
                      case ('i' or 'I'):
                          Console.WriteLine("salary :");
                          salary = Convert.ToDouble(Console.ReadLine());
                          ItDept itdept = new ItDept(salary, emp_name, emp_id);
                          Console.WriteLine("The bonus of {0} is {1}", itdept.Emp_name, itdept.salary_bonus());

                          break;
                      case ('c' or 'C'):
                          Console.WriteLine("salary :");
                          salary = Convert.ToDouble(Console.ReadLine());
                          CleaningDept cleaningdept = new CleaningDept(salary,emp_name, emp_id);
                          Console.WriteLine("The bonus of {0} is {1} ", cleaningdept.Emp_name, cleaningdept.salary_bonus());
                          break;
                      default:
                          Console.WriteLine("Enter the correct department name");
                          break;

                  }*/


        }
    }
}
