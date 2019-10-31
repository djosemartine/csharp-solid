using System;

namespace InterfaceSegregationPrinciple
{
    public class Airplane : IVehicle
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("Flying the airplane");
        }
    }
}
