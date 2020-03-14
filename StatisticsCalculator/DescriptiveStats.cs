using System;
using basicCalculator;
using Microsoft.CSharp;

namespace StatisticsCalculator
{
    public class DescriptiveStats : basicCalculators
    {
        private basicCalculators Calculator = new basicCalculators();

        public double Mode(dynamic DataPoints)
        {
            double[] values = DataPoints;
            int[] count = new int[values.Length];
            double highestCount = 0;

            for (int i = 0; i < values.Length; i++)
            {
                for (int y = 1; y < values.Length; y++)
                {
                    if (values[y] == i)
                    {
                        count[i]++;
                    }
                }
                //loop through each instance and count how many times each appears
            }
            for (int x = 0; x < count.Length - 1; x++)
            {
                if (count[x] > count[x + 1])
                {
                    highestCount = values[x];
                }
                else
                {
                    highestCount = values[x + 1];
                }
            }
            return highestCount;
        }
        public double Mean(dynamic DataPoints)
        {
            double[] values = DataPoints;
            double total = 0;

            for (int i = 0; i < values.Length; i++)
            {
                total = Calculator.Sum(total, values[i]);
            }

            double m = Calculator.Quotient(total, (values.Length));

            return m;
        }

        public double Variance(dynamic DataPoints)
        {
            double[] values = DataPoints;
            double mean = Mean(DataPoints);
            double sumOfSquares = 0;

            foreach (double num in values)
            {
                double diff = Calculator.Difference(num, mean);
                double sq = Calculator.SquareExpo(diff);
                sumOfSquares = Calculator.Sum(sumOfSquares, sq);
            }

            double div = Calculator.Quotient(sumOfSquares, (values.Length - 1));
            return div;
        }

        public double StandardDev(dynamic DataPoints)
        {
            double variance = Variance(DataPoints);
            double result = Calculator.Root(variance);
            result = Math.Round(result, 3);
            return result;
        }

        public double zScore(dynamic point, dynamic mean, dynamic sd)
        {
            double dividend = Calculator.Difference(point, mean);
            double result = Calculator.Quotient(dividend, sd);
            return result;
        }

        public double PopCoefficient(dynamic DataPointsX, dynamic DataPointsY)
        {
            double xbar = Mean(DataPointsX);
            double ybar = Mean(DataPointsY);
            double sx = StandardDev(DataPointsX);
            double sy = StandardDev(DataPointsY);
            double x, y, numerator, expression, correlation;
            double covariance = 0;


            for (int i = 0; i < DataPointsX.Length; i++)
            {
                x = DataPointsX[i] - xbar;
                y = DataPointsY[i] - ybar;
                numerator = x * y;
                covariance = Sum(covariance, numerator);
            }

            expression = Quotient(covariance,DataPointsX.Length);
            correlation = (expression / (sx * sy));

            return correlation;

        }

        public double MeanDeviation(dynamic DataPoints)
        {
            double xbar = Mean(DataPoints);
            double num = 0;
            double final;

            for (int i = 0; i < DataPoints.Length; i++)
            {
                num = num + Math.Abs((DataPoints[i] - xbar));
            }

            final = Quotient(num,DataPoints.Length);

            return final;

        }

        public double Median(dynamic[] DataPoints)
        {
            var len = DataPoints.Length;
            var loc = len / 2;

            if ((len % 2) == 1)
            {
                return DataPoints[loc];
            }
            else
            {
                var nex = loc - 1;
                return ((DataPoints[loc] + DataPoints[nex]) / 2);
            }
        }


    }

}







