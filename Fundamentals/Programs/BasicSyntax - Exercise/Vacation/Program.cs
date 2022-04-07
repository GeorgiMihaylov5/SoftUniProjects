using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            decimal price = 0m;

            if(type == "Students")
            {
                if(day == "Friday")
                {
                    price += 8.45m;
                }
                else if(day == "Saturday")
                {
                    price += 9.8m;
                }
                else if(day == "Sunday")
                {
                    price += 10.46m;
                }
                price *= studentCount;

                if (studentCount >= 30)
                    price -= price * 15 / 100;
            }
            else if(type == "Business")
            {
                if (day == "Friday")
                {
                    price += 10.90m;
                }
                else if (day == "Saturday")
                {
                    price += 15.60m;
                }
                else if (day == "Sunday")
                {
                    price += 16;
                }
                if (studentCount >= 100)
                    studentCount -= 10;
                price *= studentCount;
            }
            else if(type == "Regular")
            {
                if (day == "Friday")
                {
                    price += 15;
                }
                else if (day == "Saturday")
                {
                    price += 20;
                }
                else if (day == "Sunday")
                {
                    price += 22.50m;
                }
                price *= studentCount;
                if (studentCount >= 10 && studentCount <= 20)
                    price -= price * 5 / 100;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
