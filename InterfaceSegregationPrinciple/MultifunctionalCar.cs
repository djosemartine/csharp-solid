using System;

namespace InterfaceSegregationPrinciple
{
    public class MultifunctionalCar : IMultifunctionalCar
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
