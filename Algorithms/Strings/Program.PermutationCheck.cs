/* Given Two strings write a function that returns a boolean if one of the
 * strings is permutation of the other
 * 
 * Assuming the input string is ACII string (not unitcode string)
 * Clarify if the permutation comparison is case sensitive (it should) 
 * - God, dog = false
 * - god, dog = true
 * 
*/

namespace Algorithms
{
    partial class Program
    {
        public static bool PermutationCheck(string str, string str2)
        {
            //1- Check the length of the two strings
            if(str.Length != str2.Length)
            {
                return false;
            }

            int[] letters = new int[128];
            char[] strArray = str.ToCharArray();

            //2- Count Number of each char in str
            foreach (char c in strArray)
            {
                letters[c]++;
            }

            //3- Compare the two arrays.
            for(int i = 0; i < str2.Length; i++)
            {
                int c = str2[i];
                letters[c]--;
                if(letters[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}