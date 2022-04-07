using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> quene = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                quene.Enqueue(arr);
            }

            int index = 0;

            while (true)
            {
                int petrol = 0;
                bool isTrue = true;

                foreach (var item in quene)
                {
                    petrol += item[0];

                    if (petrol - item[1] < 0)
                    {
                        isTrue = false;
                        index++;
                        quene.Enqueue(quene.Dequeue());
                        break;
                    }
                    petrol -= item[1];
                }
                if (isTrue)
                {
                    Console.WriteLine(index);
                    break;
                }
            }
        }
    }
}
