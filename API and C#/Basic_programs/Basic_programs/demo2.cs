using System;
class demo2
{
    public void Big2num()
    {
     
        int num1, num2;
        Console.WriteLine("Enter the Numbers :");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 == num2)
        {
            Console.WriteLine("Both are Equal");
        }
        else if (num1 > num2)
        {
            Console.WriteLine(num1 + " is Greater than " + num2);
        }
        else if (num2 > num1)
        {
            Console.WriteLine(num2 + " is Greater than " + num1);
        }
    }

    public void Big3num()
    {

        int num1, num2,num3;
        Console.WriteLine("Enter the Numbers :");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        num3 = Convert.ToInt32(Console.ReadLine());
        if ((num1 == num2)&&(num2==num3))
        {
            Console.WriteLine("All numbers are Equal");
        }
        else if ((num1 > num2)&&(num1 > num3))
        {
            Console.WriteLine(num1 + " is Greater than " + num2 + " and "+num3);
        }
        else if ((num2 > num1)&&(num2>num3))
        {
            Console.WriteLine(num2 + " is Greater than " + num1+ " and "+ num3);
        }
        else
        {
            Console.WriteLine(num3+ "is big");
        }
    } 

 //loops:
    public void dowhile_loop_function()
    {
        int max,sum=0,count=1;
        max = Convert.ToInt32(Console.ReadLine());
        do
        {
            sum =sum+count ;
            count++;
        }
        while (count<=max);
        Console.WriteLine("Total : "+sum);
    }
    public void while_loop_function()
    {
        int max, sum = 0, count = 1;
        max = Convert.ToInt32(Console.ReadLine());
        while (count <= max)
        {
            sum = sum + count;
            count++;
        }
        Console.WriteLine("Total : " + sum);
    }

    public void for_loop_function()
    {
        int max, sum = 0;
        max = Convert.ToInt32(Console.ReadLine());
       for(int count=1; count <= max; count++)
        {
            sum +=Convert.ToInt32(Math.Pow(count,3));
        }
        Console.WriteLine("Total : " + sum);
    }

    public void foreach_function(string s1)
    {
        foreach(char s in s1)
        {
            Console.WriteLine(s);
        }
    }

//Array
    
    public void array_func()
    {
        int[] nums = {1,2,3,4};
        foreach(int n in nums)
        {
            Console.WriteLine(n);
        }
    }

}
