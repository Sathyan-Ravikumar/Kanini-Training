using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class GenericCollectionsDemo
    {
        public void ListElements()
        {
            List<int> numbers = new List<int>();
            numbers.Add(55); 
            numbers.Add(60); 
            numbers.Add(24);
            numbers.Add(9);
            Console.WriteLine("First : ");
            foreach (int num in numbers)
            {
                Console.Write(num +" ");
            }
            numbers.Add(67);
            numbers.Add(20);
            numbers.Sort();
            Console.WriteLine("\nSecond : ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nAverage : " + numbers.Average());
            Console.WriteLine("Sum : " + numbers.Sum());
        }

        public void Stackelements()//stack - last in first out
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(25);
            numbers.Push(78);
            numbers.Push(13);
            numbers.Push(118);
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nPeek : "+numbers.Peek());//returns the top element.
            Console.WriteLine("pop : "+numbers.Pop());//remove and return the top element
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }

        public void QueueElements()//queue - First In First Out
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(25);
            numbers.Enqueue(50);
            numbers.Enqueue(65);
            numbers.Enqueue(13);
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }

        public void Dictionary_HashTableElements()
        {

            /* Dictionary<int,int> stud = new Dictionary<int,int>();  
             stud.Add(1, 25);
             stud.Add(6, 50);
             stud.Add(3, 222);
             foreach(int i in stud.Keys)
             {
                 Console.WriteLine(i);
             }

             foreach (int j in stud.Values)
             {
                 Console.WriteLine(j);
             }
             Console.WriteLine("value of key 6 " + stud[6]);

             Console.WriteLine("printing Value using keys :");
             foreach (int i in stud.Keys)
             {
                 Console.WriteLine(stud[i]);
             }*/
            Dictionary<string, string> stud = new Dictionary<string, string>();
            stud.Add("Rno", "101");
            stud.Add("name", "sathya");
            foreach (string i in stud.Keys)
            {
                Console.WriteLine(i+" "+stud[i]);
            }


        }

        public void SortedListElements()
        {
            SortedList<string, string> stud = new SortedList<string, string>();
            stud.Add("Rno", "101");
            stud.Add("name", "sathya");
            foreach (string i in stud.Keys)
            {
                Console.WriteLine(i + " " + stud[i]);
            }
        }

    }
}
