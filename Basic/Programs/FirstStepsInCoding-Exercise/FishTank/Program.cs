using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int wigth = int.Parse(Console.ReadLine());
            int higth = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double capacicy = length * wigth * higth;
            double usedCapacicy = capacicy * 0.001;
            percent = percent * 0.01;
            Console.WriteLine($"{usedCapacicy*(1-percent):f5}");
        }
    }
    
}
