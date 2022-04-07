using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side * side:f3}");
            }
            else if(figure=="rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side1 * side2:f3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{radius * radius * Math.PI:f3}");
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double higth = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side * higth/2:f3}");
            }
        }
    }
}
