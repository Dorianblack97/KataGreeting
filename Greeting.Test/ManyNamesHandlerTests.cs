using NUnit.Framework;
using Moq;
using Greeting.Chain;

namespace Greeting.Test
{
    public class ManyNamesHandlerTests
    {
        private IGreetingHandler _sut;

        [SetUp]
        public void Setup()
        {
            
            _sut = new MoreNamesGreeting();
        }

        [Test]
        public void Should_Handle_Multiple_Name()
        {
            var expected = "Hello, Andrea, Franco and Giuseppe.";
            var actual = _sut.Handle("Andrea", "Franco", "Giuseppe");

            Assert.AreEqual(expected, actual);
        }
    }
}