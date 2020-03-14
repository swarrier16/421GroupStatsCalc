using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;

namespace StatisticsCalculatorTests
{
    [TestClass]
    public class StatsCalcTest
    {

        DescriptiveStats statsCalc = new DescriptiveStats();
        PopulationStats popCalc = new PopulationStats();

        [TestMethod]
        public void ModeTest()
        {
            double[] DataPoints = { 1.0, 2.0, 2.0, 3.0, 4.0, 5.0, 6.0, 6.0, 2.0 };

            var result = statsCalc.Mode(DataPoints);
            Assert.AreEqual(2.0, result);
        }
        [TestMethod]
        public void MeanTest()
        {
            double[] DataPoints = { 1.0, 2.0, 3.0, 4.0, 5.0 };

            var result = statsCalc.Mean(DataPoints);
            Assert.AreEqual(3.0, result);
        }
        [TestMethod]
        public void VarianceTest()
        {
            double[] DataPoints = { 17.0, 15.0, 23.0, 7.0, 9.0, 13.0 };

            var result = statsCalc.Variance(DataPoints);
            Assert.AreEqual(33.2, result);
        }
        [TestMethod]
        public void StandardDevTest()
        {
            double[] DataPoints = { 9.0, 2.0, 5.0, 4.0, 12.0, 7.0 };

            var result = statsCalc.StandardDev(DataPoints);
            Assert.AreEqual(3.619, result);
        }
        [TestMethod]
        public void ZScoreTest()
        {
            double a = 86.0;
            double b = 85.0;
            double c = 2.0;

            var result = statsCalc.zScore(a, b, c);
            Assert.AreEqual(0.5, result);
        }

        [TestMethod]
        public void PopCorrelationTest()
        {
            double[] DataPointsX = { 1, 2, 3, 4, 5 };
            double[] DataPointsY = { 11, 22, 34, 43, 56 };

            var result = statsCalc.PopCoefficient(DataPointsX, DataPointsY);
            Assert.AreEqual(0.7991887154553378, result);
        }

        [TestMethod]
        public void MeanDeviationTest()
        {
            double[] DataPoints = { 12.0, 24.0, 41.0, 51.0, 67.0, 67.0, 85.0, 99.0 };

            var result = statsCalc.MeanDeviation(DataPoints);
            Assert.AreEqual(23.75, result);
        }

        [TestMethod]
        public void SampleRandomSampleTest()
        {
            decimal sample = 10M;
            decimal population = 100M;


            var result = popCalc.SimpleRandomSample(sample, population);
            Assert.AreEqual(0.10M, result);
        }

        [TestMethod]
        public void SystematicSamplingTest()
        {
            decimal sample = 10M;
            decimal population = 100M;


            var result = popCalc.SystematicSampling(sample, population);
            Assert.AreEqual(10M, result);
        }
    }
}
