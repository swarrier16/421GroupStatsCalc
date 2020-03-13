using System;
using MathOperations;
using Multiplication;
using SquareRoot;

namespace basicCalculator
{
    public class basicCalculators : IMultiply, IRoot
    {

        private static dynamic _result;

        public static dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        Multiplying Multiplication = new Multiplying();
        SquareRooting SquareRoot = new SquareRooting();

        public dynamic Product(dynamic a, dynamic b)
        {
            Result = Multiplication.Product(a, b); ;
            return Result;
        }

        public dynamic Root(dynamic a)
        {
            Result = Roots.Root(a);
            return Result;
        }

    }
}

