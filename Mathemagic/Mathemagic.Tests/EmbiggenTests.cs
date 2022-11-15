using Mathemagic.Core;
using NUnit.Framework;

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
    }
}