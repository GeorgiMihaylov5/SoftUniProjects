using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int legth = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int cakePieces = legth * width;
            int eatenPieces = 0;

            while (cakePieces >= eatenPieces)
            {
                string input = Console.ReadLine();

                if (input=="STOP")
                {
                    break;
                }

                int currentPieces = int.Parse(input);
                eatenPieces += currentPieces;
            }
            if (cakePieces < eatenPieces)
                Console.WriteLine($"No more cake left! You need {eatenPieces - cakePieces} pieces more.");
            else
                Console.WriteLine($"{cakePieces-eatenPieces} pieces are left.");
        }
    }
}
