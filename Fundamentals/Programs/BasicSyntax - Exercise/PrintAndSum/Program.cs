using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num1 = byte.Parse(Console.ReadLine());
            byte num2 = byte.Parse(Console.ReadLine());
            short sum = 0;

            for (int i = num1; i <= num2; i++)
            {
                Console.Write(i + " ");
                sum += (short)i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
