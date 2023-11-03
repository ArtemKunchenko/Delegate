using System;
using static Delegate.Program;


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
            operation();
            Console.ReadKey();
        }
         static void operation ()
        {
            int choice = 0;
            char s=' ';
            MathOperation mathOperation=null;
            Console.Write("Input first operand: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Input second operand: ");
            double b = double.Parse(Console.ReadLine());
            do
            {
                Console.Clear();
                Console.WriteLine("Choose operation:");
                Console.WriteLine("Addition - 1");
                Console.WriteLine("Subtraction - 2");
                Console.WriteLine("Multiplication - 3");
                Console.WriteLine("Devivion - 4");
                choice=  int.Parse(Console.ReadLine());
                if (choice >= 1 && choice <= 4) break;
                Console.WriteLine("Ivalid value");

            } while (choice<1||choice>4);
            switch (choice)
            {
                case 1:
                    mathOperation = Add;
                    s = '+';
                    break;
                case 2:
                    mathOperation = Subtract;
                    s = '-';
                    break;
                case 3:
                    mathOperation = Multiply;
                    s = '*';
                    break;
                case 4:
                    mathOperation = Divide;
                    s = '/';
                    break;
                default:
                    
                    break;
            }
            Console.Clear();
            double result = mathOperation(a, b);
            Console.WriteLine($"{a}{s}{b}={result}");
        }

    }
}
