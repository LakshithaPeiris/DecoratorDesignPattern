using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            Vehicle speedCar = new VehicleSpeedDecorator(new Car());
            Vehicle train = new Train();
            Vehicle speedTrain = new VehicleSpeedDecorator(new Train());

            Console.WriteLine("+++Normal Car+++");
            car.Drive();

            Console.WriteLine("@@@Speed Car@@@");
            speedCar.Drive();

            Console.WriteLine("+++Normal Train+++");
            train.Drive();

            Console.WriteLine("@@@Speed Train@@@");
            speedTrain.Drive();

            Console.ReadKey();

        }
    }
}
