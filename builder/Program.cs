using System;
using builder.Directors;
using builder.Abstractions;
using builder.Implementations;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeMachine machine = new Starbucks();
            Barista barista = new Barista(machine);

            barista.Build();

            var latte = machine.GetLatte();
            latte.Drink();

            Console.ReadLine();
        }
    }
}
