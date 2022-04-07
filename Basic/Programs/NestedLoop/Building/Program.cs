using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            string roomLetter = "L";
            bool isTrue = true;

            for (int i = 0; i < floor; i++)
            {
                int reverse = floor - i;
                for (int j = 0; j < room; j++)
                {
                    Console.Write($"{roomLetter}{reverse}{j} ");
                }
                Console.WriteLine();

                if (floor % 2 == 0)
                {
                    if (isTrue)
                    {
                        roomLetter = "A";
                        isTrue = false;
                    }
                    else
                    {
                        roomLetter = "O";
                        isTrue = true;

                    }
                }
                else
                {
                    if (isTrue)
                    {
                        roomLetter = "O";
                        isTrue = false;
                    }
                    else
                    {
                        roomLetter = "A";
                        isTrue = true;

                    }
                }
                
            }
        }
    }
}
