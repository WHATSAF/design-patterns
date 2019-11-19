using System;
using proxy.Abstractions;
using proxy.SearchEngines;

namespace proxy
{
    public class Proxy : ISearch
    {
        private readonly ISearch _google = new SearchGoogle();

        public void Search()
        {
            Console.WriteLine("I can also do something before search the Google.");
            _google.Search();
            Console.WriteLine("And do someting after search the Google.");
        }
    }
}
