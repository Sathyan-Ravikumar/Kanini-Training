/* Author : sathyan
 * date:22/3/2023
 * description:simple program 1
 */

//using System;
/*Console.Write("Hello World ?");
System.Console.WriteLine("Hello"+"World");

int num1, ans, num2;
num1=Convert.ToInt32(Console.ReadLine()); 
num2= Convert.ToInt32(Console.ReadLine());
ans =num1+num2;
Console.WriteLine("Result :" + ans);
Console.WriteLine(ans = num1 + num2);*/

/*int number = 6;
float flnum = number;
Console.WriteLine(flnum);

char ch = Convert.ToChar(number);
Console.WriteLine(ch);*/

/* operators :
 * assignment operators = += -= *= /= %=
 * arithmatic + - * / % -- ++
 * relational < > <= >= == !=
 * logical && || !
 * shift   << >>
*/

/*double ans=Math.Sqrt(100); // Sqrt only returns double
Console.WriteLine(ans);

Console.WriteLine(Math.Equals(ans,10));   //it compare both as a objects not as numbers
Console.WriteLine(Math.Equals(ans, ans));


string s1 = "Hello world";
string s2 = "Hello";
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s2+s1); //concat
Console.WriteLine(s1.Substring(2,6)); // the 6 indicates the length

Console.WriteLine("length of s2 : " + s2.Length);
Console.WriteLine("Index of l: " + s1.LastIndexOf('l'));

Console.WriteLine($"{s1} jeeva {s2}");*/

//Driver

/*class demo1
{
    public static void Main(string[] args)
    {
        demo2 Demo2 = new demo2();
        Demo2.array_func();
        
        /* Switch case:
        * Console.WriteLine("S => 2 number M => 3 numbers");
        char ch=Convert.ToChar(Console.ReadLine());
        switch (ch)
        {
            case 'S':
            case 's':
                Demo2.Big2num();
                break;
            case 'M' or 'm':
                Demo2.Big3num();
                break;
            default :
                Console.WriteLine("Enter S or M ");
                break;
        }/
        
    }
}*/

using Basic_programs;

