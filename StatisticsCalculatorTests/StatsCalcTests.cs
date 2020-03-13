using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;

namespace StatisticsCalculatorTests
{
    [TestClass]
    public class StatsCalcTest
    {

        DescriptiveStats statsCalc = new DescriptiveStats();

        [TestMethod]
        public void ModeTest()
        {
            double[] DataPoints = { 1.0, 2.0, 2.0, 3.0, 4.0, 5.0, 6.0, 6.0, 2.0 };

            var result = statsCalc.Mode(DataPoints);
            Assert.AreEqual(2.0, result);
        }
    }
}
