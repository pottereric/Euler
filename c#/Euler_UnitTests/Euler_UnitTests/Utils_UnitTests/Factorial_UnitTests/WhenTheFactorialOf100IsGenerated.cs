using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler.Utils;
using System.Numerics;

namespace Euler_UnitTests.Utils_UnitTests
{
    [TestClass]
    public class WhenTheFactorialOf100IsGenerated
    {
        [TestMethod]
        public void TheResultIs3628800()
        {
            int factorial = Factorial.Generate(10);

            Assert.AreEqual(3628800, factorial);
        }

        [TestMethod]
        public void TheBigIntResultIs3628800()
        {
            var factorial = Factorial.Generate(new BigInteger(10));

            Assert.AreEqual(3628800, factorial);
        }
    }
}
