using Division;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfaceTests
{
    [TestClass()]
    class DividingTests
    {
        Dividing Division = new Dividing();
        private readonly int aInt = 2;
        private readonly int bInt = 16;
        private readonly double aDouble = 2.5;
        private readonly double bDouble = 16.5;

        [TestMethod()]
        public void QuotientIntTest()
        {
            Division.Quotient(bInt, aInt);
            Assert.AreEqual(8, Dividing.Result);
        }

        [TestMethod()]
        public void QuotientDoubleTest()
        {
            Division.Quotient(bDouble, aDouble);
            Assert.AreEqual(6.6, Dividing.Result);
        }
    }
}

