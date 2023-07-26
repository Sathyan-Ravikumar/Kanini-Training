using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class NonGeneric
    {
        public void ArrayListElements()
        {
            ArrayList arrlist = new ArrayList();
            arrlist.Add(55);
            arrlist.Add("Hii");
            arrlist.Add(" ");
            arrlist.Add(21.23);
            arrlist.Add(67.0000012121);
            arrlist.Add(0.0);
            foreach (var i in arrlist)
            {
                Console.Write(i + " ");
            }
            arrlist.Insert(1, "hello");
            Console.WriteLine("\n");
            foreach (var i in arrlist)
            {
                Console.Write(i + " ");
            }


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
            Console.WriteLine("\nPeek : " + numbers.Peek());//returns the top element.
            Console.WriteLine("pop : " + numbers.Pop());//remove and return the top element
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

        public void HashTableElements()
        {

             Hashtable stud = new Hashtable();  
             stud.Add(1, 25);
             stud.Add(6, 50);
             stud.Add(3, 222);
             foreach(var i in stud.Keys)
             {
                 Console.WriteLine(i);
             }

             foreach (var j in stud.Values)
             {
                 Console.WriteLine(j);
             }
             Console.WriteLine("value of key 6 " + stud[6]);

             Console.WriteLine("printing Value using keys :");
             foreach (var i in stud.Keys)
             {
                 Console.WriteLine(stud[i]);
             }
            


        }

        public void SortedListElements()
        {
            SortedList stud = new SortedList();
            stud.Add("Rno", "101");
            stud.Add("name", "sathya");
            foreach (var i in stud.Keys)
            {
                Console.WriteLine(i + " " + stud[i]);
            }
        }

    }
}
