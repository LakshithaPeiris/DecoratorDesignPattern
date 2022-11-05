using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Drive Vehicle");
        }
    }
}
