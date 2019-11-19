using System;
using proxy.Abstractions;

namespace proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ISearch proxy = new Proxy();
            proxy.Search();

            Console.ReadLine();
        }
    }
}
