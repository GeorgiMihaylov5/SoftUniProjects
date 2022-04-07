using System;

namespace Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            double breakTime = int.Parse(Console.ReadLine());
            double lunch = breakTime * 1.0 / 8;
            double rest = breakTime * 1.0 / 4;


            //double allSum = Math.Ceiling(episodeTime + lunch + rest);
            double allSum = (episodeTime + lunch + rest);

            if (allSum > breakTime)
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(allSum - breakTime)} more minutes.");
            }
            else
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(breakTime - allSum)} minutes free time.");
            }

            //if (allSum > breakTime)
            //{
            //    Console.WriteLine($"You don't have enough time to watch {name}, you need {allSum - breakTime} more minutes.");
            //}
            //else
            //{
            //    Console.WriteLine($"You have enough time to watch {name} and left with {breakTime - allSum} minutes free time.");
            //}
        }
    }
}
