using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double result = 0;

            for (int i = 0; i < n; i++)
            {
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                double total = ((double)days * capsuleCount) * priceCapsule;
                result += total;
                Console.WriteLine($"The price for the coffee is: ${total:f2}");
            }
            Console.WriteLine($"Total: ${result:f2}");
        }
    }
}
