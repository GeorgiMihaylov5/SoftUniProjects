using System;

namespace FavouriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestMovie = string.Empty;
            int bestPoints = 0;

            for (int i = 0; i < 7; i++)
            {
                int points = 0;
                string name = Console.ReadLine();

                if (name == "STOP")
                {
                    Console.WriteLine($"The best movie for you is {bestMovie} with {bestPoints} ASCII sum.");
                    return;
                }

                for (int j = 0; j < name.Length; j++)
                {
                    string a = name[j].ToString();
                    if (name[j].ToString() == a.ToLower() && char.IsLetter(name[j]))
                    {
                        points += (char)name[j] - 2 * name.Length;
                    }
                    else if (name[j].ToString() == a.ToUpper() && char.IsLetter(name[j]))
                    {
                        points += (char)name[j] - name.Length;
                    }
                    else
                    {
                        points += (char)name[j];
                    }
                }

                if(bestPoints < points)
                {
                    bestMovie = name;
                    bestPoints = points;
                }
            }
            Console.WriteLine("The limit is reached.");
            Console.WriteLine($"The best movie for you is {bestMovie} with {bestPoints} ASCII sum.");
        }
    }
}
