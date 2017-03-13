using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void StackPush()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(1000);
            stack.Push(10000); //Last-In-First-Out
            foreach (int i in stack)
                Debug.WriteLine(i);
        }
    }
}