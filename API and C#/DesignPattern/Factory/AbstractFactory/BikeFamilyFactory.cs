using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class BikeFamilyFactory : VehicleFamilyFactory
    {
        public override VehicleFactory CreateCarFactory()
        {
            throw new NotImplementedException();
        }

        public override VehicleFactory CreateBikeFactory()
        {
            throw new NotImplementedException();
        }

    }
}
