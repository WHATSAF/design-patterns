using factory_method.Instances;
using factory_method.Abstractions;

namespace factory_method.Factories
{
    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}