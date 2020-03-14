using System;
using MathOperations;
using Microsoft.CSharp;

namespace Subtraction
{
    public interface ISubtract
    {
        dynamic Difference(dynamic a, dynamic b);
    }
    public class Subtracting : ISubtract
    {
        private static dynamic _result;

        public static dynamic Result
        {
            get => _result;
            set => _result = value;
        }
        public static void Main()
        {
        }
        public dynamic Difference(dynamic a, dynamic b)
        {
            Result = MathOperations.Subtraction.Difference(a, b); ;
            return Result;
        }

    }
}