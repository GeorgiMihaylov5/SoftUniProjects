using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = length * width * height;
            int boxesSpace = 0;

            string input = Console.ReadLine();
            while (input != "Done" && boxesSpace <= freeSpace)
            {
                int boxes = int.Parse(input);
                boxesSpace += boxes;
                if(boxesSpace <= freeSpace)
                    input = Console.ReadLine();
            }
            if(boxesSpace>freeSpace)
            {
                Console.WriteLine($"No more free space! You need {boxesSpace-freeSpace} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{freeSpace-boxesSpace} Cubic meters left.");
            }
        }
    }
}
