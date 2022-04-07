//using System;
//using System.Linq;

//namespace KamioFactory
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            int leftIndex = int.MaxValue;
//            int bestSequenceSum = 1;
//            int index = 0;
//            int bestSequenceIndex = 1;


//            while (true)
//            {
//                bool isTrue = false;
//                int currentSum = 1;
//                string input = Console.ReadLine();

//                if(input == "Clone them!")
//                {
//                    break;
//                }
//                int[] nums = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


//                for (int i = 0; i < nums.Length - 1; i++)
//                {
//                    if(nums[i] == 1 && nums[i + 1] == 1)
//                    {
//                        currentSum++;
//                    }
//                    else
//                    {


//                        //0!0!0!!!!!0!1
//                        //1!0!1!1!0
//                        //0!1!1!0!0
//                        //0!0!0!!!!!0!1
//                        //Clone them!
//                    }
//                }
//                index++;

//                string text = new string('1', currentSum);
//                string strArr = string.Join("", nums);
//                int currentIndex = strArr.IndexOf(text);

//                if (currentIndex < leftIndex)
//                {
//                    bestSequenceSum = currentSum;
//                    bestSequenceIndex = index;
//                    leftIndex = currentIndex;
//                    arr = nums;
//                }
//                else if(currentIndex == leftIndex)
//                {
//                    if (arr.Sum() > nums.Sum())
//                    {
//                        bestSequenceSum = 0;
//                        for (int i = 0; i < arr.Length; i++)
//                        {
//                            if (arr[i] == 1)
//                            {
//                                bestSequenceSum++;
//                            }
//                        }
//                    }
//                    else
//                    {
//                        bestSequenceIndex = index;
//                        leftIndex = currentIndex;
//                        arr = nums;
//                        bestSequenceSum = 0;
//                        for (int i = 0; i < arr.Length; i++)
//                        {
//                            if (arr[i] == 1)
//                            {
//                                bestSequenceSum++;
//                            }
//                        }
//                    }
//                }
//            }
//            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
//            Console.WriteLine(string.Join(" ", arr));
//        }
//    }
//}


using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] DNA = new int[arrayLenght];
            int lenght = 0;
            int index = 0;
            int sum = 0;
            int currentRow = 0;
            int row = 0;

            while (input != "Clone them!")
            {
                int[] currentDNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                currentRow++;

                int currentSum = 0;
                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentSum++;
                    }
                }

                int currentLenght = 0;
                int currentIndex = 0;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {

                        currentLenght++;
                        if (currentLenght == 1)
                        {
                            currentIndex = i;
                        }

                        if (currentLenght > lenght || currentLenght == lenght && (currentIndex < index || currentSum > sum))
                        {
                            lenght = currentLenght;
                            index = currentIndex;
                            row = currentRow;
                            DNA = currentDNA;
                            sum = currentSum;

                        }

                    }
                    else
                    {
                        currentIndex = 0;
                        currentLenght = 0;
                    }

                }

                input = Console.ReadLine();
            }

            if (row == 0)
            {
                row = 1;
            }

            Console.WriteLine($"Best DNA sample {row} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", DNA));
        }
        //5
//00!001
//10!101
//011!00
//000!!!0!1
//Clone them!
    }
}
