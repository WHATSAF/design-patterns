using System;
using factory_method.Factories;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();
            var car = carFactory.CreateVehicle();
            car.MakeNoise();

            TrainFactory trainFactory = new TrainFactory();
            var train = trainFactory.CreateVehicle();
            train.MakeNoise();

            Console.ReadLine();
        }
    }
}
