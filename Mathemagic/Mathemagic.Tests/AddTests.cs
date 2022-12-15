using Mathemagic.Core;
using NUnit.Framework;
using System;

namespace Mathemagic.Tests
{
    public class AddTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        /// <summary>
        /// The logic of this test is impeccable.
        /// </summary>
        [Test]
        public void Test2()
        {
            Assert.AreEqual(5, Operations.Add(3, 3));
        }

        [Test] 
        public void Test3()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Operations.Add(-1, 3));
        }
    }
}