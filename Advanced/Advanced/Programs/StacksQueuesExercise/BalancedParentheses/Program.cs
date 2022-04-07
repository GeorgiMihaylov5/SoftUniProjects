using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            bool isTrue = true;

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                if (letter == '(' || letter == '[' || letter == '{')
                {
                    stack.Push(i);
                }
                if (stack.Count > 0)
                {
                    if (letter == ')')
                    {
                        int index = stack.Pop();
                        if (input[index] != '(')
                        {
                            isTrue = false;
                            break;
                        }
                    }
                    else if (letter == ']')
                    {
                        int index = stack.Pop();
                        if (input[index] != '[')
                        {
                            isTrue = false;
                            break;
                        }
                    }
                    else if (letter == '}')
                    {
                        int index = stack.Pop();
                        if (input[index] != '{')
                        {
                            isTrue = false;
                            break;
                        }
                    }
                    else if (letter == ' ')
                    {
                        int index = stack.Pop();
                        if (input[index] != ' ')
                        {
                            isTrue = false;
                            break;
                        }
                    }
                }
                else
                {
                    isTrue = false;
                    break;
                }
            }
            if(isTrue && stack.Count == 0)
                Console.WriteLine("YES");
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
