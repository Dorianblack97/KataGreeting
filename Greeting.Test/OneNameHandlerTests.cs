using NUnit.Framework;
using Moq;
using Greeting.Chain;



namespace Greeting.Test
{
    public class OneNameHandlerTests
    {
        private IGreetingHandler _sut;

        [SetUp]
        public void Setup()
        {
            
            _sut = new OneNameGreeting();
          
        }

        [Test]
        public void Should_Add_Greeting_To_Name()
        {
            var expected = "Hello, Andrea.";
            var actual = _sut.Handle("Andrea");

            Assert.AreEqual(expected, actual);
        }
    }
}