using adapter.Abstractions;

namespace adapter.Implementations
{
    public class Voltage220To100Adapter : IPlug
    {
        public Voltage220To100Adapter(DC100Plug dC100Plug)
        {
            _dc100Plug = dC100Plug;
        }

        private readonly DC100Plug _dc100Plug;

        public void Output()
        {
            _dc100Plug.Output();
        }
    }
}
