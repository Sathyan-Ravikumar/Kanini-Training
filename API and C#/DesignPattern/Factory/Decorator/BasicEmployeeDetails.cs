using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class BasicEmployeeDetails : IEmployeeDetails
    {
        private string name;

        public BasicEmployeeDetails(string name)
        {
            this.name = name;
        }

        public string GetDetails()

        {
            return $"Name: {name}";
        }

    }
}
