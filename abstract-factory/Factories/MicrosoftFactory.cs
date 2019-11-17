using abstract_factory.Instances;
using abstract_factory.Abstractions;

namespace abstract_factory.Factories
{
    public class MicrosoftFactory : IFactory
    {
        public IComputer CreateComputer()
        {
            return new Computer("microsoft");
        }

        public IMobilePhone CreateMobilePhone()
        {
            return new MobilePhone("microsoft");
        }
    }
}
