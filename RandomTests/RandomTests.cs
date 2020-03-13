using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomGen;

namespace RandomTests
{
    [TestClass]
    public class RandomTest
    {

        [TestMethod]
        public void DecimalRangeTest()
        {
            decimal _value = Randos.Generate(5M, 0, 100);

            Assert.AreEqual(33.84M, _value);
        }

        [TestMethod]
        public void IntRangeTest()
        {
            int _value = Randos.Generate(5, 0, 100);

            Assert.AreEqual(33, _value);
        }


        [TestMethod]
        public void IntListTest()
        {

            int[] arrayList = { 6, 6, 6, 8, 7 };
            int[] _value = Randos.Generate(5, 5, 5, 10);
            CollectionAssert.AreEqual(arrayList, _value);
        }

        [TestMethod]
        public void DecimalListTest()
        {

            decimal[] arrayList = { 6.69M, 6.42M, 6.31M, 8.13M, 7.32M };
            decimal[] _value = Randos.Generate(5M, 5, 5, 10);
            CollectionAssert.AreEqual(arrayList, _value);
        }

        [TestMethod]
        public void SeedSelectTest()
        {

            decimal _value = Randos.SeedSelect(5M, 5, 5, 10);
            Assert.AreEqual(6.42M, _value);
        }

        [TestMethod]
        public void NSeedSelectTest()
        {
            decimal[] arrayList = { 9.36M, 6.83M, 5.26M };
            decimal[] _value = Randos.NSeedSelect(7M, 5, 5, 10, 3);
            CollectionAssert.AreEqual(arrayList, _value);
        }

        //[TestMethod]
        //public void NSelectTest()
        //{

        //    decimal[] _value = Randos.NSelect(5M, 5, 5, 10, 3);
        //    Assert.AreEqual(6.42M, _value);
        //}

        //[TestMethod]
        //public void RandomSelectTest()
        //{

        //    decimal _value = Randos.RandomSelect(5M, 5, 5, 10);
        //    Assert.AreEqual(7.32, _value);
        //}

        //[TestMethod]
        //public void IntNoSeedTest()
        //{
        //    decimal _value = Randos.GenerateInt(5,10);

        //    Assert.AreEqual(5M, _value);
        //}

        //[TestMethod]
        //public void DeciNoSeedTest()
        //{
        //    decimal _value = Randos.GenerateDecimal(5M, 10M);
        //    Assert.AreEqual(6.49M, _value);
        //}



    }
}

