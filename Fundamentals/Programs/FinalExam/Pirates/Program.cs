using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var cities = new Dictionary<string, List<int>>();

            while (input != "Sail")
            {
                var newCity = input.Split("||");

                if (!cities.ContainsKey(newCity[0]))
                {
                    cities.Add(newCity[0],new List<int>());
                    cities[newCity[0]].Add(int.Parse(newCity[1]));
                    cities[newCity[0]].Add(int.Parse(newCity[2]));
                }
                else
                {
                    cities[newCity[0]][0] += int.Parse(newCity[1]);
                    cities[newCity[0]][1] += int.Parse(newCity[2]);

                }

                input = Console.ReadLine();
            }


            input = Console.ReadLine();
            while (input != "End")
            {
                var commands = input.Split("=>");
                var town = commands[1];

                if (commands[0] == "Plunder")
                {
                    cities[town][0] -= int.Parse(commands[2]);
                    cities[town][1] -= int.Parse(commands[3]);
                    Console.WriteLine($"{town} plundered! {int.Parse(commands[3])} gold stolen, {int.Parse(commands[2])} citizens killed.");

                    if (cities[town][0] <= 0 || cities[town][1] <= 0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (commands[0] == "Prosper")
                {
                    int gold = int.Parse(commands[2]);

                    if (gold <= 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        input = Console.ReadLine();
                        continue;
                    }
                    cities[town][1] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                }

                input = Console.ReadLine();
            }

            if (cities.Keys.Count >= 1)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var item in cities.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
