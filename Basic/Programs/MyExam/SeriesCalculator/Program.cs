using System;

namespace SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int seasonsCount = int.Parse(Console.ReadLine());
            int episodesCount = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double allTime = 0.0;

            time += time * 20 / 100;

            allTime = seasonsCount * episodesCount * time + 10 * seasonsCount;
            Console.WriteLine($"Total time needed to watch the {name} series is {allTime} minutes.");
        }
    }
}
