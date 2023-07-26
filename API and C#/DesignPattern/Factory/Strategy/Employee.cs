using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        private IEmployeeDetailsStrategy detailsStrategy;

        public void SetDetailsStrategy(IEmployeeDetailsStrategy strategy)
        {
            detailsStrategy = strategy;
        }

        public void DisplayDetails()
        {
            detailsStrategy.DisplayDetails(this);
        }

    }
}
