using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PositionDecorator :EmployeeDetailsDecorator
    {
        private string position;

        public PositionDecorator(IEmployeeDetails employee, string position) : base(employee)
        {
            this.position = position;
        }

        public override string GetDetails()
        {
            string baseDetails = base.GetDetails();
            return $"{baseDetails}, Position: {position}";
        }

    }
}
