using System;
using RestEase;
using Shamrock.Core._4Chan.API;

namespace Shamrock.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = RestClient.For<I4ChanApi>("http://a.4cdn.org/");

            var boards = api.GetBoards().Result;
            Console.ReadLine();
        }
    }
}
