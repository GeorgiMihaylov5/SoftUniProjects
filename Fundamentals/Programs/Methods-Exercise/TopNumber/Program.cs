using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopNum(n);
        }
        static void TopNum(int n)
        {
            int num = 10;

            while (num < n)
            {
                if (Sum(num) % 8 == 0 && OddNum(num))
                {
                    Console.WriteLine(num);
                }
                num++;
            }
        }
        static int Sum(int num)
        {
            string str = num.ToString();
            int result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                result += int.Parse(str[i].ToString());
            }
            return result;
        }
        static bool OddNum(int num)
        {
            string str = num.ToString();

            for (int i = 0; i < str.Length; i++)
            {
                int n = int.Parse(str[i].ToString());
                if (n % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
