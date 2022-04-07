using System;

namespace EvenOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;

            for (int i = 1; i <= n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if(i%2==0)
                {
                    even += input;
                }
                else
                {
                    odd += input;
                }
            }

            if(even==odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(even-odd)}");
            }
        }
    }
}
