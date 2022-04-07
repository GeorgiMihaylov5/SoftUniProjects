using System;

namespace MIddleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(GetMiddleChar(text));
        }
        static string GetMiddleChar(string text)
        {
            if(text.Length % 2 == 0)
            {
                return text[text.Length / 2 - 1].ToString() + text[text.Length / 2].ToString();
            }
            else
            {
                return text[text.Length / 2].ToString();
            }
        }
    }
}
