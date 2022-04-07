using System;

namespace EvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;
            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += input;

                    if (input < evenMin)
                        evenMin = input;
                    if (input > evenMax)
                        evenMax = input;
                }
                else
                {
                    oddSum += input;

                    if (input < oddMin)
                        oddMin = input;
                    if (input > oddMax)
                        oddMax = input;
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if(oddMin==int.MaxValue)
                Console.WriteLine("OddMin=No,");
            else
                Console.WriteLine($"OddMin={oddMin:f2},");
            if(oddMax==int.MinValue)
                Console.WriteLine("OddMax=No,");
            else
                Console.WriteLine($"OddMax={oddMax:f2},");
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if(evenMin==int.MaxValue)
                Console.WriteLine("EvenMin=No,");
            else
                Console.WriteLine($"EvenMin={evenMin:f2},");
            if(evenMax==int.MinValue)
                Console.WriteLine("EvenMax=No");
            else
                Console.WriteLine($"EvenMax={evenMax:f2}");
        }
    }
}
