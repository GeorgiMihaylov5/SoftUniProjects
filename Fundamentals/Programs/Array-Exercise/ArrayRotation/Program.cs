using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int index = n;

            for (int i = 0; i < n; i++)
            {
                int save = nums[0];
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j + 1];
                }
                nums[nums.Length - 1] = save;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
