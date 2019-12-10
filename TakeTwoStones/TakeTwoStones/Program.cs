using System;

namespace TakeTwoStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string winner = "";

            if (IsOdd(n))
            {
                winner = "Alice";
            }
            else
            {
                winner = "Bob";
            }
            Console.WriteLine(winner);         
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
