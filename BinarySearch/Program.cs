using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = IsPrime(10);
            Debug.WriteLine($"Is Prime  Value: {results}");
        }

        /******************************************************************************
        Problem- prime numbers are natural numbers (1,2,3..) 
        divisile by exactly 2 natural numbers: itself or 1.
        Examples
        Is:
                3
               / \
              1   3

                2
               / \
              1   2

        Not
                4
              / | \
              1 2  4

        If you think about computer science, prime numbers gives you a building block mechamism 
        to find  a complete Node (by left and right node).
        *******************************************************************************/
        public static bool IsPrime(int val)
        {
            if (val < 2) return false;
            if (val == 2) return true;
            if (val % 2 == 0) return false;
            for (int k = 3; k < val; k += 2)
                if (val % k == 0) return false;

            return true;
        }


        /***********************************************************************************************************
        problem:Factorial of a number is obtained from the result of multiplying a series of descending natural numbers.
        a factorial of n items gives you the number of ways you can arrange the given items.
        If there are two coins - you can arrange them in two different ways - 
        like wise if you have 5 coins - there are 120 ways you can arrange them.

        Gambling: In any card game, if you want to calculate the probability of favorable outcomes, you have 
        to have a working knowledge of factorials.
        ************************************************************************************************************/
        public static double GetFactorial(int val)
        {
            if (val == 1)
                return 1;
            else
            {
                return val * GetFactorial(val - 1);
            }
        }

        public static void ReverseNumberString()
        {
            int num = 11, 
                temp, 
                remainder, 
                reverse = 0;
            temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            Debug.WriteLine("Given number is = {0}", temp);
            Debug.WriteLine("Its reverse is  = {0}", reverse);
            Debug.WriteLine((temp == reverse) ? "Number is a palindrome" : "Number is not a palindrome");
        }

        public static void ReverseString()
        {
            string result = "";
            string word = "rotor";
            for (int i = word.Length - 1; i >= 0; i--)
                result += word[i];

            Debug.WriteLine($"Reversed Word is: {result}");
            Debug.WriteLine((result == word) ? "Word is a palindrome" : "Word is not a palindrome");
        }

        public static void StackQueues()
        {
            Stack<string> book1 = new Stack<string>();
            Stack<string> book2 = new Stack<string>();
            book1.Push("book1-Section-1");
            book1.Push("book1-Section-2");
            book2.Push("book2-Section-1");
            book2.Push("book2-Section-2");
            Queue<Stack<string>> q = new Queue<Stack<string>>();
            q.Enqueue(book1);
            q.Enqueue(book2);
            while (q.Count > 0)
            {
                Stack<string> item = q.Dequeue();
                while (item.Count > 0)
                    Debug.WriteLine(item.Pop());
            }
        }
        //This method returns a stack
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
        //Copy, search. You can use different constructors of Stack to streamline your code. 
        //One constructor accepts an IEnumerable parameter, which is an interface that most 
        //collections implement. Here we use that constructor.
        public static void SearchStack()
        {
            var words = new string[] { "Joe", "Henry", "Carlos" };
            var stack = new Stack<string>(words); //Copy Stack patterm
            var IsFound = stack.Contains("Joe");
            Debug.WriteLine($"The search item was found: {IsFound}");
        }
        //Clear and Count.
        //You can use Clear and Count on your Stack. These methods won't raise exceptions 
        //unless your Stack reference is null. The Count property is used without parenthesis,
        // while Clear() is a parameterless method.
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

        //Pop. Here we see the Pop method on Stack, and also the Peek method. 
        //When you call Pop, the elements from the top of the Stack is returned,
        // and the element is removed from the collection.
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
        public static void StackPush()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(1000);
            stack.Push(10000); //Last-In-First-Out
            foreach (int i in stack)
                Debug.WriteLine(i);
        }
        public static int ToBinary(int num)
        {
            if (num != 0)
            {
                var bin = (num % 2) + 10 * ToBinary(num / 2);
                Debug.Write(bin);
                return 0;
            }
            else           
                return 0;

        }

        //Recursive function that returns Power Xn
        public static double Pow(double x, int num)
        {
            if (num == 0) return 1.0;
            return x * Pow(x, num - 1);
        }
        //Recursive function that returns the sum of the first 'n'
        //elements of an array (Horner's Metho 1+b*(1+b*(1+b*)))
        public static double SumArray(double[] a, int num)
        {
            if (num == 0) return 0.0;
            return SumArray(a, num - 1) + a[num - 1];
        }
        //Recursive Hanoi
        public static void Hanoi(int num, char x, char y, char z)
        {
            if (num == 1)
            {
                Debug.WriteLine($"Move Top Disk from Peg {x} to peg {z}");
            }
            else
            {
                Hanoi(num - 1, x, z, y);
                Hanoi(1, x, y, z);
                Hanoi(num - 1, y, x, z);
            }
        }
        public static void ReverseQ()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(100);
            q.Enqueue(1000);
            int[] data = new int[q.Count];
            q.CopyTo(data, 0);
            for (var x = data.Length - 1; x >= 0; x--)
            {
                Debug.WriteLine(data[x]);
            }
        }
        public static void Dequeue()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(100);
            q.Enqueue(1000);
            var item = q.Dequeue(); //removes it
            Debug.WriteLine($"Removed Item: {item}");
            var peekItem = q.Peek(); //next element withou removing it
            Debug.WriteLine($"Peek Item: {peekItem}");
            foreach (var itemNum in q)
            {
                Debug.WriteLine($"Queue Item: {itemNum}");
            }
        }
        public static void Enqueue()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1); //first in first out
            q.Enqueue(10);
            q.Enqueue(100);
            foreach (var item in q)
            {
                Debug.WriteLine(item);
            }
        }
        public static void ReverseLinkedList()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("First");
            list.AddLast("Second");
            list.AddLast("Third");
            foreach (var item in list)
                Debug.WriteLine(item);

            var temp = new LinkedList<string>();
            var startPointer = list.Last;
            while (startPointer != null)
            {
                temp.AddLast(startPointer.Value);
                startPointer = startPointer.Previous;
            }

            foreach (var item in temp)
                Debug.WriteLine(item);

        }

        public static void KthToLast()
        {
            int results = -1;
            var list1 = new LinkedList<int>();
            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);
            var p1 = list1.First; //head -> change to Last for 1st Kth
            var p2 = list1.First; //head -> change to Last for 1st Kth
            //assumption known Size. We are getting ahead by 1
            for (var x = 0; x < list1.Count; x++)
            {
                if (p1 == null)
                {
                    break;
                }
                Debug.WriteLine($"index: {x} = {p1.Value}");
                results = p1.Value;
                p1 = p1.Next; //-> change to Previous for 1st Kth
            }
            //print last value
            Debug.WriteLine(results); //output 3
        }

        public static void RemoveDuplicates()
        {
            var list = new LinkedList<int>();
            var temp = new LinkedList<int>();
            var dict = new Dictionary<int, int>();
            list.AddFirst(1);
            list.AddLast(3);
            list.AddLast(2);
            list.AddLast(3);
            foreach (var item in list)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else
                {
                    dict[item] = 1;
                    temp.AddLast(item);
                }
            }
            foreach (var item in temp)
                Debug.WriteLine($"{item}");
        }

        public static void RemoveLinkedList()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("First");
            list.AddLast("Second");
            list.AddLast("Third");
            var delete = list.Find("Second");
            if (delete != null)
            {
                list.Remove(delete);
            }
            foreach (var item in list)
            {
                Debug.WriteLine(item);
            }
        }
        public static void AddLinkedListNode()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("First");
            list.AddLast("Second");
            list.AddLast("third");
            list.AddLast("third");
            foreach (var item in list)
                Debug.WriteLine(item);
        }
        public static void DuplicateLinkList()
        {
            LinkedList<string> list = new LinkedList<string>();
            var dict = new Dictionary<string, int>();
            list.AddFirst("first");
            list.AddLast("second");
            list.AddLast("first");
            foreach (var item in list)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }
            foreach (var item in dict)
            {
                Debug.WriteLine($"Key : {item.Key} Value: {item.Value}");
            }
        }
        public static int LinearSearch()
        {
            var data = new int[] { 1, 2, 3, 4, 68, 69 };
            var key = 68;
            Array.Sort(data);
            int StepCounter = 0;
            for (var x = 0; x < data.Length; x++)
            {
                StepCounter++;
                if (data[x] == key)
                {
                    Debug.WriteLine(StepCounter);
                    return StepCounter;
                }
            }
            Debug.WriteLine(-1);
            return -1;
        }
        public static void BinarySearchIterative()
        {
            //Make sure Array is Sorted
            var data = new int[] { 1, 2, 3, 66, 68, 69 };
            var results = -1;       
            var key = 66;       
            int min = 0;
            int max = data.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == data[mid])
                {
                    results = ++mid;
                    break;
                }
                else if (key < data[mid])
                {
                    //left
                    max = mid - 1;
                }
                else
                {
                    //right
                    min = mid + 1;
                }
            } 
            Debug.WriteLine(results);
        }
        public static void SortAsc()
        {
            var data = new int[] { 34, 22, 55, 66, 1, 3 };
            for (var x = 0; x < data.Length; x++)
            {
                for (var y = 0; y < data.Length; y++)
                {
                    if (data[y] > data[x])
                    {
                        var temp = data[x];
                        data[x] = data[y];
                        data[y] = temp;
                    }
                }
            }
            for (var i = 0; i < data.Length; i++)
            {
                Debug.WriteLine(data[i]);
            }
        }

        public static void SortDesc()
        {
            var data = new int[] { 44, 23, 55, 1 };
            for (var x = 0; x < data.Length; x++)
            {
                for (var y = 0; y < data.Length; y++)
                {
                    if (data[y] < data[x])
                    {
                        var temp = data[x];
                        data[x] = data[y];
                        data[y] = temp;
                    }
                }
            }
            for (var i = 0; i < data.Length; i++)
            {
                Debug.WriteLine(data[i]);
            }
        }

        public static void Duplicates()
        {
            var data = new int[] { 1, 3, 1, 1, 1, 33, 2, 1, 33 };
            Dictionary<int, int> duplicates = new Dictionary<int, int>();
            for (var x = 0; x < data.Length; x++)
            {
                if (duplicates.ContainsKey(data[x]))
                {
                    duplicates[data[x]]++;
                }
                else
                {
                    duplicates[data[x]] = 1;
                }
            }
            foreach (var item in duplicates)
            {
                if (item.Value > 1)
                {
                    Debug.WriteLine($"Key {item.Key} Value: {item.Value}");
                }
            }
        }
        public static void Distinct()
        {
            var data = new int[] { 1, 3, 33, 333, 33, 3, 1, 55 };
            Dictionary<int, int> duplicates = new Dictionary<int, int>();
            List<int> distinct = new List<int>();
            for (var x = 0; x < data.Length; x++)
            {
                if (duplicates.ContainsKey(data[x]))
                {
                    duplicates[data[x]]++;
                }
                else
                {
                    distinct.Add(data[x]);
                    duplicates[data[x]] = 1;
                }
            }
            foreach (var item in distinct)
            {
                Debug.WriteLine($"{item}");
            }
        }
        public static void Min()
        {
            var data = new int[] { 1, 30, 9, 434, 3 };
            for (var x = 0; x < data.Length; x++)
            {
                for (var y = 0; y < data.Length; y++)
                {
                    if (data[y] < data[x])
                    {
                        var temp = data[x];
                        data[x] = data[y];
                        data[y] = temp;
                    }
                }
            }
            Debug.WriteLine($"The Min Value is: {data[data.Length - 1]}");
        }

        public static void Max()
        {
            var data = new int[] { 1, 3, 5, 63, 75, 3 };
            for (var x = 0; x < data.Length; x++)
            {
                for (var y = 0; y < data.Length; y++)
                {
                    if (data[y] > data[x])
                    {
                        var temp = data[x];
                        data[x] = data[y];
                        data[y] = temp;
                    }
                }
            }
            Debug.WriteLine($"The Max Value is: {data[data.Length - 1]}");
        }
        public static void IsSort()
        {
            var results = true;
            var data = new int[] { 1, 2, 3, 4, 5 };
            for (var x = 1; x < data.Length; x++)
            {
                if (data[x - 1] > data[x])
                {
                    results = false;
                    break;
                }
            }
            Debug.WriteLine($"Is the Array Sorted: {results}");
        }
        public static void AddTwoArrays()
        {
            var a = new int[] { 1, 2, 3 };
            var b = new int[] { 4, 5, 6 };
            var data = new int[a.Length + b.Length];
            for (var x = 0; x < data.Length; x++)
            {
                if (x < a.Length)
                {
                    data[x] = a[x];
                }
                else
                {
                    data[x] = b[x - b.Length];
                }
            }
            for (var i = 0; i < data.Length; i++)
            {
                Debug.WriteLine(data[i]);
            }
        }
        public static void PerfectShuffle()
        {

            var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var temp = new int[data.Length];
            int mid = data.Length / 2;
            int index = 0;
            //----Left side: 1=1, 3=2, 5=3---------------
            for (var x = 0; x < mid; x++)
            {
                index = 2 * x + 1;
                temp[index] = data[x];
            }
            //----Right side: 0=5, 2=6, 4=7---------------
            for (var x = mid; mid < data.Length; x++)
            {
                index = 2 * (x - mid);
                if (index <= data.Length)
                    temp[index] = data[x];
                else
                    break;
            }
            //----Print Results---------------
            for (var x = 0; x < data.Length; x++)
            {
                data[x] = temp[x];
                Debug.WriteLine(data[x]);
            }
        }
        public static void ReverseNumber()
        {
            var data = new int[] { 1, 2, 3, 4 };
            for (var x = 0; x < data.Length / 2; x++)
            {
                var temp = data[x];
                data[x] = data[data.Length - 1 - x];
                data[data.Length - 1 - x] = temp;
            }
            for (var x = 0; x < data.Length; x++)
            {
                Debug.WriteLine(data[x]);
            }
        }
        public static void Mean()
        {
            var data = new int[] { 1, 2, 3, 4, 5 };
            var total = 0;
            var mean = 0;
            for (var x = 0; x < data.Length; x++)
                total += data[x];

            mean = total / data.Length;
            Debug.WriteLine($"The Mean Value: {mean}");
        }
        public static void Tally()
        {
            var data = new string[] { "test", "cars", "test" };
            var dict = new Dictionary<string, int>();
            for (var x = 0; x < data.Length; x++)
            {
                if (dict.ContainsKey(data[x]))
                {
                    dict[data[x]]++;
                }
                else
                {
                    dict[data[x]] = 1;
                }
            }
            foreach (var item in dict)
            {
                Debug.WriteLine($"word: {item.Key} count: {item.Value}");
            }
        }
        public static void InnerProduct()
        {
            var a = new int[] { 1, 2, 3 };
            var b = new int[] { 1, 10, 100 };
            var sum = 0;
            for (var x = 0; x < a.Length; x++)
                sum += a[x] * b[x];

            Debug.WriteLine($"total Inneer Product: {sum}");
        }

        public static void OuterProduct()
        {
            var a = new int[] { 1, 2, 3, 4 };
            var b = new int[] { 10, 3, 4, 4 };
            var data = new int[a.Length, b.Length];
            for (var x = 0; x < a.Length; x++)
            {
                for (var y = 0; y < b.Length; y++)
                {
                    data[x, y] = a[x] * b[y];
                    Debug.WriteLine(data[x, y]);
                }
            }
        }
    }
}
