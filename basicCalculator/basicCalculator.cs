using System;
using Addition;
using Division;
using MathOperations;
using Multiplication;
using SquareRoot;


namespace basicCalculator
{
    public class basicCalculator: IMultiply, IRoot, IAdd, IDivide
    {

        private static dynamic _result;

        public static dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        Multiplying Multiplication = new Multiplying();
        SquareRooting SquareRoot = new SquareRooting();

        Adding Addition = new Adding();
        Dividing Division = new Dividing();

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

        public dynamic Sum(dynamic a, dynamic b)
        {
            Result = Addition.Sum(a, b);
            return Result;
        }

        public dynamic Quotient(dynamic a, dynamic b)
        {
            Result = Division.Quotient(a, b);
            return Result;
        }
    }
}