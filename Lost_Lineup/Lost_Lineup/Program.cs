using System;

namespace Lost_Lineup
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrOfPplInLine = int.Parse(Console.ReadLine());
            int[] linePos = new int[nrOfPplInLine - 1];

            string input = Console.ReadLine();
            string[] values = input.Split(' ');

            int[] resultPos = new int[nrOfPplInLine - 1];

            for (int i = 0; i < nrOfPplInLine - 1; i++)
            {
                linePos[i] = int.Parse(values[i]);
            }

            for (int i = 0; i < nrOfPplInLine - 1; i++)
            {
                int index = Array.IndexOf(linePos, i);
                index += 2;                
                resultPos[i] = index;
            }

            Console.Write(1 + " ");
            foreach (int item in resultPos)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
