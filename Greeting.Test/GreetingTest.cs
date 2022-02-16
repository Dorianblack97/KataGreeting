using Greeting.IOC;
using NUnit.Framework;

namespace Greeting.Test
{
    public class GreetingTests
    {
        private IGreeting _sut;

        [SetUp]
        public void Setup()
        {

            _sut = Container.GetService<IGreeting>();
        }

        [Test]        
        public void Should_Add_Greeting_To_Name()
        {
            var expected = "Hello, Andrea.";
            var actual = _sut.Greet("Andrea");

            Assert.AreEqual(expected, actual);
        }

        [Test]        
        public void Should_Handle_Null_Name()
        {
            var expected = "Hello, my friend.";
            var actual = _sut.Greet(null);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_Handle_Uppercase_Name()
        {
            var expected = "HELLO, ANDREA!";
            var actual = _sut.Greet("ANDREA");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_Handle_Two_Name()
        {
            var expected = "Hello, Andrea and Franco.";
            var actual = _sut.Greet("Andrea", "Franco");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_Handle_Multiple_Name()
        {
            var expected = "Hello, Andrea, Franco and Giuseppe.";
            var actual = _sut.Greet("Andrea", "Franco", "Giuseppe");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Should_Handle_Multiple_Name_With_Upper()
        {
            var expected = "Hello, Andrea and Franco. AND HELLO GIUSEPPE!";
            var actual = _sut.Greet("Andrea", "Franco", "GIUSEPPE");

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SeparateStringTest()
        {
            var actual = _sut.Greet("Bob", "Charlie, Dianne");
            var expected = "Hello, Bob, Charlie and Dianne.";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CommaStringTest()
        {
            var actual = _sut.Greet("Bob", "\"Charlie, Dianne\"");
            var expected = "Hello, Bob and Charlie, Dianne.";
            Assert.AreEqual(expected, actual);
        }

    }
}