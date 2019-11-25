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

            var latte = barista.Build();
            latte.Drink();

            Console.ReadLine();
        }
    }
}
