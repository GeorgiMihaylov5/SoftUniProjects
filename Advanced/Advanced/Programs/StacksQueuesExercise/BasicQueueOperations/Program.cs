using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int pushNumCount = input[0];
            int popNumCount = input[1];
            int searchedNum = input[2];

            Queue<int> queue = new Queue<int>(nums.Take(pushNumCount));

            for (int i = 0; i < popNumCount; i++)
            {
                queue.Dequeue();
            }

            int smallestNum = int.MaxValue;

            while (queue.Count > 0)
            {
                int currentNum = queue.Dequeue();
                if (currentNum == searchedNum)
                {
                    Console.WriteLine("true");
                    return;
                }
                else if (smallestNum > currentNum)
                {
                    smallestNum = currentNum;
                }
            }
            if (smallestNum == int.MaxValue)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(smallestNum);
            }
        }
    }
}
