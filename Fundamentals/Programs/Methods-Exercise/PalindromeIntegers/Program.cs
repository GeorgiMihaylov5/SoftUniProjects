using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                string reversed = Reverse(input);

                if (input == reversed)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }
        static string Reverse(string text)
        {
            string reversed = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }
            return reversed;
        }
    }
}
