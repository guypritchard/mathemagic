using Mathemagic.Core;
using NUnit.Framework;
using System;

namespace Mathemagic.Tests
{
    public class EmbiggenTests
    {
        [Test]
        public void Test1()
        {
            Operations.Embiggen(5);
        }

        [Test]
        public void Test2()
        {
            Operations.Embiggen(19);
        }

        [Test]
        public void Test3()
        {
            Operations.Embiggen(21);
        }

        [Test]
        public void Test4()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Operations.Embiggen(-1));
        }
    }
}