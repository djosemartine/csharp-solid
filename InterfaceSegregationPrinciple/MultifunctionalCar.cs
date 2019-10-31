using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class MultifunctionalCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving...");
        }

        public void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
}
