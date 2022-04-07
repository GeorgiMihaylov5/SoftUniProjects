using System;
using System.Text.RegularExpressions;

namespace Exercise2
{
    class Program
    {
        //([:*])\1([A-Z][a-z]{2,})\1{2}
        //([*@])([A-Z][a-z]{2,})\1:\s((\[)(\w+)(\])(\|)){3}
        //([*@])([A-Z][a-z]{2,})\1:(\s((\[(\w)\])(\|)){3})
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"([*@])([A-Z][a-z]{2,})\1:\s(\[)(\w+)(\])(\|)(\[)(\w+)(\])(\|)(\[)(\w+)(\])(\|)");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = regex.Matches(input);
                var counter = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == '|')
                    {
                        counter++;
                    }
                }

                if (matches.Count <= 0 || counter > 3)
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"{match.Groups[2]}: {(int)(char.Parse(match.Groups[4].ToString()))} {(int)(char.Parse(match.Groups[8].ToString()))} {(int)(char.Parse(match.Groups[12].ToString()))}");
                    }
                }
            }
        }
    }
}
