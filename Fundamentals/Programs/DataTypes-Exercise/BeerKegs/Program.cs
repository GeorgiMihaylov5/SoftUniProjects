using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float bigestKeg = 0;
            string bigestKegName = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float currentKeg = (float)(Math.PI * Math.Pow(radius, 2) * height);
                if(currentKeg > bigestKeg)
                {
                    bigestKeg = currentKeg;
                    bigestKegName = name;
                }
            }
            Console.WriteLine(bigestKegName);
        }
    }
}
