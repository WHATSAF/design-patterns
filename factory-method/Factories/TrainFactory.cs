using factory_method.Instances;
using factory_method.Abstractions;

namespace factory_method.Factories
{
    public class TrainFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Train();
        }
    }
}