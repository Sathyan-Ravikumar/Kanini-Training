using Calculations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNUnit
{
    [TestFixture(10,10)]
    public class CalculationTests
    {
        private Calculator? cal;
        
        private int n1, n2;
        public CalculationTests(int n1,int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        [SetUp]
        public void SetUp() {
            cal = new Calculator(n1,n2);
            Console.WriteLine("setup");
        }


        [TestCase(10,20,Author = "sathyan",Description ="Testing the Add Method")]
        [TestCase(-10,-20)]
        [Order(2)]

        public void AddTest(int n1,int n2)
        {
            cal = new Calculator(n1, n2);
            int res=cal!.Add();
            Assert.AreEqual(n1+n2,res);
            Console.WriteLine("Add");

        }


        [Ignore("In Process",Until ="2023-07-12")]
        [Test]
        [Order(3)]
        public void SubTest()
        {           
            int res = cal!.Sub();
            Assert.Zero(res);
            Console.WriteLine("sub");

        }
        [Test]
        [Order(1)] 
        public void MulTest()
        {
            int res = cal!.Mul();
            Assert.AreEqual(100, res);
            Console.WriteLine("mul");

        }


        [TearDown] 
        public void CloseTest()
        {
            cal = null;
            Console.WriteLine("closetest");

        }
    }
}


//annotations
//[test] is a general annotation 
//[testcase] is to pass some parameter.also we can pass parameters for methods needed .(author,description like that)It won't display this in output.it is for testing report
//[TearDown] used to close the methods
//[ignore] used to ignore the method 