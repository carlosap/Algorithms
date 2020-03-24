/*
This method returns a stack
Copy, search. You can use different constructors of Stack to streamline your code. 
One constructor accepts an IEnumerable parameter, which is an interface that most 
collections implement. Here we use that constructor.
Clear and Count.
*/
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void SearchStack()
        {
            var words = new[] {"Joe", "Henry", "Carlos"};
            var stack = new Stack<string>(words); //Copy Stack patterm
            var IsFound = stack.Contains("Joe");
            Debug.WriteLine($"The search item was found: {IsFound}");
        }
    }
}