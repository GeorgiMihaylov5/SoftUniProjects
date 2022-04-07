using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Divide(Factorial(num1), Factorial(num2)));
        }
        static double Factorial(double num)
        {
            double result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        static string Divide(double num1, double num2)
        {
            return $"{(double)num1 / (double)num2:F2}";
        }
    }
}
