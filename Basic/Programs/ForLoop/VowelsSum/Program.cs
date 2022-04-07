using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sum = 0;

            foreach(var letter in text)
            {
                if (letter == 'a')
                    sum += 1;
                else if (letter == 'e')
                    sum += 2;
                else if (letter == 'i')
                    sum += 3;
                else if (letter == 'o')
                    sum += 4;
                else if (letter == 'u')
                    sum += 5;
            }
            Console.WriteLine(sum);
        }
    }
}
