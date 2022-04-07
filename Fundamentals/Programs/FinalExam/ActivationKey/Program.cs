using System;
using System.Linq;
using System.Text;

namespace ActivationKey
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();

            var input = Console.ReadLine();
            while (input != "Generate")
            {
                var commands = input.Split(">>>");

                if (commands[0] == "Contains")
                {
                    if (key.Contains(commands[1]))
                    {
                        Console.WriteLine($"{key} contains {commands[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (commands[0] == "Flip")
                {
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);

                    if (commands[1] == "Upper")
                    {
                        var upper = key.Substring(startIndex, endIndex - startIndex);
                        //key = key.Substring(0, startIndex) + upper.ToUpper() + key.Substring(endIndex);
                        key = key.Replace(upper, upper.ToUpper());
                        Console.WriteLine(key);
                    }
                    else if (commands[1] == "Lower")
                    {
                        var lower = key.Substring(startIndex, endIndex - startIndex);
                        key = key.Substring(0, startIndex) + lower.ToLower() + key.Substring(endIndex);
                        Console.WriteLine(key);
                    }
                }
                else if (commands[0] == "Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    key = key.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(key);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
/*
Gosheemnogoqk
Flip>>>Upper>>>5>>>10
 */