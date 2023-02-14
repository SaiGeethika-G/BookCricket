using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCricket
{
    public class Class1
    {
        public void playGame()
        {
            int totalRuns = 0;
            string reqString = "Please press enter to score!";
            int ballsForOver = 6;
            bool outOfGame=false;
            for (int i = 0; i < ballsForOver; i++)
            {
                Console.Write(reqString);
                string? userEntry = Console.ReadLine();
                if (userEntry == "")
                {
                    int currentPageScore = runsScored();
                    if (currentPageScore == 0)
                    {
                        Console.WriteLine("Out!!!");
                        outOfGame= true;
                        break;
                    }
                    else if (currentPageScore > 6)
                    {
                        totalRuns += 0;
                    }
                    else
                    {
                        totalRuns += currentPageScore;
                    }
                }
            }
            if (!outOfGame)
            {
                Console.WriteLine("Game Over! The total score is {0}", totalRuns);
            } 
        }
        int runsScored()
        {
            int totalPages = 500;
            Random randObj = new Random();
            int page = randObj.Next(0, totalPages);
            Console.WriteLine("Current page: {0}\n", page);
            int currentPageScore = page % 10;
            return currentPageScore;
        }
    }
}
