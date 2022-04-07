using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double a = Math.Ceiling((double)count / capacity);
            Console.WriteLine(a);
        }
    }
}
