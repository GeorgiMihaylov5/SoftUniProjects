using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = input[0];

                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Add")
                {
                    //string song = string.Empty;
                    //for (int i = 1; i < input.Length; i++)
                    //{
                    //    song += $"{input[i]} ";
                    //}
                    input = input.Skip(1).ToArray();
                    string song = string.Join(" ", input);
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                        continue;
                    }
                    queue.Enqueue(song);
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
