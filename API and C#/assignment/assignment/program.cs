
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class program
    {
    }
}*/
using System;
class program
{
    public static void Main(string[] args)
    {
        /*
        //15 i
        int num;
        Console.WriteLine("Enter the Number : ");
        num=Convert.ToInt32(Console.ReadLine());
        ass_func ass_Func= new ass_func();
        if (ass_Func.palindrom_number(num))
        {
            Console.WriteLine(num + " is Palindrome");
        }
        else
        {
            Console.WriteLine(num +" is not a palindrome");
        }
        //15 ii
        string word;
        Console.WriteLine("Enter the string : ");
        word= Console.ReadLine();
        ass_func ass_Func = new ass_func();
        if (ass_Func.palindrom_string(word))
        {
            Console.WriteLine($"{word} is palindrome");
        }
        else
        {
            Console.WriteLine($"{word} not is palindrome");
        }


        //14
        int number;
        Console.WriteLine("Enter the Number : ");
        number=Convert.ToInt32(Console.ReadLine());
        ass_func ass_Func = new ass_func();
        if(ass_Func.prime_number(number))
        {
            Console.WriteLine(number +" is prime number");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number");
        }
        

        
        //13
        int num;
        Console.WriteLine("Enter the number :");
        num=Convert.ToInt32(Console.ReadLine());
        ass_func ass_Func = new ass_func();
        ass_Func.perfect_number(num);

        

        //12
        int num1;
        Console.WriteLine("Enter the number :");
        num1=Convert.ToInt32(Console.ReadLine());
        ass_func ass_Func = new ass_func();
         ass_Func.Armstrong_number(num1);


        
        //11
        int limit;
        Console.WriteLine("Enter the number :");
        limit=Convert.ToInt32(Console.ReadLine());
        ass_func ass_Func = new ass_func();
        ass_Func.Fibonacci_sequence(limit);

        
        //10
        string str;
        Console.WriteLine("Enter the string :");
        str = Console.ReadLine();
        ass_func ass_Func = new ass_func();
        ass_Func.middle_char_string(str);
       
        
        //9
        string str;
        Console.WriteLine("Enter the string :");
        str = Console.ReadLine();
        ass_func ass_Func = new ass_func();
        ass_Func.number_of_char_string(str);
        
        
       //8
       string str;
       Console.WriteLine("Enter the string :");
       str = Console.ReadLine();
       ass_func ass_Func = new ass_func();
       ass_Func.number_of_words_string(str);


      //7
      int index,i;
      Console.WriteLine("Enter the index of the array :");
      index = Convert.ToInt32(Console.ReadLine());
      int[] arr=new int[index];
      Console.WriteLine("Enter the array :");
      for (i = 0; i < index; i++)
      {
          arr[i] = Convert.ToInt32(Console.ReadLine());
      }
      ass_func ass_Func = new ass_func();
      ass_Func.sum_of_prime_array(arr,index);


      //6
      int row,col,i,j;
      Console.WriteLine("Enter the Number of rows and columns :");
      row=Convert.ToInt32(Console.ReadLine());
      col = Convert.ToInt32(Console.ReadLine()); 
      int[,] arr=new int[row,col];
      Console.WriteLine("Enter the Matrix :");
      for (i = 0; i < row; i++)
      {
          for (j = 0; j < col; j++)
          {
              arr[i,j] = Convert.ToInt32(Console.ReadLine());
          }
      }
      ass_func ass_Func = new ass_func();
      ass_Func.transpose_matrix(arr,col,row);


      //5
      int index, i;
      Console.WriteLine("Enter the index of the array :");
      index = Convert.ToInt32(Console.ReadLine());
      int[] arr = new int[index];
      Console.WriteLine("Enter the array :");
      for (i = 0; i < index; i++)
      {
          arr[i] = Convert.ToInt32(Console.ReadLine());
      }
      ass_func ass_Func = new ass_func();
      ass_Func.array_reverse(arr, index);
      ass_Func.array_copy(arr, index);
      ass_Func.sum_array(arr, index);
      ass_Func.duplicate_elements(arr, index);
      ass_Func.unique_elements(arr, index);
      ass_Func.second_largenum(arr, index);


      //4
      int ran;
      Console.WriteLine("Enter the value: ");
      ran = Convert.ToInt32(Console.ReadLine());
      ass_func ass_Func = new ass_func();
      ass_Func.pattern(ran); 

      //3
      int customerid;
      string name;
      int unit;
      Console.WriteLine("Enter the Customer id, Name, Unit consumed :");
      customerid=Convert.ToInt32(Console.ReadLine()); 
      name=Console.ReadLine();
      unit=Convert.ToInt32(Console.ReadLine());
      ElectricityBill electricityBill = new ElectricityBill(customerid,name,unit);
      double bill=electricityBill.Ebill();
      if (bill >= 100)
      {
          Console.WriteLine($"Customer id: {electricityBill.Customerid}\n Name: {electricityBill.Name}\n Unit Consumed: {electricityBill.Unit}\n Total Amount: {bill}");
      }
      else
      {
          Console.WriteLine("Your bill is lower than 100 rupee");
      }

      //2
      string name;
      int roll_no;
      double phy_mark,com_mark, che_mark;
      Console.WriteLine("Enter the Name, roll number, subject marks :");
      name= Console.ReadLine();
      roll_no=Convert.ToInt32(Console.ReadLine());
      phy_mark=Convert.ToDouble(Console.ReadLine());
      che_mark=Convert.ToDouble(Console.ReadLine());
      com_mark=Convert.ToDouble(Console.ReadLine());
      Studentmark student_mark=new Studentmark(name,roll_no,phy_mark,che_mark,com_mark);
      student_mark.studtotal_per();

      if (student_mark.Percentage >= 80)
      {
          Console.WriteLine($"Roll No : {student_mark.Roll_no}\n Name of Student : {name}\n Marks in Physics : {phy_mark}\n " +
              $"Marks in Chemistry : {che_mark}\n Marks in Computer Application : {com_mark}\n Total Marks = {student_mark.Total}\n" +
              $" Percentage = {student_mark.Percentage}\n Division = First");
      }
      else if(student_mark.Percentage >= 65 && student_mark.Percentage < 80)
      {
          Console.WriteLine($"Roll No : {student_mark.Roll_no}\n Name of Student : {name}\n Marks in Physics : {phy_mark}\n " +
              $"Marks in Chemistry : {che_mark}\n Marks in Computer Application : {com_mark}\n Total Marks = {student_mark.Total}\n" +
              $" Percentage = {student_mark.Percentage}\n Division = Second");
      }
      else if(student_mark.Percentage >= 50 && student_mark.Percentage <65)
      {
          Console.WriteLine($"Roll No : {student_mark.Roll_no}\n Name of Student : {name}\n Marks in Physics : {phy_mark}\n " +
             $"Marks in Chemistry : {che_mark}\n Marks in Computer Application : {com_mark}\n Total Marks = {student_mark.Total}\n" +
             $" Percentage = {student_mark.Percentage}\n Division = Third");
      }
      else
      {
          Console.WriteLine($"Roll No : {student_mark.Roll_no}\n Name of Student : {name}\n Marks in Physics : {phy_mark}\n " +
             $"Marks in Chemistry : {che_mark}\n Marks in Computer Application : {com_mark}\n Total Marks = {student_mark.Total}\n" +
             $" Percentage = {student_mark.Percentage}\n Division = Failed");
      }


      //1
      int co1, co2;
      Console.WriteLine("Enter the Coordinate X :");
      co1=Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the Coordinate Y :");
      co2 =Convert.ToInt32(Console.ReadLine());
      Coordinates coordinates = new Coordinates();
      coordinates.cordinate(co1, co2);*/

    }

}
