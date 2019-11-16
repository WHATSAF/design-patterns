using System;
using factory_method.Abstractions;

namespace factory_method.Instances
{
    public class Car : IVehicle
    {
        public void MakeNoise()
        {
            Console.WriteLine("dididi");
        }
    }
}