using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());

            Console.WriteLine(CharactersBetween(symbol1,symbol2));
        }

        static string CharactersBetween(char symbol1, char symbol2)
        {
            string characters = string.Empty;

            
            if(symbol1 < symbol2)
            {
                char currentSymbol = (char)(symbol1 + 1);

                while (currentSymbol != symbol2)
                {
                    characters += currentSymbol + " ";
                    currentSymbol++;
                }
            }
            else
            {
                char currentSymbol = (char)(symbol2 + 1);

                while (currentSymbol != symbol1)
                {
                    characters += currentSymbol + " ";
                    currentSymbol++;
                }
            }
           

            return characters;
        }
    }
}