class demo1
{
    public static void Main(string[] args)
    {

        /*Console.WriteLine("Enter Customer id ," + " accno , " + "accname , " + "Balance ");

        int custid = Convert.ToInt32(Console.ReadLine());
        long accno = Convert.ToInt64(Console.ReadLine());
        string accname = Console.ReadLine();
        decimal balance = Convert.ToDecimal(Console.ReadLine());

        bank_Transaction Banktransaction = new bank_Transaction(custid,accno,accname,balance);
      Banktransaction.WriteCustomerDetails();


        int custid = 3;
        long accno = 123456;
        string accname = "sethu";
        decimal balance = 50000;
        bank_Transaction Banktrans = new bank_Transaction(custid, accno, accname, balance);
       decimal bal= Banktrans.PerformTransaction();
        Console.WriteLine($"Name : {accname}\n balance : {bal}\n Status : Active");



        //stud_details and calculation prg "simple,multilevel Inheritance"
        Console.WriteLine("Enter roll number,name and 3 marks");
        int rno=Convert.ToInt32(Console.ReadLine());
        string name=Console.ReadLine();
        double mark1=Convert.ToDouble(Console.ReadLine());
        double mark2 = Convert.ToDouble(Console.ReadLine());
        double mark3 = Convert.ToDouble(Console.ReadLine());
        studcalculation StudCalculation = new studcalculation(rno,name,mark1,mark2,mark3,0,0);
        StudCalculation.Calculation();
        Console.WriteLine($"Roll number : {StudCalculation.Rno}\n Name : {StudCalculation.Name}\n Total : {StudCalculation.Tot}\n Average : {StudCalculation.Avg}");


        //college staff details prg "hierarchial inheritance"

        Console.WriteLine("Enter the clgname,addr,pin");
        string collegename=Console.ReadLine();
        string address=Console.ReadLine();
        int pincode=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Teaching staff - eid ,name,dept,fav sub,sal ");
        int eid=Convert.ToInt32(Console.ReadLine());
        string name=Console.ReadLine();
        string department=Console.ReadLine();
        string favsub=Console.ReadLine();
        double salary=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Admin staff - eid,name,sal ");
        int admins_eid=Convert.ToInt32(Console.ReadLine());
        string admins_name=Console.ReadLine();
        double admins_salary=Convert.ToDouble(Console.ReadLine());

        College_teaching_staff college_Teaching_Staff = new College_teaching_staff(collegename, address, pincode, eid, name, department, favsub, salary);

        College_admin_staff college_Admin_Staff = new College_admin_staff(collegename, address, pincode, admins_eid, admins_name, admins_salary);

        double tsal = college_Teaching_Staff.calculate_salary();
        double asal = college_Admin_Staff.calculate_salary();

        Console.WriteLine($"College Name : {college_Teaching_Staff.Collegename}\n Teaching staff name : {college_Teaching_Staff.Name}\n Teaching salary : {tsal}\n Admin Staff name : {college_Admin_Staff.Admins_name}\n Admin staff salary : {asal}");*/

        /*
        int num3=90, num4=99;
        Addition addition= new Addition();
        addition.add(out int num1, out int  num2,num3,num4);
        Console.WriteLine(num1 + "  "+num2);


        // for BankDetails,Interest 
        //abstract class
        Interest interest = new Interest(9.5,10000,"ABC",24092,0);
        double intamt=interest.CalculateInterest();
        Console.WriteLine(interest.Accno +"\n"+ interest.Accname + "\n" + intamt);

        //interface
        sample Sample = new sample();
        Console.WriteLine( Sample.intadd(10,80));
        Console.WriteLine(Sample.stradd("Sath","yan"));

        Animals dog = new Animals(1, 2, 1, 4, "dog");
        Animals cow = new Animals(1, 2, 1, 4, "cow");
        Animals cat = new Animals(1, 2, 1, 4, "cat");

        cat.MakeSound(cat.Name);
        cow.type(cow.Name);
        dog.type(dog.Name);
        dog.MakeSound(dog.Name);



        //polymorphism method overloading
        BankAccount_MethodOverloading bankAccount_MethodOverloading = new BankAccount_MethodOverloading("sathya", "InActive", 13.5, 1234, 68378929827);
        Console.WriteLine("1. Custid 2.AccNo :");
        int ch=Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            case 1:
                bankAccount_MethodOverloading.checkaccountstatus(1234);
                Console.WriteLine($"Account Number : {bankAccount_MethodOverloading.Accountnumber} \n Name : {bankAccount_MethodOverloading.Name}\n Balance : {bankAccount_MethodOverloading.Balance}\n Status : {bankAccount_MethodOverloading.Status}");
                break;
            case 2:
                bankAccount_MethodOverloading.checkaccountstatus(68378929827);
                Console.WriteLine($"Customer ID : {bankAccount_MethodOverloading.Customerid} \n Name : {bankAccount_MethodOverloading.Name}\n Balance : {bankAccount_MethodOverloading.Balance}\n Status : {bankAccount_MethodOverloading.Status}");

                break;
            default:
                Console.WriteLine("Emter 1 Or 2");
                break;
        }


        studcalculation StudCalculation = new studcalculation(1,"sa",23,34,23,0,0);
        StudCalculation.show();


        //Enum
        EnumDemo enumdemo = new EnumDemo();
        enumdemo.Display();
        */


        //Exception
        /*int n1, n2;
        Console.WriteLine("Enter two numbers : ");
        n1=Convert.ToInt32(Console.ReadLine());
        n2=Convert.ToInt32(Console.ReadLine());
        ExceptionHandling exceptionHandling=new ExceptionHandling(n1,n2);
        Console.WriteLine("The added valus is: "+exceptionHandling.add());
        Console.WriteLine("The multiplied value is : "+exceptionHandling.mul());
        Console.WriteLine("the divided Answer is : "+exceptionHandling.div());

        ExceptionHandling exceptionHandling = new ExceptionHandling();
        Console.WriteLine("Enter the Value for Checking : ");
        int val = Convert.ToInt32(Console.ReadLine());
        exceptionHandling.Checkval(val);*/


        //File
        FileOperation fileOperation= new FileOperation();
       // fileOperation.CreateFile();
        //fileOperation.Deletefile();
        //fileOperation.CopyMovefile();
        fileOperation.WriteData();
       fileOperation.ReadData();
       //fileOperation.fileproperties();
        

/*
//Collections - Generic collections
            GenericCollectionsDemo genericCollectionsDemo = new GenericCollectionsDemo();
        genericCollectionsDemo.ListElements();
        genericCollectionsDemo.Stackelements();
        genericCollectionsDemo.QueueElements();
        genericCollectionsDemo.Dictionary_HashTableElements();
        genericCollectionsDemo.SortedListElements();


//collections - non generic
                     NonGeneric nonGeneric = new NonGeneric();
                     nonGeneric.ArrayListElements();

//Jagged Array
                   JaggedArray jaggedArray = new JaggedArray();
                   jaggedArray.jaggedarray();
        

//static - variable,method,class
            
       StaticDemo.cal();
        Console.WriteLine(StaticDemo.Amt);
        StaticDemo.display();
        
//partial
             PartialDemo pd=new PartialDemo(10,20,30,0);
             Console.WriteLine("Added Answer : "+pd.calc());*/
    }
}