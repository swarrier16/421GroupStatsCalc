﻿using System;
using MathOperations;
using Microsoft.CSharp;

namespace Addition
{
    public interface IDivide
    {
        dynamic Quotient(dynamic a, dynamic b);
    }
    public class Dividing : IDivide
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
        public dynamic Quotient(dynamic a, dynamic b)
        {
            Result = MathOperations.Division.Quotient(a, b);
            return Result;
        }

    }
}