using System;
using MathOperations;
using Microsoft.CSharp;

namespace SquareRoot
{
    public interface IRoot
    {
        dynamic Root(dynamic a);
    }
    public class SquareRooting : IRoot
    {

        private static dynamic _result;

        public static dynamic Result
        {
            get => _result;
            set => _result = value;
        }
       
        public dynamic Root(dynamic a)
        {
            Result = MathOperations.Roots.Root(a);
            return Result;
        }
    }
}