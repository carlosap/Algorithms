using System;
namespace Algorithms
{
    partial class Program
    {
        public static string RemoveDuplicateChar(string key)
        {
            string results = string.Empty;
            foreach (char val in key)
            {
                if (results.IndexOf(val) == -1)
                {
                    results += val;
                }
            }
            Console.WriteLine(results);
            return results;
        }
    }
}