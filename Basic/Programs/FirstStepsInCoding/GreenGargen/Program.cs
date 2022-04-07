using System;

namespace GreenGargen
{
    class Program
    {
        static void Main(string[] args)
        {
            double kv = double.Parse(Console.ReadLine());
            double percent = kv*7.61 * 18 / 100;
            Console.WriteLine($"The final price is: {kv*7.61-percent} lv.");
            Console.WriteLine($"The discount is: {percent} lv.");
        }
    }
}
