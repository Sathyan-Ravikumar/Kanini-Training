/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class ass_func
    {
    }
}*/



using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

class ass_func
{
    public bool palindrom_number(int num)
    {
        int temp,rem=0,num1=0;
        temp = num;
        while (num != 0)
        {
            rem = num % 10;
            num1 = num1 * 10 + rem;
            num /= 10;
        }
        if ((num1 == temp)||(temp>0 && temp<10))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool palindrom_string(string word)
    {
        string rev=string.Empty;
        for (int i = word.Length - 1; i >= 0; i--)
        {
            rev += word[i];
        }
        if (rev == word)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool prime_number(int number)
    {
        int i,count=0;
        for(i=1; i<=number; i++)
        {
            if(number%i==0)
            {
                count++;
            }
        }
        if(count==2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void perfect_number(int num) {
        int sum = 0, rev = 0;
        for(int i = 1; i < num; i++)
        {
            rev = num % i;
            if (rev == 0)
            {
                sum = sum + i;
            }
        }
        if(sum==num)
        {
            Console.WriteLine(num + " is a perfect number");
        }
        else
        {
            Console.WriteLine(num + " is not a perfect number");
        }
    }

    public void Armstrong_number(int num)
    {
        int temp=0,pow_num=0,str=0;
        double sum = 0;
        temp = num;
        while (num != 0)
        {
            num /= 10;
            pow_num++;
        }
        num = temp;
        while (num != 0)
        {
            str = num % 10;
            sum += Math.Pow(str, pow_num);
                num = num / 10;
        }
        if (sum == temp)
        {
            Console.WriteLine(temp + " is armstrong number");
        }
        else
        {

            Console.WriteLine(temp + " is not armstrong number");
        }
    }

    public void Fibonacci_sequence(int lim)
    {
        int num1 = 0,num2=1 ,seq=0;
        Console.Write($"The Fibonacci Sequence is {num1} {num2} ");
        for(int i = 2; i < lim; i++)
        {
            seq = num1 + num2;
            Console.Write(seq+ " ");
            num1 = num2;
            num2= seq;
        }

    }

    public void middle_char_string(string str)
    {
        int len=str.Length;
        if (len % 2 != 0)
        {
            Console.WriteLine($"The middle character of the string is {str[len / 2]}");
        }
        else
        {
            Console.WriteLine($"The middle character of the string is {str[(len /2)-1]}{str[len / 2]}");
        }

        //int l = 1 - str.Length % 2;
        //Console.WriteLine("The middle character of the given string is " + str.Substring(str.Length / 2 - l, 1 + l));
    }

    public void number_of_char_string(string str)
    {
        int alp, digit, spl_char, i, len;
        alp = digit = spl_char = i = 0;
        len = str.Length;
        while (i < len)
        {
            if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
            {
                alp++;
            }
            else if (str[i] >= '0' && str[i] <= '9')
            {
                digit++;
            }
            else
            {
                spl_char++;
            }

            i++;
        }

        Console.Write("Number of Alphabets in the string is : {0}\n", alp);
        Console.Write("Number of Digits in the string is : {0}\n", digit);
        Console.Write("Number of Special characters in the string is : {0}\n\n", spl_char);
    }

    public void number_of_words_string(string str)
    {
        int word=1;
        for (int i=0; i <= str.Length - 1;i++)
        {
            if (str[i] == ' ')
            {
                word++;
            }
        }
        Console.WriteLine("Total number of words in the string is : "+ word);
    }
    
    public void sum_of_prime_array(int[] arr,int index)
    {
        int i, sum=0,count=0,j;
        for (i = 0; i <index; i++)
        {
            count = 0;
            for (j = 1; j <= arr[i]; j++)
            {
                if (arr[i] % j == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                sum += arr[i];
            }
        }
        Console.WriteLine("The sum of all prime numbers in an array is :" + sum);
    }

    public void transpose_matrix(int[,] arr,int col,int row)
    {

            Console.WriteLine("The Transposed matrix is : ");
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write(arr[j,i]+"\t");
                }
                Console.Write("\n");
            }
    }

    public void array_reverse(int[] arr,int index)
    {
        Console.WriteLine("The reversed array :");
        for(int i = index - 1; i >= 0; i--)
        {
            Console.Write(arr[i]+" ");
        }
    }
    
    public void array_copy(int[] arr,int index)
    {
        int[] brr = new int[index];
        Array.Copy(arr, brr, index);
        Console.Write("\n\n");
        Console.WriteLine("The copied array is  :");
        for(int i = 0; i < index; i++)
        {
            Console.Write(brr[i] + " ");
        }
    }

    public void sum_array(int[] arr,int index)
    {
        int sum = 0;
        for(int i = 0; i < index; i++)
        {
            sum += arr[i];
        }
        Console.Write("\n\n");
        Console.WriteLine("The sum of elements in an array is : " + sum);
    }

    public void duplicate_elements(int[] arr,int index)
    {
        int count1 = 0,count2= 0;
        int[] brr = new int[index];
        int[] arr2 = new int[index];
        Array.Copy(arr, brr, index);
        for(int i = 0; i < index; i++)
        {
            count1 = 1;
            for(int j = 0; j < index; j++)
            {
                if (arr[i] == brr[j])
                {
                    arr2[j] = count1;
                    count1++;
                }
            }
            
        }
        for(int i = 0; i < index; i++)
        {
            if (arr2[i]==2)
            {
                count2++;
            }
        }
        Console.Write("\n\n");
        Console.WriteLine("The number of duplicate elements are : " + count2);
    }

    public void unique_elements(int[] arr,int index)
    {
        int count = 0,i,j,k;
        Console.Write("\n\n");
        Console.WriteLine("The unique Elements in the array is :");
        for (i = 0; i < index; i++)
        {
            count = 0;
            
            for (j = 0; j < i - 1; j++)
            {
                
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }
            
            for (k = i + 1; k < index; k++)
            {
                
                if (arr[i] == arr[k])
                {
                    count++;
                }
              
                if (arr[i] == arr[i + 1])
                {
                    i++;
                }
            }
            
            if (count == 0)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }

    public void second_largenum(int[] arr,int index)
    {
        int large = 0,large2=0,i,j=0;
        for (i = 0; i < index; i++)
        {
            if (large < arr[i])
            {
                large = arr[i];
                j = i;
            }
        }
        for (i = 0; i < index; i++)
        {
            if (i == j)
            {
                i++; 
                i--;
            }
            else
            {
                if (large2 < arr[i])
                {
                    large2 = arr[i];
                }
            }
        }
        Console.Write("\n\n");
        Console.Write("The Second largest element in the array is : "+ large2);
        Console.Write("\n\n");
    }


    public void pattern(int ran)
    {
        int num = 1;
        Console.WriteLine("A)");
        for(int i = 1; i <= ran; i++)
        {
            for(int j = 1; j < i; j++)
            {
                Console.Write(num+" ");
                num++;
            }
            Console.Write("\n");
        }
        Console.WriteLine("B)");
        int num2 = 1;
        for(int i=1;i<=ran;i++)
        {
            for(int s = 1; s<=ran-i; s++)
            {
                Console.Write(" ");
            }
            for(int j = 1; j < i; j++)
            {
                Console.Write(num2 + " ");
                num2++;
            }
            Console.Write("\n");
        }
    }
}
class ElectricityBill
{
    private int customerid;
    private string name;
    private int unit;

    public ElectricityBill(int customerid, string name, int unit)
    {
        this.Customerid = customerid;
        this.Name = name;
        this.Unit = unit;
    }

    public int Customerid { get => customerid; set => customerid = value; }
    public string Name { get => name; set => name = value; }
    public int Unit { get => unit; set => unit = value; }

     public double Ebill()
    {
        double amount=0;
        double surcharge = 0;
        if (this.Unit <= 199)
        {
            amount = this.Unit * 1.20;
        }
        else if(this.Unit>=200 && this.Unit < 400)
        {
            amount = this.Unit * 1.50;
        }
        else if(this.Unit>=400 && this.Unit < 600)
        {
            amount = this.Unit * 1.80;
        }
        else if (this.Unit >= 600)
        {
            amount = this.Unit * 2.00;
        }

            if (amount > 400)
            {
                surcharge= amount*0.15;
            }
       return amount+surcharge;
    }
}
class Studentmark
{
    private string name;
    private int roll_no;
    private double phy_mark, che_mark, com_mark,total,percentage;

    public Studentmark(string name, int roll_no, double phy_mark, double che_mark, double com_mark)
    {
        this.Name = name;
        this.Roll_no = roll_no;
        this.Phy_mark = phy_mark;
        this.Che_mark = che_mark;
        this.Com_mark = com_mark;
        //this.Total = total;
        //this.Percentage = percentage;
    }

    public string Name { get => name; set => name = value; }
    public int Roll_no { get => roll_no; set => roll_no = value; }
    public double Phy_mark { get => phy_mark; set => phy_mark = value; }
    public double Che_mark { get => che_mark; set => che_mark = value; }
    public double Com_mark { get => com_mark; set => com_mark = value; }
    public double Total { get => total; set => total = value; }
    public double Percentage { get => percentage; set => percentage = value; }

    public void studtotal_per()
    {
  
        this.Total = this.Phy_mark + this.Che_mark + this.Com_mark;
        this.Percentage =(this.Total/300)*100;
    }
}

class Coordinates
{
    public void cordinate(int co1,int co2)
    {
        if (co1 > 0 && co2 > 0)
            Console.Write("The coordinate point ({0} {1}) lies in the First quandrant.\n\n", co1, co2);
        else if (co1 < 0 && co2 > 0)
            Console.Write("The coordinate point ({0} {1}) lies in the Second quandrant.\n\n", co1, co2);
        else if (co1 < 0 && co2 < 0)
            Console.Write("The coordinate point ({0} {1}) lies in the Third quandrant.\n\n", co1, co2);
        else if (co1 > 0 && co2 < 0)
            Console.Write("The coordinate point ({0} {1}) lies in the Fourth quandrant.\n\n", co1, co2);
        else if (co1 == 0 && co2 == 0)
            Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n", co1, co2);
    }
}