using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareRoot;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquareRoot.Tests
{
    [TestClass()]
    public class SquareRootingTests
    {
        private SquareRooting SquareRoot = new SquareRooting(); //private property for the test class called calculator
        private readonly double aDouble = 1.5;


        [TestMethod()]
        public void RootTest()
        {
            SquareRoot.Root(aDouble);
            Assert.AreEqual(1.224744871391589, SquareRooting.Result);

        }
    }
}