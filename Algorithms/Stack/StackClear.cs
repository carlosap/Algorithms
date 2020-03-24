/*
You can use Clear and Count on your Stack. These methods won't raise exceptions 
unless your Stack reference is null. The Count property is used without parenthesis,
while Clear() is a parameterless method.
*/

using System.Collections.Generic;
using System.Diagnostics;
namespace Algorithms
{
    partial class Program
    {
        public static void StackClear()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(200);
            stack.Push(1000);
            Debug.WriteLine($"The stack size is: {stack.Count}");
            foreach (var item in stack)
                Debug.WriteLine(item);

            Debug.WriteLine("clearing stack");
            stack.Clear();
            Debug.WriteLine($"The stack size is: {stack.Count}");
        }
    }
}