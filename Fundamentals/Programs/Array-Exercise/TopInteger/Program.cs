using System;
using System.Linq;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = string.Empty;
            bool isTrue = true;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] <= nums[j])
                    {
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue)
                {
                    result += nums[i] + " ";
                }
                isTrue = true;
            }
            Console.WriteLine(result);
        }
    }
}
