using System;

namespace HalfSumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (i == 0)
                    max = input;

                if (input > max)
                {
                    max = input;
                }
                sum += input;
            }
            int finalSum = sum - max;
            if (max==finalSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max-finalSum)}");
            }
        }
    }
}
