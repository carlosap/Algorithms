/* One solution is to create an array of boolean values. 
 * We can flag index 'i' whether the character i in the alphabet
 * is contained in the string
 * 
 * Assuming the input string is ACII string (not unitcode string)
*/

namespace Algorithms
{
    partial class Program
    {
        public static bool IsUnique(string str)
        {
            // immediately return false if the string exceeds the number of unique characters 
            // in the alphabet
            if (str.Length > 128) return false;

            bool[] charSet = new bool[128];
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (charSet[val])
                {
                    return false;
                }
                charSet[val] = true;
            }
            return true;
        }
    }
}