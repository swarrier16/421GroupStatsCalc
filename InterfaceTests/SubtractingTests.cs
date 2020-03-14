using Microsoft.VisualStudio.TestTools.UnitTesting;
using Subtraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subtraction.Tests
{
    [TestClass()]
    public class SubtractingTests
    {
        Subtracting Subtraction = new Subtracting();
        private readonly int aInt = 1;
        private readonly int bInt = 2;
        private readonly double aDouble = 1.5;
        private readonly double bDouble = 2.5;


        [TestMethod()]
        public void DifferenceIntTest()
        {
            Subtraction.Difference(aInt, bInt);
            Assert.AreEqual(-1, Subtracting.Result);
        }

        [TestMethod()]
        public void DifferenceDoubleTest()
        {
            Subtraction.Difference(aDouble, bDouble);
            Assert.AreEqual(-1, Subtracting.Result);
        }
    }
}