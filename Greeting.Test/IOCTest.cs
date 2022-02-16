using Greeting.Chain;
using Greeting.IOC;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting.Test
{
    internal class IOCTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestGetCalculator()
        {
            var greeter = Container.GetService<IGreeting>();
            Assert.IsNotNull(greeter);
        }

        [Test]
        public void TestGetValidator()
        {
            var handler = Container.GetService<IGreetingHandler>();
            Assert.IsNotNull(handler);
        }

        [Test]
        public void TestGetValidCalculator()
        {
            var greeter = Container.GetService<IGreeting>();
            var expected = typeof(Greeting);
            Assert.AreEqual(expected, greeter.GetType());
        }
    }
}
