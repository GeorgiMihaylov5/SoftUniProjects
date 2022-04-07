using System;

namespace UsdToBg
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bg = usd * 1.79549;
            Console.WriteLine(bg);
        }
    }
}
