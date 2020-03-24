/* **************************************************************************
TimeConvert(num) take the num parameter being passed and return the number of 
hours and minutes the parameter converts to 
(ie. if num = 63 then the output should be 1:3). 
Separate the number of hours and minutes with a colon. 
 *****************************************************************************/
namespace Algorithms
{
    partial class Program
    {
        public static string TimeConvert(int val)
        {
            var hour = val > 60 ? val / 60 : 0;
            var min = val % 60;
            return $"{hour}:{min}";

        }
    }
}
