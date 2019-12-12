using System;
using System.Linq;

namespace Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] contestantsPoints = new int[5];

            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();
                string[] values = input.Split(' ');

                for (int j = 0; j < 4; j++)
                {
                    contestantsPoints[i] += int.Parse(values[j]);
                }
            }

            int winnerPoints = contestantsPoints.Max();
            int winner = Array.IndexOf(contestantsPoints, winnerPoints) + 1;
            Console.WriteLine(winner + " " + winnerPoints);
            Console.ReadLine();
        }
    }
}
