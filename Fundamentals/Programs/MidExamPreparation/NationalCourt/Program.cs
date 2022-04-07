using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int employyerEfficiency1 = int.Parse(Console.ReadLine());
            int employyerEfficiency2 = int.Parse(Console.ReadLine());
            int employyerEfficiency3 = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            int hours = 0;
            int neededTime = 0;

            while (peopleCount > 0)
            {
                if(hours >= 3)
                {
                    hours = 0;
                    neededTime++;
                    continue;
                }

                peopleCount -= employyerEfficiency1 + employyerEfficiency2 + employyerEfficiency3;
                hours++;
                neededTime++;
            }
            Console.WriteLine($"Time needed: {neededTime}h.");
        }
    }
}
