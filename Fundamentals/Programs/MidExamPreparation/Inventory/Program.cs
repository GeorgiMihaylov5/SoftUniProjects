using System;
using System.Linq;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();

            string text = Console.ReadLine();

            while (text != "Craft!")
            {
                string[] commands = text.Split(" - ").ToArray();

                if (commands[0] == "Collect")
                {
                    if(!input.Contains(commands[1]))
                    {
                        input.Add(commands[1]);
                    }
                }
                else if(commands[0] == "Drop")
                {
                    if (input.Contains(commands[1]))
                    {
                        input.Remove(commands[1]);
                    }
                }
                else if (commands[0] == "Combine Items")
                {
                    string[] items = commands[1].Split(':').ToArray();

                    if(input.Contains(items[0]))
                    {
                        int index = input.IndexOf(items[0]);
                        input.Insert(index + 1, items[1]);
                    }
                }
                else if (commands[0] == "Renew")
                {
                    if(input.Contains(commands[1]))
                    {
                        input.Remove(commands[1]);
                        input.Add(commands[1]);
                    }
                }
                text = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
