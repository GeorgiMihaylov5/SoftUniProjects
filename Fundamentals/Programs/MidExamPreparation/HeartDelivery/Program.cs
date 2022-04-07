using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split('@').Select(int.Parse).ToArray();

            string[] commands = Console.ReadLine().Split().ToArray();

            int houseIndex = 0;
            while (commands[0] != "Love!")
            {
                if(commands[0] == "Jump")
                {
                    int jump = int.Parse(commands[1]);
                    houseIndex = Jumping(houseIndex, jump, neighborhood.Length);

                    if(neighborhood[houseIndex] <= 0)
                    {
                        Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
                    }
                    else
                    {
                        neighborhood[houseIndex] -= 2;

                        if(neighborhood[houseIndex] <= 0)
                        {
                            Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                        }
                    }
                }
                //houseIndex = Jumping(houseIndex, jump, neighborhood.Length);

                commands = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine($"Cupid's last position was {houseIndex}.");
            int succes = 0;
            int failed = 0;

            for (int i = 0; i < neighborhood.Length; i++)
            {
                if (neighborhood[i] > 0)
                {
                    failed++;
                }
                else
                {
                    succes++;
                }
            }

            if (succes == neighborhood.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failed} places.");
            }
        }
        static int Jumping(int houseIndex, int jump, int houseCount)
        { 
            for (int i = 0; i < jump; i++)
            {
                if(houseIndex >= houseCount - 1)
                {
                    houseIndex = 0;
                }
                else
                    houseIndex++;
            }
            return houseIndex;
        }
    }
}
