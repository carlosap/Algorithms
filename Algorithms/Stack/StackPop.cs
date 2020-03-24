using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void StackPop()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(200);
            stack.Push(1000);
            var pop = stack.Pop(); //gets the last element
            Debug.WriteLine($"Poped element: {pop}. It was remmoved from the collection");
            var peek = stack.Peek(); //look at the top of the element; Peek does not remove element
            Debug.WriteLine($"Element now at the top (peek): {peek}");
        }
    }
}