using Microsoft.VisualStudio.TestTools.UnitTesting;
using Addition;

namespace InterfaceTests
{
    [TestClass()]
    class AddingTests
    {
        Adding Addition = new Adding();
        private readonly int aInt = 1;
        private readonly int bInt = 2;
        private readonly double aDouble = 1.5;
        private readonly double bDouble = 2.5;

        [TestMethod()]
        public void SumIntTest()
        {
            Addition.Sum(aInt, bInt);
            Assert.AreEqual(3, Adding.Result);
        }

        [TestMethod()]
        public void SumDoubleTest()
        {
            Addition.Sum(aDouble, bDouble);
            Assert.AreEqual(4.0, Adding.Result);
        }
    }
}
