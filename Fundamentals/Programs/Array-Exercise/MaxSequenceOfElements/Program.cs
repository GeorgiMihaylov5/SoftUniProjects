using System;
using System.Linq;

namespace MaxSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int longest = 1;
            string result = string.Empty;
            

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int currentNum = nums[i];
                //bool isTrue = true;

                if (currentNum == nums[i + 1])
                {
                    counter++;
                    //if(isTrue)
                        //longest++;
                    //isTrue = true;
                }
                else
                {
                    counter = 1;
                    //isTrue = false;
                }
                if(counter > longest)
                {
                    longest = counter;
                    result = string.Empty;
                    //result = new string(char.Parse(nums[i].ToString()), longest);
                    for (int j = 0; j < longest; j++)
                    {
                        result += nums[i] + " ";
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
