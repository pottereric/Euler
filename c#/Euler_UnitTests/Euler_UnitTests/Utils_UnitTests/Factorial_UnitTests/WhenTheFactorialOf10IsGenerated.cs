using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler.Utils;

namespace Euler_UnitTests.Utils_UnitTests
{
    [TestClass]
    public class WhenTheFactorialOf10IsGenerated
    {
        [TestMethod]
        public void TheResultIs3628800()
        {
            int factorial = Factorial.Generate(10);

            Assert.AreEqual(3628800, factorial);
        }
    }
}
