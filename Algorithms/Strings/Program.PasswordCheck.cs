//Write password checker method - 
//must contain min 6 char and max 12 char,
//No two similar chars consecutively, 
//1 lower case, 1 upper case, 1 special char, no white space 
using System.Linq;

namespace Algorithms
{
    partial class Program
    {
        public static bool PasswordCheck(string key)
        {
            //min 5 and 12
            if (key.Length < 6 || key.Length > 12)
            {
                return false;
            }
            //no white space
            if (key.Contains(" "))
                return false;

            if (!key.Any(char.IsUpper))
                return false;

            if (!key.Any(char.IsLower))
                return false;

            //not two similar char consecutively
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] == key[i + 1])
                    return false;
            }

            //at least 1 special char
            string specialCharacter = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharacterArray = specialCharacter.ToCharArray();
            foreach (char c in specialCharacterArray)
            {
                if (key.Contains(c))
                    return true;
            }
            return true;

        }
    }
}