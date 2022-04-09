using System;
using System.Collections.Generic;
using System.Linq;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));

            Dictionary<string, int> bakery = new Dictionary<string, int>();

            while (water.Count > 0 && flour.Count > 0)
            {
                double currentWater = water.Dequeue();
                double currentFlour = flour.Pop();

                double sum = currentWater + currentFlour;
                double ratio = (currentWater * 100) / sum;

                if (ratio == 50)
                {
                    if (!bakery.ContainsKey("Croissant"))
                    {
                        bakery.Add("Croissant", 1);
                    }
                    else
                    {
                        bakery["Croissant"]++;
                    }
                }
                else if (ratio == 40)
                {
                    if (!bakery.ContainsKey("Muffin"))
                    {
                        bakery.Add("Muffin", 1);
                    }
                    else
                    {
                        bakery["Muffin"]++;
                    }
                }
                else if (ratio == 30)
                {
                    if (!bakery.ContainsKey("Baguette"))
                    {
                        bakery.Add("Baguette", 1);
                    }
                    else
                    {
                        bakery["Baguette"]++;
                    }
                }
                else if (ratio == 20)
                {
                    if (!bakery.ContainsKey("Bagel"))
                    {
                        bakery.Add("Bagel", 1);
                    }
                    else
                    {
                        bakery["Bagel"]++;
                    }
                }
                else
                {
                    if (!bakery.ContainsKey("Croissant"))
                    {
                        bakery.Add("Croissant", 1);
                    }
                    else
                    {
                        bakery["Croissant"]++;
                    }
                    flour.Push(currentFlour - currentWater);
                }
            }
            foreach (var item in bakery.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            if (water.Count == 0)
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ", water)}");
            }
            if (flour.Count == 0)
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            }
        }
    }
}
