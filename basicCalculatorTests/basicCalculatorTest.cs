using Microsoft.VisualStudio.TestTools.UnitTesting;
using basicCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using Subtraction;
using Square;
using SquareRoot;
using Multiplication;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private basicCalculators Calculator = new basicCalculators(); //private property for the test class called calculator
        private readonly int aInt = 1;
        private readonly int bInt = 2;
        private readonly double aDouble = 1.5;
        private readonly double bDouble = 2.5;
        private readonly decimal aDecimal = 1.5M;
        private readonly decimal bDecimal = 2.5M;

       

       
        [TestMethod()]
        public void MultiplyIntegerTest()
        {
            Calculator.Product(aInt, bInt);
            Assert.AreEqual(2, basicCalculators.Result);
        }
        [TestMethod()]
        public void MultiplyDoubleTest()
        {
            Calculator.Product(aDouble, bDouble);
            Assert.AreEqual(3.75, basicCalculators.Result);
        }
        
        [TestMethod()]
        public void SquareRootTest()
        {
            Calculator.Root(aDouble);
            Assert.AreEqual(1.224744871391589, basicCalculators.Result);
        }

        [TestMethod()]
        public void SubtractionIntTest()
        {
            Calculator.Difference(bInt, aInt);
            Assert.AreEqual(1, basicCalculators.Result);
        }
        [TestMethod()]
        public void SubtractionDoubleTest()
        {
            Calculator.Difference(bDouble, aDouble);
            Assert.AreEqual(1, basicCalculators.Result);
        }
        [TestMethod()]
        public void SquareIntTest()
        {
            Calculator.SquareExpo(bInt);
            Assert.AreEqual(4, basicCalculators.Result);
        }
        public void SquareDoubleTest()
        {
            Calculator.SquareExpo(bDouble);
            Assert.AreEqual(6.50, basicCalculators.Result);
        }
    }
}