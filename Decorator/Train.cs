using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Train:Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Drive Train");
        }
    }
}
