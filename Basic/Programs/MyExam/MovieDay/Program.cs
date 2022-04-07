using System;

namespace MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int movieTime = int.Parse(Console.ReadLine());
            int scenesCount = int.Parse(Console.ReadLine());
            int scenesTime = int.Parse(Console.ReadLine());

            double prepair = movieTime * 15 / 100;
            double allTime = scenesCount * scenesTime + prepair;

            if(allTime > movieTime)
                Console.WriteLine($"Time is up! To complete the movie you need {allTime - movieTime:f0} minutes.");
            else
                Console.WriteLine($"You managed to finish the movie on time! You have {movieTime - allTime:f0} minutes left!");
        }
    }
}
