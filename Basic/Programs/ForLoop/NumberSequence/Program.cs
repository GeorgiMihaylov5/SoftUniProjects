using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = 0;
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if(i==0)
                {
                    min = input;
                    max = input;
                }

                if (input < min)
                    min = input;
                else if (input > max)
                    max = input;
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
