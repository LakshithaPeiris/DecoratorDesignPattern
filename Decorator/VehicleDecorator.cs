using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class VehicleDecorator: Vehicle
    {
        protected Vehicle decoratedVehicle;

        public VehicleDecorator(Vehicle decoratedVehicle)
        {
            this.decoratedVehicle = decoratedVehicle;
        }

        public override void Drive()
        {
            decoratedVehicle.Drive();
        }
    }
}
