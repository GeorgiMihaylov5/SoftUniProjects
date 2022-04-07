using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            while (sum<num)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
