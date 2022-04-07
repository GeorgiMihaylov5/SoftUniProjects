using System;
using System.Linq;
using System.Collections.Generic;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < input.Count; i++)
            {
                string[] round = input[i].Split(' ').ToArray();

                if(round[0] == "potion")
                {
                    int heal = int.Parse(round[1]);
                    if (health + heal > 100)
                    {
                        heal = 100 - health;
                        health = 100;
                    }
                    else
                    {
                        health += heal;
                    }
                    Console.WriteLine($"You healed for {heal} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (round[0] == "chest")
                {
                    int founded = int.Parse(round[1]);
                    bitcoins += founded;
                    Console.WriteLine($"You found {founded} bitcoins.");
                }
                else
                {
                    int damage = int.Parse(round[1]);
                    health -= damage;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {round[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {round[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
