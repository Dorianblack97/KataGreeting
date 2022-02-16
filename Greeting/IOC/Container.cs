using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Greeting.Chain;

namespace Greeting.IOC
{
    public class Container
    {
        public static T GetService<T>() => CreateHostBuilder().Services.GetService<T>();

        private static IHost CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
            .ConfigureServices((_, services) => services
                .AddSingleton<IGreeting, Greeting>()
                .AddSingleton<IGreetingHandler>(_ =>
                {
                    var nullGreeter = new NullNameGreeting();
                    var oneNameGreeter = new OneNameGreeting();
                    nullGreeter.SetNext(oneNameGreeter);
                    var manyUpperNameGreeter = new MoreNameWithUpperGreeting();
                    oneNameGreeter.SetNext(manyUpperNameGreeter);
                    var manyNameGreeter = new MoreNamesGreeting();
                    manyUpperNameGreeter.SetNext(manyNameGreeter);
                    return nullGreeter;
                }
                )
            ).Build();


    }
}
