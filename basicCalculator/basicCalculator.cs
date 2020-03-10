using System;
using MathOperations;

namespace basicCalculator
{
    public class basicCalculator
    {

        private static dynamic _result;

        public static dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        //Multiplying Multiplication = new Multiplying();

        public static void Main()
        {
        }

        public dynamic Product(dynamic a, dynamic b)
        {
            Result = Multiplication.Product(a, b); ;
            return Result;
        }
     
    }
}

