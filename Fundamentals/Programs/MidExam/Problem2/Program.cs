using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> genre = Console.ReadLine().Split(" | ").ToList();

            string input = Console.ReadLine();

            while (input != "Stop!")
            {
                string[] commands = input.Split(' ').ToArray();

                if (commands[0] == "Join")
                {
                    if (!genre.Contains(commands[1]))
                    {
                        genre.Add(commands[1]);
                    }
                }
                else if (commands[0] == "Drop")
                {
                    if (genre.Contains(commands[1]))
                    {
                        genre.Remove(commands[1]);
                    }
                }
                else if (commands[0] == "Replace")
                {
                    if (genre.Contains(commands[1]) && !genre.Contains(commands[2]))
                    {
                        int index = genre.IndexOf(commands[1]);
                        genre.Remove(commands[1]);
                        genre.Insert(index, commands[2]);
                    }

                }
                // Romance | Fiction | Horror | Mystery

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", genre));
        }
    }
}
