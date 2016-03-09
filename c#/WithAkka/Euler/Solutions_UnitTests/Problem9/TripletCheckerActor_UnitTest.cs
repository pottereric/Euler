using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Problem9.Akka;

namespace Solutions_UnitTests.Problem9
{
    [TestClass]
    public class TripletCheckerActor_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var director = new Director();

            var result = director.Solve(12);

            Assert.AreEqual(result, 60);
        }
    }
}
