/*
Using the C# language, have the function LongestWord(sen) 
take the sen parameter being passed and return the largest 
word in the string. If there are two or more words that are the same 
length, return the first word from the string with that length. 
Ignore punctuation and assume sen will not be empty.  

 */

namespace Algorithms
{
    partial class Program
    {
        public static string LongestWord(string str)
        {
            //filter non char
            int charValue = -1;
            string newStr = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                charValue = (int) str[i];
                if (charValue == 32 ||                         //->Space
                        charValue >= 48 && charValue <= 57 ||  //->numbers
                        charValue >= 65 && charValue <= 90 ||  //->Uppers
                        charValue >= 97 && charValue <= 122)   //->Lower
                {
                    newStr += str[i];
                }
            }

            var words = newStr.Split(' ');
            var tempWords = newStr.Split(' ');

            //Sort by str size
            for (var x = 0; x < words.Length; x++)
            {
                for (var y = 0; y < words.Length; y++)
                {

                    if (words[y].Length > words[x].Length)
                    {
                        var temp = words[x];
                        words[x] = words[y];
                        words[y] = temp;
                    }
                }
            }

            //get back to Original str and filter max size
            int maxValue = words[words.Length - 1].Length;
            for (var i = 0; i < tempWords.Length; i++)
            {
                if (tempWords[i].Length.Equals(maxValue))
                    return tempWords[i];
            }

            return words[words.Length - 1];
        }
    }
}