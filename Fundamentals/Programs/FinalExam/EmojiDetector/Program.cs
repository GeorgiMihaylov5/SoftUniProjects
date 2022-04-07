using System;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"([:*])\1([A-Z][a-z]{2,})\1{2}");
            var input = Console.ReadLine();
            long threshold = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    threshold *= int.Parse(input[i].ToString());
                }
            }
            Console.WriteLine($"Cool threshold: {threshold}");

            MatchCollection matches = regex.Matches(input);
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            foreach (Match match in matches)
            {
                long coolnest = 0;
                string emoji = match.Groups[2].Value;

                for (int i = 0; i < emoji.Length; i++)
                {
                    if (true)
                    {
                        coolnest += (int)emoji[i];
                    }
                }

                if (coolnest >= threshold)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
