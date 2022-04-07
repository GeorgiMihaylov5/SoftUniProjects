using System;

namespace Krisi6ta
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = k; i <= 8; i++)
            {
                for (int j = 9; j >= l; j--)
                {
                    for (int g = m; g <= 8; g++)
                    {
                        for (int f = 9; f >= n; f--)
                        {
                            if(counter == 6)
                            {
                                return;
                            }
                            if(i % 2 == 0 && g % 2 == 0 &&j % 2 != 0 && f % 2 != 0)
                            {
                                string num1 = i + j.ToString();
                                string num2 = g + f.ToString();

                                if(num1 == num2)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine($"{i}{j} - {g}{f}");
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
