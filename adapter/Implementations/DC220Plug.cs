using System;
using adapter.Abstractions;

namespace adapter.Implementations
{
    public class DC220Plug : IPlug
    {
        public void Output()
        {
            Console.WriteLine("Direct current output 220v.");
        }
    }
}
