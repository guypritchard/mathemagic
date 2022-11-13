using Calculator.Core;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class AddTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(5, Operations.Add(0, 3));
        }
    }
}