using System;
using basicCalculator;
using Microsoft.CSharp;

namespace StatisticsCalculator
{
    public class DescriptiveStats : basicCalculators
    {
        
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


    }

}







