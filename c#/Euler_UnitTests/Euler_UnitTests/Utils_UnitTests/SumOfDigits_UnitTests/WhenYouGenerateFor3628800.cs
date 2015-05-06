using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler.Utils;
using System.Numerics;

namespace Euler_UnitTests.Utils_UnitTests.SumOfDigits_UnitTests
{
    [TestClass]
    public class WhenYouGenerateFor3628800
    {
        [TestMethod]
        public void TheResultIs27()
        {
            int result = SumOfDigits.Generate(3628800);


            Assert.AreEqual(27, result);
        }

        [TestMethod]
        public void TheBigResultIs27()
        {
            var result = SumOfDigits.Generate(new BigInteger(3628800));


            Assert.AreEqual(27, result);
        }

    }
}
