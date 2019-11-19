using System;
using proxy.Abstractions;

namespace proxy.SearchEngines
{
    public class SearchGoogle : ISearch
    {
        public void Search()
        {
            Console.WriteLine("I will search the Google.");
        }
    }
}
