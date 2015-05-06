using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions_UnitTests.Problem9
{
    [TestClass]
    public class BruteForce_UnitTest
    {
        [TestMethod]
        public void SolveFor12()
        {
            var result = Solutions.Problem9.BruteForce.Solve(12);

            Assert.AreEqual(60, result);
        }

        [TestMethod]
        public void SolveFor1000()
        {
            var result = Solutions.Problem9.BruteForce.Solve(1000);

            Assert.AreEqual(31875000, result);
        }

    }
}
