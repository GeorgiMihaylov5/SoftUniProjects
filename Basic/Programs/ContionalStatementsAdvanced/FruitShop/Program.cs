using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit=Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            bool workingDays = day == "Monday" || day == "Tuesday" ||
                day == "Wednesday" || day == "Thursday" || day == "Friday";
            bool weekend = day == "Saturday" || day == "Sunday";

            switch (fruit)
            {
                case "banana":
                    if(workingDays)
                        Console.WriteLine($"{2.5*quantity:f2}");
                    else if(weekend)
                        Console.WriteLine($"{2.7 *quantity:f2}");
                    else
                        Console.WriteLine("error");
                    break;
                case "apple":
                    if (workingDays)
                        Console.WriteLine($"{1.2 * quantity:f2}");
                    else if (weekend)
                        Console.WriteLine($"{1.25 * quantity:f2}");
                    else
                        Console.WriteLine("error");
                    break;
                case "orange":
                    if (workingDays)
                        Console.WriteLine($"{0.85 * quantity:f2}");
                    else if (weekend)
                        Console.WriteLine($"{0.9 * quantity:f2}");
                    else
                        Console.WriteLine("error");
                    break;
                case "grapefruit":
                    if (workingDays)
                        Console.WriteLine($"{1.45 * quantity:f2}");
                    else if (weekend)
                        Console.WriteLine($"{1.6 * quantity:f2}");
                    else
                        Console.WriteLine("error");
                    break;
                case "kiwi":
                    if (workingDays)
                        Console.WriteLine($"{2.7 * quantity:f2}");
                    else if (weekend)
                        Console.WriteLine($"{3 * quantity:f2}");
                    else
                        Console.WriteLine("error");
                    break;
                case "pineapple":
                    if (workingDays)
                        Console.WriteLine($"{5.5 * quantity:f2}");
                    else if (weekend)
                        Console.WriteLine($"{5.6 * quantity:f2}");
                    else
                        Console.WriteLine("error");
                    break;
                case "grapes":
                    if (workingDays)
                        Console.WriteLine($"{3.85 * quantity:f2}");
                    else if (weekend)
                        Console.WriteLine($"{4.2 * quantity:f2}");
                    else
                        Console.WriteLine("error");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}
