using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double allPrice = 0;

            if(type=="Premiere")
            {
                allPrice = rows * cols * 12;
            }
            else if (type == "Normal")
            {
                allPrice = rows * cols * 7.50;
            }
            else if (type == "Discount")
            {
                allPrice = rows * cols * 5;
            }
            Console.WriteLine($"{allPrice:f2} leva");
        }
    }
}
