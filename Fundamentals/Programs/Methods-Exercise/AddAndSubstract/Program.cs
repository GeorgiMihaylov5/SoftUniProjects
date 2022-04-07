using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Substract(num1, num2, num3));
        }
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Substract(int num1, int num2, int num3)
        {
            return Sum(num1, num2) - num3;
        }
    }
}
