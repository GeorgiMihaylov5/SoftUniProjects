using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(box);
            var rackCount = 1;
            var currentRackCapacity = 0;

            while (stack.Count > 0)
            {
                if (stack.Peek() + currentRackCapacity > rackCapacity)
                {
                    currentRackCapacity = stack.Pop();
                    rackCount++;
                }
                else
                {
                    currentRackCapacity += stack.Pop();
                }
            }
            Console.WriteLine(rackCount);
        }
    }
}
