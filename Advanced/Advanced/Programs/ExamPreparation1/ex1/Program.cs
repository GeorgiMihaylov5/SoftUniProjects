using System;
using System.Collections.Generic;
using System.Linq;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            Queue<char> vowels = new Queue<char>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray());
            Stack<char> consonants = new Stack<char>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray());

            string[] words = { "pear" , "flour", "pork", "olive"};
            string[] check = { "", "", "", ""};

            while (consonants.Count > 0)
            {
                var currentVowel = vowels.Dequeue();
                var currentConsonant = consonants.Pop();

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Contains(currentVowel) && !check[i].Contains(currentVowel))
                    {
                        check[i] += currentVowel;
                    }
                    if (words[i].Contains(currentConsonant) && !check[i].Contains(currentConsonant))
                    {
                        check[i] += currentConsonant;
                    }
                }
                vowels.Enqueue(currentVowel);
            }

            var indexes = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == check[i].Length)
                {
                    indexes.Add(i);
                }
            }

            Console.WriteLine($"Words found: {indexes.Count}");
            foreach (var item in indexes)
            {
                Console.WriteLine(words[item]);
            }
        }
    }
}
