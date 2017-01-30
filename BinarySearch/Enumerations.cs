using System;
namespace BinarySearch
{
        public class Enumerations
        {
            public static void PlayGame()
            {
                Options yours, mine;
                Results winner = Results.You;
                Random r = new Random();
                int rInt = r.Next(0, 3);
                Console.Write("Enter a prefix (r/s/p):");
                var response = Console.ReadLine();
                Console.WriteLine($"your input: {response}");
                switch (response.ToLower())
                {
                    case "r":
                        yours = Options.Rock;
                        break;
                    case "s":
                        yours = Options.Scissors;
                        break;
                    case "p":
                        yours = Options.Paper;
                        break;
                    default:
                        yours = (Options)rInt;
                        break;

                }
                Console.WriteLine($"You Selected {yours.ToString()}");
                rInt = r.Next(0, 3);
                mine = (Options)rInt;
                Console.WriteLine($"Computer chose: {mine.ToString()}");
                if (yours == mine) winner = Results.Tie;
                if (yours == Options.Paper && mine == Options.Scissors
                    || yours == Options.Scissors && mine == Options.Rock
                    || yours == Options.Rock && mine == Options.Paper) winner = Results.Computer;

                Console.WriteLine($"And The winner is: {winner.ToString()}");

            }
        }
        enum Options
        {
            Rock,
            Scissors,
            Paper

        }
        enum Results
        {
            You,
            Computer,
            Tie
        }
}
