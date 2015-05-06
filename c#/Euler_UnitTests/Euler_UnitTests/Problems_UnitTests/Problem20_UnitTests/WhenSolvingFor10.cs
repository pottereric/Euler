using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler.Utils;

namespace Euler_UnitTests.Problems_UnitTests.Problem20_UnitTests
{
    [TestClass]
    public class WhenSolvingFor10
    {
        [TestMethod]
        public void TheResultIs27()
        {
            int factorial = Factorial.Generate(10);
            int result = SumOfDigits.Generate(factorial);

            Assert.AreEqual(27, result);
        }
    }
}
