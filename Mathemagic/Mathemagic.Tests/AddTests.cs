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

        [Test] 
        public void Test2()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Operations.Add(-1, -1));
        }

        // [Test]
        // public void Missing_Test1()
        // {
        //     Assert.Throws<ArgumentOutOfRangeException>(() => Operations.Add(-1, 3));
        // }

        // [Test]
        // public void Missing_Test2()
        // {
        //     Assert.Throws<ArgumentOutOfRangeException>(() => Operations.Add(3, -1));
        // }

        // [Test] 
        // public void Missing_Test3()
        // {
        //     Assert.AreEqual(2, Operations.Add(2, 0));
        // }

        // [Test]
        // public void Missing_Test4()
        // {
        //     Assert.AreEqual(5, Operations.Add(3, 2));
        // }

        // [Test] 
        // public void Missing_Test5()
        // {
        //     Assert.AreEqual(3, Operations.Add(0, 3));
        // }
    }
}