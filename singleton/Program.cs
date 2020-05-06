using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LazyedSingleton> singletons = new List<LazyedSingleton>();

            var parallelState = Parallel.For(0, 10, i =>
            {
                Console.WriteLine("id: {0}, thread id: {1}.", i, Thread.CurrentThread.ManagedThreadId);

                singletons.Add(LazyedSingleton.Instance);
            });

            while (parallelState.IsCompleted)
            {
                bool allReferenceEquals = true;

                for (int i = 1; i < singletons.Count; i++)
                {
                    if (!singletons[i - 1].Equals(singletons[i]))
                        allReferenceEquals = false;
                }

                if (allReferenceEquals)
                    Console.WriteLine("all objects equals.");
                else
                    Console.WriteLine("not all objects equals.");

                break;
            }

            Console.ReadLine();
        }
    }
}
