


using TASK;

class Program
{
    public static void Main(string[] args)
    {
        int customerid,loanTenureinyrs,loanaccno,accno;
        string customername,accountType,ifsccode,branchname;
        double loanamount, amount;
        Console.WriteLine("Enter the ID : ");
        customerid =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Name: ");
        customername =Console.ReadLine();
        Console.WriteLine("Enter the Account Type : ");
        accountType=Console.ReadLine();

        Customer customer = new Customer(customerid, customername);
        

        if (accountType == "Loan"|| accountType == "loan")
        {
            Console.WriteLine("Enter the loan Account number : ");
            loanaccno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the loan Amount : ");
            loanamount =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the loan Tenure in years : ");
            loanTenureinyrs =Convert.ToInt32(Console.ReadLine());
            LoanAccount loan = new LoanAccount(loanaccno,loanamount,loanTenureinyrs,customerid,customername);
            loan.display();
        }
        else if(accountType=="Savings"|| accountType == "savings")
        {
            Console.WriteLine("Enter the Savings Account number : ");
            accno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount : ");
            amount=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the branch : ");
            branchname=Console.ReadLine();
            Console.WriteLine("Enter the IFSC code : ");
            ifsccode = Console.ReadLine();
            SavingsAmount savings = new SavingsAmount(accno, amount, branchname, ifsccode,customerid,customername);
            savings.display();

        }
        else
        {
            Console.WriteLine("Enter only Loan or Savings");
        }
    }
}