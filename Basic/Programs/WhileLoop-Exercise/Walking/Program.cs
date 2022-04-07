using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int allSteps = 0;
            bool isTrue = true;

            while (allSteps < 10000)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    isTrue = false;
                    continue;
                }

                int steps = int.Parse(input);

                allSteps += steps;

                if (!isTrue)
                {
                    break;
                }
            }

            if (allSteps < 10000)
            {
                Console.WriteLine($"{10000 - allSteps} more steps to reach goal.");
                return;
            }
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine($"{allSteps - 10000} steps over the goal!");
        }
    }
}
