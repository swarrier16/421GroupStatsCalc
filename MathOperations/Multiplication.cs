using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public static class Multiplication
    {
        static public int Product(int multiplier, int multiplicand)
        {
            var product = multiplier * multiplicand;

            return product;
        }
        static public double Product(double multiplier, double multiplicand)
        {
            var product = multiplier * multiplicand;

            return product;
        }
    }
}