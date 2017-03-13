using System;
namespace Algorithms
{
    partial class Program
    {
        static void Main(string[] args)
        {
            CopyFolder(@"c:\code", @"G:\MadMobile\code", "node_modules,bin,.git");
            Console.ReadLine();

        }
    }
}
