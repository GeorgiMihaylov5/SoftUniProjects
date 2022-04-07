using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //int biggestOrder = int.MinValue;
            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());

            while (true)
            {
                if (queue.Count > 0)
                {
                    if (foodQuantity - queue.Peek() >= 0)
                    {
                        foodQuantity -= queue.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }



            //while (queue.Count > 0 && foodQuantity - queue.Peek() >= 0)
            //{
            //    int elm = queue.Dequeue();
            //    if (biggestOrder < elm)
            //    {
            //        biggestOrder = elm;
            //    }
            //    foodQuantity -= elm;
            //}
            //Console.WriteLine(biggestOrder);
            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
