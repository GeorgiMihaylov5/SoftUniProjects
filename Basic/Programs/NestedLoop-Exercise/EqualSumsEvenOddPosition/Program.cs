using System;
using System.Linq;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                string currentNum = i.ToString();
                int even = 0;
                int odd = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int num = int.Parse(currentNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        even += num;
                    }
                    else
                    {
                        odd += num;
                    }
                }
                if(even==odd)
                    Console.Write(currentNum + " ");
            }
        }
    }
}
