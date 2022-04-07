using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shop = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();


            while (commands[0] != "Go" && commands[1] != "Shopping!")
            {
                string command = commands[0];

                if(command == "Urgent")
                {
                    string item = commands[1];

                    if(!shop.Contains(item))
                        shop.Insert(0, item);
                }
                else if (command == "Unnecessary")
                {
                    string item = commands[1];

                    if (shop.Contains(item))
                        shop.Remove(item);
                }
                else if (command == "Correct")
                {
                    string oldItem = commands[1];
                    string newItem = commands[2];

                    if(shop.Contains(oldItem))
                    {
                        int index = shop.IndexOf(oldItem);
                        shop.RemoveAt(index);
                        shop.Insert(index, newItem);
                    }
                }
                else if (command == "Rearrange")
                {
                    string item = commands[1];

                    if(shop.Contains(item))
                    {
                        shop.Remove(item);
                        shop.Add(item);
                    }
                }

                commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            Console.WriteLine(string.Join(", ", shop));
        }
    }
}
