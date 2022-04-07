using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            Stack<string> undoStack = new Stack<string>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "1")
                {
                    for (int j = 0; j < input[1].Length; j++)
                    {
                        stack.Push(input[1][j].ToString());
                    }
                    undoStack.Push($"Add {input[1]}");
                }
                else if (command == "2")
                {
                    int count = int.Parse(input[1]);
                    string removed = string.Empty;

                    for (int j = 0; j < count; j++)
                    {
                        removed += stack.Pop();
                    }
                    undoStack.Push($"Remove {removed}");
                }
                else if (command == "3")
                {
                    Stack<string> tempStack = new Stack<string>(stack.ToArray());
                    int index = int.Parse(input[1]);
                    for (int j = 0; j < index - 1; j++)
                    {
                        tempStack.Pop();
                    }
                    Console.WriteLine(tempStack.Pop());
                }
                else if (command == "4")
                {
                    string[] oldCmd = undoStack.Pop().Split().ToArray();

                    if (oldCmd[0] == "Add")
                    {
                        for (int j = 0; j < oldCmd[1].Length; j++)
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        for (int j = oldCmd[1].Length - 1; j >= 0; j--)
                        {
                            stack.Push(oldCmd[1][j].ToString());
                        }
                    }
                }
            }
        }
    }
}
