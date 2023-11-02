using System;


namespace Delegate
{
    internal class Program
    {
        public delegate double MathOperation(double a, double b);
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b)=> (b == 0) ? 0 : a / b;
        static void Main(string[] args)
        {
        }

    }
}
