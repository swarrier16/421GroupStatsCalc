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

            double m = Calculator.Quotient(total, (values.Length-1));

            return m;
        }

        public double Variance(dynamic DataPoints)
        {
            double[] values = DataPoints;
            double mean = Mean(values);
            double[] x = new double[values.Length-1];

            for (int i = 0; i < values.Length; i++)
            {
                x[i] = Calculator.SquareExpo(Calculator.Difference(values[i], mean));
            }

            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum = Calculator.Sum(sum, x[i]);
            }

            double final = Calculator.Quotient(sum, (values.Length - 2));
            return final;
        }

        public double StandardDev(dynamic DataPoints)
        {
            double[] values = DataPoints;
            double variance = Variance(values);
            double result = Calculator.Root(variance);
            return result;
        }

        public double zScore(dynamic point, dynamic mean, dynamic sd)
        {
            double dividend = Calculator.Difference(point, mean);
            double result = Calculator.Quotient(dividend, sd);
            return result;
        }
    }

}