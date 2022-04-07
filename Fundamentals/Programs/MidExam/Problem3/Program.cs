using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messenger = new List<string>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split(' ').ToArray();

                if (commands[0] == "Chat")
                {
                    messenger.Add(commands[1]);
                }
                else if(commands[0] == "Delete")
                {
                    if (messenger.Contains(commands[1]))
                    {
                        messenger.Remove(commands[1]);
                    }
                }
                else if (commands[0] == "Edit")
                {
                    if (messenger.Contains(commands[1]))
                    {
                        int index = messenger.IndexOf(commands[1]);
                        messenger.Remove(commands[1]);
                        messenger.Insert(index, commands[2]);
                    }
                }
                else if (commands[0] == "Pin")
                {
                    if (messenger.Contains(commands[1]))
                    {
                        messenger.Remove(commands[1]);
                        messenger.Add(commands[1]);
                    }
                }
                else if (commands[0] == "Spam")
                {
                    for (int i = 1; i < commands.Length; i++)
                    {
                        messenger.Add(commands[i]);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var item in messenger)
            {
                Console.WriteLine(item);
            }
        }
    }
}
