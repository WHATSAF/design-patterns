using abstract_factory.Instances;
using abstract_factory.Abstractions;

namespace abstract_factory.Factories
{
    public class AppleFactory : IFactory
    {
        public IComputer CreateComputer()
        {
            return new Computer("apple");
        }

        public IMobilePhone CreateMobilePhone()
        {
            return new MobilePhone("apple");
        }
    }
}
