/*
 * Using the C# language, have the function SimpleSymbols(str) take the 
 * str parameter being passed and determine if it is an acceptable sequence 
 * by either returning the string true or false. The str parameter will 
 * be composed of + and = symbols with several letters between 
 * them (ie. ++d+===+c++==a) and for the string to be true each letter 
 * must be surrounded by a + symbol. So the string to the left would be false. 
 * The string will not be empty and will have at least one letter. 
 */
namespace Algorithms
{
    partial class Program
    {
        public static string Symbols(string str)
        {
            if (str.Length <= 0)
                return "false";

            for (var i = 0; i < str.Length; i++)
            {
                var charValue = (int) str[i];
                if (i == 0)
                {
                    if (charValue >= 65 && charValue <= 90 || charValue >= 97 && charValue <= 122)
                    {
                        return "false";
                    }
                }

                if (i > 0)
                {
                    if (charValue >= 65 && charValue <= 90 || charValue >= 97 && charValue <= 122)
                    {
                        if (i + 1 < str.Length)
                        {
                            if (str[i - 1] != '+' || str[i + 1] != '+')
                                return "false";
                        }
                        else
                        {
                            return "false";
                        }

                    }
                }
            }
            return "true";
        }
    }
}