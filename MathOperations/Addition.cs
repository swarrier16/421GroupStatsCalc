using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public static class Addition
    {
        static public int Sum(int augend, int addend)
        {
            var sum = augend + addend;

            return sum;
        }
        static public double Sum(double augend, double addend)
        {
            var sum = augend + addend;

            return sum;
        }
    }
}