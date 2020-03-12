using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public static class Square
    {
        static public int SquareMethod(int squareBase)
        {
            var product = squareBase * squareBase;

            return product;
        }
        static public double SquareMethod(double squareBase)
        {
            var product = squareBase * squareBase;

            return product;
        }
    }
}