using System;

namespace InterfaceSegregationPrinciple
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving the car...");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
