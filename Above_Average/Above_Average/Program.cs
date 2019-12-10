using System;

namespace Above_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrOfTestCases = int.Parse(Console.ReadLine());

            decimal[] result = new decimal[nrOfTestCases];

            for (int i = 0; i < nrOfTestCases; i++)
            {
                string[] inputArr = Console.ReadLine().Split(' ');
                int classSize = int.Parse(inputArr[0]);
                double[] finalGrades = new double[classSize];
                double gradesSum = 0;
                for (int j = 0; j < classSize; j++)
                {
                    finalGrades[j] = double.Parse(inputArr[j + 1]);
                    gradesSum += finalGrades[j];
                }
                double average = (gradesSum / classSize);
                decimal aboveAverage = 0;

                for (int x = 0; x < classSize; x++)
                {
                    if (finalGrades[x] > average)
                    {
                        aboveAverage++;
                    }
                }

                result[i] = Math.Round((aboveAverage / classSize) * 100, 3);
            }

            foreach (double item in result)
            {
                Console.WriteLine(item.ToString("0.000") + "%");
            }
        }
    }
}
