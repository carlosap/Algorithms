using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void ReverseStack()
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> temp = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Debug.WriteLine("--------Original List---------");
            foreach (var item in stack)
                Debug.WriteLine(item);

            while (stack.Count != 0)
                temp.Push(stack.Pop());

            Debug.WriteLine("--------Reverse List---------");
            foreach (var item in temp)
                Debug.WriteLine(item);
        }
    }
}