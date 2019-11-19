using System;
using adapter.Abstractions;

namespace adapter.Implementations
{
    public class DC100Plug
    {
        public void Output()
        {
            Console.WriteLine("Direct current output 100v.");
        }
    }
}
