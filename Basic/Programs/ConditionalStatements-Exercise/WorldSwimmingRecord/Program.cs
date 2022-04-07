using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record=double.Parse(Console.ReadLine());
            double length=double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double swim = length * time;
            length = Math.Floor(length / 15);
            length = length * 12.5;

            swim = swim + length;

            if(record<=swim)
            {
                Console.WriteLine($"No, he failed! He was {swim-record:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {swim:f2} seconds.");
            }
        }
    }
}
