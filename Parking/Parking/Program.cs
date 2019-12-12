using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrOfTestCases = int.Parse(Console.ReadLine());
            int[] results = new int[nrOfTestCases];

            for (int i = 0; i < nrOfTestCases; i++)
            {
                int nrOfStops = int.Parse(Console.ReadLine());
                int[] storesToVisit = new int[nrOfStops];

                string input = Console.ReadLine();
                string[] values = input.Split(' ');

                for (int j = 0; j < nrOfStops; j++)
                {
                    storesToVisit[j] = int.Parse(values[j]);
                }

                int minimalDistance = (storesToVisit.Max() - storesToVisit.Min()) * 2;
                results[i] = minimalDistance;
            }
            for (int i = 0; i < nrOfTestCases; i++)
            {
                Console.WriteLine(results[i]);
            }
            Console.ReadLine();
        }
    }
}
