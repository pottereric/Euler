using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler.Utils;
using System.Numerics;

namespace Euler_UnitTests.Problems_UnitTests.Problem20_UnitTests
{
    [TestClass]
    public class WhenSolvingFor100
    {
        [TestMethod]
        public void TheResultShouldBe648()
        {
            BigInteger factorial = Factorial.Generate(new BigInteger(100));
            BigInteger result = SumOfDigits.Generate(factorial);

            Assert.AreEqual(648, result);
        }
    }
}
