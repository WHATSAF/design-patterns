using System;
using factory_method.Abstractions;

namespace factory_method.Instances
{
    public class Train : IVehicle
    {
        public void MakeNoise()
        {
            Console.WriteLine("kuangdang");
        }
    }
}