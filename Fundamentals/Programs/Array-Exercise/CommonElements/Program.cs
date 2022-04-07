using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < arr2.Length; i++)
            {
                if(arr1.Contains(arr2[i]))
                {
                    Console.Write(arr2[i] + " ");
                }
            }
        }
    }
}
