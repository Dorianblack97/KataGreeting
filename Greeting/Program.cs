using Greeting.IOC;
using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] names)
        {
            var greting = Container.GetService<IGreeting>();
            Console.WriteLine($"Il risultato è {greting.Greet("Gino")}");
            Console.ReadLine();
        }
    }
}
