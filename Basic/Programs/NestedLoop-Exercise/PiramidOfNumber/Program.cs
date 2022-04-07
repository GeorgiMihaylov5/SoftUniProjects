using System;

namespace PiramidOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int print = 1;
            bool isTrue = false;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if(print>n)
                    {
                        isTrue = true;
                        break;
                    }
                    Console.Write(print + " ");
                    print++;
                }
                if (isTrue)
                    break;
                Console.WriteLine();
            }
        }
    }
}
