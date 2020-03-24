/* **************************************************************************
AlphabetSoup(str) take the str string parameter being passed and return the 
string with the letters in alphabetical order (ie. hello becomes ehllo). 
Assume numbers and punctuation symbols will not be included in the string. 
 *****************************************************************************/

using System.Linq;

namespace Algorithms
{
    partial class Program
    {
        public static string AlphabetSoup(string val)
        {
            return new string(val.OrderBy(c => c).ToArray());
        }
    }
}
