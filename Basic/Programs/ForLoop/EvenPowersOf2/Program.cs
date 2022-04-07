using System;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (double i = 1; i <= Math.Pow(2, n); i *= 4)
            {
                Console.WriteLine(i);
            }
        }
    }
}
