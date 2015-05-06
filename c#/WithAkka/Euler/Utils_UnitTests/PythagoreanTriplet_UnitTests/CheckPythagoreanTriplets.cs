using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils;

namespace Utils_UnitTests.PythagoreanTriplet_UnitTests
{
    [TestClass]
    public class CheckPythagoreanTriplets
    {
        [TestMethod]
        public void Check_3_4_5()
        {
            bool result = PythagoreanTriplet.Validate(3, 4, 5);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_2_3_4()
        {
            bool result = PythagoreanTriplet.Validate(2, 3, 4);
            Assert.IsFalse(result);
        }
    }
}
