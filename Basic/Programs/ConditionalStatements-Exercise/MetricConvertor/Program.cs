using System;

namespace MetricConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            switch (input)
            {
                case "mm":
                    {
                        if (output == "cm")
                        {
                            num = num / 10;
                        }
                        else if (output == "m")
                        {
                            num = num / 1000;
                        }
                    }
                    break;
                case "cm":
                    {
                        if (output == "mm")
                        {
                            num = num * 10;
                        }
                        else if (output == "m")
                        {
                            num = num / 100;
                        }
                    }
                    break;
                case "m":
                    {
                        if (output == "mm")
                        {
                            num = num * 1000;
                        }
                        else if (output == "cm")
                        {
                            num = num * 100;
                        }
                    }
                    break;
            }
            Console.WriteLine($"{num:f3}");
        }
    }
}
