using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class RaceCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("If it has anything other than 2 wheels we create a race car.");
        }
    }
}
