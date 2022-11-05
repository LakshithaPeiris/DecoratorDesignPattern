using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class VehicleSpeedDecorator : VehicleDecorator
    {
        public VehicleSpeedDecorator(Vehicle decoratedVehicle) : base(decoratedVehicle)
        {
        }

        public override void Drive()
        {
            decoratedVehicle.Drive();
            this.SetSpeed(decoratedVehicle);
        }

        private void SetSpeed(Vehicle decoratedVehicle)
        {
            Console.WriteLine("High Speed");
        }
    }
}
