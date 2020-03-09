using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc.Test
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestEmptyString()
        {
            var t = new CalcCore();
            var ered = t.Feldolgoz("");
        }
        [TestMethod]
        public void Sum()
        {
            var t = new CalcCore();
            var ered = t.Feldolgoz("3+5");
            Assert.AreEqual(8, ered);
        }
    }
}
