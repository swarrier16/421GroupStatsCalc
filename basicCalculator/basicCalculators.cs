using MathOperations;
using Multiplication;
using SquareRoot;
using Square;
using Subtraction;
using Addition;
using Division;

namespace basicCalculator
{
    public class basicCalculators : IMultiply, IRoot, IAdd, IDivide, ISquare, ISubtract
    {

        private static dynamic _result;

        public static dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        Multiplying Multiplication = new Multiplying();
        SquareRooting SquareRoot = new SquareRooting();
        Subtracting Subtraction = new Subtracting();
        Squaring Square = new Squaring();
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
        public dynamic Difference(dynamic a, dynamic b)
        {
            Result = Subtraction.Difference(a, b);
            return Result;
        }
        public dynamic SquareExpo(dynamic a)
        {
            Result = Square.SquareExpo(a);
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

