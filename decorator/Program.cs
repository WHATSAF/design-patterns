using System;
using decorator.Abstractions;
using decorator.Implementations;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IESmoking eSmoking = new IqosESmoking();
            eSmoking.Show();

            Marlboro marlboro = new Marlboro(eSmoking);
            marlboro.Smoke();

            Heets heets = new Heets(eSmoking);
            heets.Smoke();

            Console.ReadLine();
        }
    }
}
