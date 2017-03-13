using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
        public static void ReverseString()
        {
            string result = "";
            string word = "rotor";
            for (int i = word.Length - 1; i >= 0; i--)
                result += word[i];

            Debug.WriteLine($"Reversed Word is: {result}");
            Debug.WriteLine((result == word) ? "Word is a palindrome" : "Word is not a palindrome");
        }
    }
}