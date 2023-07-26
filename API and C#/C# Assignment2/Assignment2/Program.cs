


using Assignment2;
using System.Runtime.InteropServices;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Enter the total number of index : ");
        num=Convert.ToInt32(Console.ReadLine());   
        string[] str = new string[num];
        for(int i = 0; i < num; i++)
        {
            str[i] = Console.ReadLine();
        }
        string end=Console.ReadLine();
        Answer7 ending = new Answer7();
        ending.AddEnding(str, end);

        /*
       //6
       Console.WriteLine("Enter the cup count");
       int cup = Convert.ToInt32(Console.ReadLine());
       Answer6 coffee = new Answer6(cup);
       Console.WriteLine("Total Number of cups : " + coffee.TotalCups());



      //5
      Console.WriteLine("Enter the age");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the breaktime");
      bool breaktime = Convert.ToBoolean(Console.ReadLine());
      Answer5 bartender = new Answer5(age, breaktime);
      Console.WriteLine("Should Serve Drinks : "+bartender.ShouldServeDrinks());


      //4
      Console.WriteLine("Enter the number");
      int number = Convert.ToInt32(Console.ReadLine());

      Answer4 box = new Answer4(number);
      Console.WriteLine("Number os stacked boxes : " + box.StackBoxes());


     //3
     Console.WriteLine("Enter the prob");
     double prob = Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("Enter the prize");
     int prize = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter the pay");
     int pay = Convert.ToInt32(Console.ReadLine());

     Answer3 gamble = new Answer3(prob, prize, pay);
     Console.Write("Profitable Gamble : ");
     Console.WriteLine(gamble.ProfitableGamble());


     //2
     Console.WriteLine("Enter the number of wins");
     int wins = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter the number of draws");
     int draws = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter the losses");
     int losses = Convert.ToInt32(Console.ReadLine());
    answer2 football = new answer2(wins, draws, losses);
     Console.Write("Total Points : ");
     Console.WriteLine(football.FootballPoints());*/


    }
}