using System;
using abstract_factory.Abstractions;

namespace abstract_factory.Instances
{
    public class Computer : IComputer
    {
        public Computer(string bornAt)
        {
            _bornAt = bornAt;
        }

        private readonly string _bornAt;

        public void Play()
        {
            Console.WriteLine("i can play, i'm born at {0}", _bornAt);
        }
    }
}
