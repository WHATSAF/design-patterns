using System;
using adapter.Abstractions;
using adapter.Implementations;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlug dc = new DC220Plug();
            dc.Output();

            dc = new Voltage220To100Adapter(new DC100Plug());
            dc.Output();

            Console.ReadLine();
        }
    }
}
