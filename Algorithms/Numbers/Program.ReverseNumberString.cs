using System.Diagnostics;

namespace Algorithms
{
    partial class Program
    {
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
    }
}