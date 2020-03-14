using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public static class Square
    {
        static public int SquareMethod(int squareBase)
        {
            var squareAns = squareBase * squareBase;

            return squareAns;
        }
        static public double SquareMethod(double squareBase)
        {
            var product = squareBase * squareBase;

            return product;
        }
    }
}