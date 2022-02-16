using NUnit.Framework;
using Moq;
using Greeting.Chain;

namespace Greeting.Test
{
    public class ManyNamesWithSomeUpperHandlerTests
    {
        private IGreetingHandler _sut;

        [SetUp]
        public void Setup()
        {
            
            _sut = new MoreNameWithUpperGreeting();
        }

        [Test]
        public void Should_Handle_Multiple_Name_With_Upper()
        {
            var expected = "Hello, Andrea and Franco. AND HELLO GIUSEPPE!";
            var actual = _sut.Handle("Andrea", "Franco", "GIUSEPPE");

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Should_Handle_Multiple_Name_With_Only_Upper()
        {
            var expected = "HELLO ANDREA, FRANCO, GIUSEPPE!";
            var actual = _sut.Handle("ANDREA", "FRANCO", "GIUSEPPE");

            Assert.AreEqual(expected, actual);
        }
    }
}