using Greeting.Chain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting.Test
{
    internal class OneNameUpperHandlerTests
    {
        private IGreetingHandler _sut;

        [SetUp]
        public void Setup()
        {

            _sut = new OneNameUpperGreeting();

        }
        [Test]
        public void Should_Handle_Uppercase_Name()
        {
            var expected = "HELLO, ANDREA!";
            var actual = _sut.Handle("ANDREA");

            Assert.AreEqual(expected, actual);
        }
    }
}
