using System;

namespace InterfaceSegregationPrinciple
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving the car...");
        }
    }
}
