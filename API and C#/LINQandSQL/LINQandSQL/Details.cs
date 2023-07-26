using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQandSQL
{
    internal class Stud_details
    {
        StudentClasses1DataContext stucontext = new StudentClasses1DataContext();
        SampleClasses1DataContext sampdbcntx = new SampleClasses1DataContext();

        public void ReadDataFromSqlServer()
        {
          
           
            //var res = from st in stucontext.stud_details where st.rno > 105 select st;

            var res = stucontext.stud_details.Select(st => st.rno);
            foreach (var r in res)
            {
                Console.WriteLine(r);
            }
        }
        public void CountMinMaxAvg() {

            var cou = (from st in stucontext.stud_details select st).Count();

            var min = (from st in stucontext.stud_details select st.rno).Min();//query
            var min1 = (int)stucontext.stud_details.Min(st => st.rno);//method
            Console.WriteLine("MINIMUM : "+min+"\nROW : "+cou);

            var avg = stucontext.stud_details.Average(st => st.rno);

            Console.WriteLine("AVERAGE : "+avg);
        }
        public void Joins()
        {
            var result = sampdbcntx.Employees.Join(sampdbcntx.departments, e => e.deptno, d => d.deptno, (e, d) => new
            {
                empname=e.ename,
                depatname=d.dname
            });

            foreach(var emp in result)
            {
                Console.WriteLine(emp.empname + "  "+emp.depatname);
            }
        }
    }
}
