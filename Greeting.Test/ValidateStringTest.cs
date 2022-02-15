using NUnit.Framework;
using Moq;
using Greeting.Chain;
using Greeting.Extensions;

namespace Greeting.Test
{
    public class ValidateStringTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void SeparateStringTest()
        {
            var actual = new string[] { "Bob", "Charlie, Dianne" };
            var expected = new string[] { "Bob", "Charlie", "Dianne" };
            Assert.AreEqual(expected, actual.Validate());
        }

        [Test]
        public void CommaStringTest()
        {
            var actual = new string[] { "Bob", "\"Charlie, Dianne\"" };
            var expected = new string[] { "Bob", "Charlie, Dianne" };
            Assert.AreEqual(expected, actual.Validate());
        }
    }
}
