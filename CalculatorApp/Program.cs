using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator app");
            Console.WriteLine("Enter first number:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /):");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double result = op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => a / b,
                _ => double.NaN
            };

            Console.WriteLine($"Result: {result}");
        }
    }
}
