using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays =int.Parse(Console.ReadLine());
            int weekendsInHomeTown = int.Parse(Console.ReadLine());
            double playedTime = 0.0;

            playedTime = (48 - weekendsInHomeTown) * 3.0 / 4.0;
            playedTime += weekendsInHomeTown;
            playedTime += holidays * 2.0 / 3.0;

            if (year == "leap")
                playedTime += playedTime * 15 / 100;
            Console.WriteLine(Math.Floor(playedTime));

        }
    }
}
