using System;
using System.Text.RegularExpressions;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"([*@])([A-Z][a-z]{2,})\1:\s\[(?<first>\w+)\]\|\[(?<second>\w+)\]\|\[(?<third>\w+)\]\|");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);


                var counter = 0;

                foreach (var item in input)
                {
                    if (item == '|')
                    {
                        counter++;
                    }
                }

                if (input[0] == '@' || input[0] == '*' && input.Length > 30)
                {
                    counter = 10;
                }



                if (match.Success && counter == 3)
                {
                    Console.WriteLine($"{match.Groups[2].Value}: {(int)(char.Parse(match.Groups["first"].Value))} {(int)(char.Parse(match.Groups["second"].Value))} {(int)(char.Parse(match.Groups["third"].Value))}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
