using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(VowelsCount(text));
        }

        static int VowelsCount(string text)
        {
            int count = 0;
            text = text.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' ||
                    text[i] == 'u' || text[i] == 'y' ||
                    text[i] == 'o' || text[i]== 'i')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
