using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double bonus = 0;

            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num > 100 && num < 1000)
            {
                bonus = num * 20 / 100;
            }
            else if (num >= 1000)
            {
                bonus = num * 10 / 100;
            }

            if (num % 2 == 0)
            {
                bonus++;
            }
            else if (num % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}
