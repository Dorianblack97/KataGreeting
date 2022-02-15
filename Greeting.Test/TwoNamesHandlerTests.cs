using NUnit.Framework;
using Moq;
using Greeting.Chain;

namespace Greeting.Test
{
    public class TwoNamesHandlerTests
    {
        private IGreetingHandler _sut;

        [SetUp]
        public void Setup()
        {            
            _sut = new MoreNamesGreeting();
        }

        [Test]
        public void Should_Handle_Two_Name()
        {
            var expected = "Hello, Andrea and Franco.";
            var actual = _sut.Handle("Andrea", "Franco");

            Assert.AreEqual(expected, actual);
        }
    }
}