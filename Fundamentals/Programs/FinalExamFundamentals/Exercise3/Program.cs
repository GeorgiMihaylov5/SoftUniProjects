using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var facebook = new Dictionary<string, List<int>>();

            var input = Console.ReadLine();
            while (input != "Log out")
            {
                var commands = input.Split(": ");
                var username = commands[1];
                var command = commands[0];

                if (command == "New follower")
                {
                    if (!facebook.ContainsKey(username))
                    {
                        facebook.Add(username, new List<int>(2));
                        facebook[username].Add(0);
                        facebook[username].Add(0);
                    }
                }
                else if (command == "Like")
                {
                    if (!facebook.ContainsKey(username))
                    {
                        facebook.Add(username, new List<int>(2));
                        facebook[username].Add(0);
                        facebook[username].Add(0);
                        var likes = int.Parse(commands[2].ToString());
                        facebook[username][0] = likes;
                    }
                    else
                    {
                        var likes = int.Parse(commands[2].ToString());

                        facebook[username][0] += likes;
                    }
                }
                else if (command == "Comment")
                {
                    if (!facebook.ContainsKey(username))
                    {
                        facebook.Add(username, new List<int>());
                        facebook[username].Add(0);
                        facebook[username].Add(0);
                        facebook[username][1] = 1;
                    }
                    else
                    {
                        facebook[username][1] += 1;
                    }
                }
                else if (command == "Blocked")
                {
                    if (!facebook.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        facebook.Remove(username);
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"{facebook.Count} followers");

            foreach (var item in facebook.OrderByDescending(x => x.Value[0] + x.Value[1]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value[0] + item.Value[1]}");
            }
        }
    }
}
