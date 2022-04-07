using System;
using System.Text;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();

            var input = Console.ReadLine();
            while (input != "Sign up")
            {
                var commands = input.Split();

                if (commands[0] == "Case")
                {
                    if (commands[1] == "upper")
                    {
                        username = username.ToUpper();
                    }
                    else if (commands[1] == "lower")
                    {
                        username = username.ToLower();
                    }
                    Console.WriteLine(username);
                }
                else if (commands[0] == "Reverse")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex < 0 || endIndex >= username.Length)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    string reversed = username.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(Reverse(reversed));
                }
                else if (commands[0] == "Cut")
                {
                    var subStr = commands[1];
                    if (username.Contains(subStr))
                    {
                        var index = username.IndexOf(subStr);
                        username = username.Remove(index, subStr.Length);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {subStr}.");
                    }
                }
                else if (commands[0] == "Replace")
                {
                    var letter = commands[1];

                    username = username.Replace(letter, "*");
                    Console.WriteLine(username);
                }
                else if (commands[0] == "Check")
                {
                    var letter = commands[1];
                    if (username.Contains(letter))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {letter}.");
                    }
                }

                input = Console.ReadLine();
            }
        }

        private static string Reverse(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }
    }
}
