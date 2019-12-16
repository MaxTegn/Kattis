using System;

namespace Job_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrOfValues = int.Parse(Console.ReadLine());
            if (nrOfValues == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                string input = Console.ReadLine();
                string[] values = input.Split(' ');

                int sum = 0;

                for (int i = 0; i < values.Length; i++)
                {
                    int value = int.Parse(values[i]);
                    if (value < 0)
                    {
                        sum = sum + value;
                    }
                }
                Console.WriteLine(sum / -1);
            }
            Console.ReadLine();
        }
    }
}
