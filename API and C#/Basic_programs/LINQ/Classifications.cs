using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Classifications
    {
        public void example1()
        {
            List<string> course = new List<string>();
            course.Add("C++ Tutorials");
            course.Add("C# Tutorials");
            course.Add("Learn SQL");
            course.Add("VC++ Tutorials");
            course.Add("Web technology");

            var tutcourse = from c in course where c.Contains("Tutorials") select c;

            var tutocourse = course.Where(c => c.Contains("Tutorials")).Where(c => c.StartsWith("C"));
                

            foreach(var tut in tutocourse)
            {
                Console.WriteLine(tut);
            }

        }
        public void example2()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "AAA", StudentAge = 13} ,
                new Student() { StudentID = 2, StudentName = "BBB",  StudentAge = 21 } ,
                new Student() { StudentID = 3, StudentName = "CCC",  StudentAge = 18 } ,
                new Student() { StudentID = 4, StudentName = "DDD" , StudentAge = 20} ,
                new Student() { StudentID = 5, StudentName = "EEE" , StudentAge = 15 }
            };

            var filterResult = from s in studentList where s.StudentAge > 12 && s.StudentAge < 20 select s;
            foreach(var std in filterResult)
            {
                Console.WriteLine(std.StudentName);
            }
        }

        public void FilteringOfType()
        {
            IList elements = new ArrayList();
            elements.Add(1);
            elements.Add("Two");
            elements.Add(3);
            elements.Add(4);
            elements.Add("Five");

            var strings = from e in elements.OfType<string>() select e;
            var numbers = from e in elements.OfType<Int32>() select e;

            foreach(string str in strings)
            {
                Console.WriteLine("String : "+str);
            }
            foreach (int number in numbers)
            {
                Console.WriteLine("Number : "+number);
            }

        }
        public void MethodOfType()
        {
            IList elements = new ArrayList();
            elements.Add(1);
            elements.Add("Two");
            elements.Add(3);
            elements.Add(4);
            elements.Add("Five");
            var numbers=elements.OfType<Int32>();   
            var strings=elements.OfType<String>();
            foreach (string str in strings)
            {
                Console.WriteLine("String : " + str);
            }
            foreach(int number in numbers)
            {
                Console.WriteLine("Number : " + number);
            }
        }
        public void SortingOrderBy()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Kani", StudentAge = 13} ,
                new Student() { StudentID = 2, StudentName = "Kannan",  StudentAge = 21 } ,
                new Student() { StudentID = 3, StudentName = "Abi",  StudentAge = 10 } ,
                new Student() { StudentID = 4, StudentName = "Jeeva" , StudentAge = 20} ,
                new Student() { StudentID = 5, StudentName = "Boo" , StudentAge = 15 },
                new Student() { StudentID = 6, StudentName = "Deepika" , StudentAge = 23 },
                new Student() { StudentID = 7, StudentName = "Sundhar" , StudentAge = 10 }

            };

            var order = from o in studentList orderby  o.StudentName  select o;
            var orderMethod = studentList.OrderBy(s=>s.StudentAge).ThenBy(s => s.StudentName);

            foreach(var query in order)
            {
                Console.WriteLine(query.StudentName);
            }
            foreach(var method in orderMethod)
            {
                Console.WriteLine(method.StudentName + " "+ method.StudentAge);
            }
        }
        public void Groupby()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Kani", StudentAge = 13} ,
                new Student() { StudentID = 2, StudentName = "Kannan",  StudentAge = 21 } ,
                new Student() { StudentID = 3, StudentName = "Abi",  StudentAge = 10 } ,
                new Student() { StudentID = 4, StudentName = "Jeeva" , StudentAge = 20} ,
                new Student() { StudentID = 5, StudentName = "Archana" , StudentAge = 15 },
                new Student() { StudentID = 6, StudentName = "Deepika" , StudentAge = 23 },
                new Student() { StudentID = 7, StudentName = "Sundhar" , StudentAge = 10 }

            };

            var group = from g in studentList group g by g.StudentAge;
            var look = studentList.ToLookup(g => g.StudentAge);
            foreach(var result in group)
            {
                Console.WriteLine(result.Key);
                foreach(var g in result)
                {
                    Console.WriteLine(g.StudentName);
                }
            }


            Console.WriteLine("\nLook Up :");
            foreach (var result in look)
            {
                Console.WriteLine(result.Key);
                foreach (var g in result)
                {
                    Console.WriteLine(g.StudentName);
                }
            }
        }
    }
}
