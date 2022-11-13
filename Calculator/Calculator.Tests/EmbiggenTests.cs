using Calculator.Core;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class EmbiggenTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(20, Operations.Embiggen(5));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(20, Operations.Embiggen(19));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(22, Operations.Embiggen(21));
        }
    }
}