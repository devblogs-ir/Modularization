using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    internal class VotingSystem
    {
        public void Main()
        {
            int yesCounter = 4;
            int noCounter = 2;
            int maybeCounter = 3;
            int total = yesCounter + noCounter + maybeCounter;

            var yesPercent = Math.Round((yesCounter * 100.0) / total, 2);
            var noPercent = Math.Round((noCounter * 100.0) / total, 2);
            var maybePercent = Math.Round((maybeCounter * 100.0) / total, 2);
            var excess = Math.Round(100 - yesPercent - noPercent - maybePercent, 2);
            Console.WriteLine($"Excees:{excess}");

            if (yesCounter > noCounter)
            {
                if (maybeCounter > yesCounter)
                {
                    Console.WriteLine("Maybe Won");
                    maybePercent += excess;
                }
                else if (maybeCounter < yesCounter)
                {
                    Console.WriteLine("Yes Won");
                    yesPercent += excess;
                }
                else
                {
                    Console.WriteLine("Draw");
                    noPercent += excess;
                }
            }
            else if (noCounter > yesCounter)
            {
                if (maybeCounter > noCounter)
                {
                    Console.WriteLine("Maybe Won");
                    maybePercent += excess;
                }
                else if (maybeCounter < noCounter)
                {
                    Console.WriteLine("No Won");
                    noPercent += excess;
                }
                else
                {
                    Console.WriteLine("Draw");
                    yesPercent += excess;
                }
            }
            else if (maybeCounter > yesCounter || maybeCounter > noCounter)
            {
                Console.WriteLine("Maybe WOn");
                maybePercent += excess;
            }
            else
            {
                Console.WriteLine("Draw");
            }

            Console.WriteLine($"Yes Counter:{yesCounter},Percentage:{Math.Round(yesPercent, 2)}%");
            Console.WriteLine($"No Counter:{noCounter},Percentage:{Math.Round(noPercent, 2)}%");
            Console.WriteLine($"No Counter:{maybeCounter},Percentage:{Math.Round(maybePercent, 2)}%");
        }
    }
}
