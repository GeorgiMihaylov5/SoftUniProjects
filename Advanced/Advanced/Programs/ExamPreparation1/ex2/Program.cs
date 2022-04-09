using System;
using System.Linq;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] whitePawn = new int[2];
            int[] blackPawn = new int[2];
            string[] row = { "a", "b", "c", "d", "e", "f", "g", "h" };
            int[] column = { 8 , 7, 6, 5, 4, 3, 2, 1 };


            for (int i = 0; i < 8; i++)
            {
                var input = Console.ReadLine();

                for (int j = 0; j < 8; j++)
                {
                    if (input[j] == 'w')
                    {
                        whitePawn = new int[2] { i, j };
                    }
                    else if (input[j] == 'b')
                    {
                        blackPawn = new int[2] { i, j };
                    }
                }
            }

            while (whitePawn[0] != 0 && blackPawn[0] != 7)
            {
                if (blackPawn[0] == whitePawn[0] - 1)
                {
                    if (blackPawn[1] == whitePawn[1] + 1 || blackPawn[1] == whitePawn[1] - 1)
                    {
                        Console.WriteLine($"Game over! White capture on {row[blackPawn[1]] + column[blackPawn[0]] }.");
                        return;
                    }
                }
                whitePawn[0] --;

                if (blackPawn[0] + 1 == whitePawn[0])
                {
                    if (blackPawn[1] == whitePawn[1] + 1 || blackPawn[1] == whitePawn[1] - 1)
                    {
                        Console.WriteLine($"Game over! Black capture on { row[whitePawn[1]] + column[whitePawn[0]] }.");
                        return;
                    }
                }
                blackPawn[0]++;
            }

            if (whitePawn[0] == 0)
            {
                Console.WriteLine($"Game over! White pawn is promoted to a queen at {string.Join("", row[whitePawn[1]] + column[whitePawn[0]])}.");
            }
            else if (blackPawn[0] == 7)
            {
                Console.WriteLine($"Game over! Black pawn is promoted to a queen at {string.Join("", row[blackPawn[1]] + column[blackPawn[0]])}.");
            }
        }
    }
}
