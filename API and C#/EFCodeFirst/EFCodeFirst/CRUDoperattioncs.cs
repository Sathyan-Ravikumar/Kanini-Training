using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    internal class CRUDoperattioncs
    {
        public void InsertRecordsInCourseEntity()
        {
            using(var context = new CollegeContext())
            {
                var cour = new Course()
                {
                    CourseID = 102,
                    Name = "EEE",
                };
                context.Courses.Add(cour);
                context.SaveChanges();
            }
        }
        public void InsertRecordsInStudentEntity()
        {
            using (var context = new CollegeContext())
            {
                var stud = new Student()
                {
                    StudID = 1002,
                    Name = "Abi",
                    Age=22,
                };
                context.Students.Add(stud);
                context.SaveChanges();
            }
        }
        public void UpdateRecordInStudentEntity()
        {
            using(var context = new CollegeContext())
            {
               var st= context.Students.First<Student>();
                st.Age = 24;
                context.SaveChanges();
            }
        }
        public void DeleteRecordInStudentEntity()
        {
            using (var context = new CollegeContext())
            {
                var st = context.Students.First<Student>();
                context.Students.Remove(st);
                context.SaveChanges();
            }
        }
        public void ReadDataFromStudentEntity(string stname)
        {
            var context = new CollegeContext();
            var st = context.Students.Where(s => s.Name == stname);
            foreach(var s in st)
            {
                Console.WriteLine(s.StudID);
            }
           
        }
    }
}
