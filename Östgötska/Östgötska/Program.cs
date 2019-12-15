using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Östgötska
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double count = 0.0;

            string[] subStrings = input.Split(' ');
            int wordCount = subStrings.Length;

            for (int i = 0; i < wordCount; i++)
            {
                if (subStrings[i].Contains("ae"))
                {
                    count++;
                }
            }
            string output;
            if ((count / (double)wordCount) >= 0.4)
            {
                output = "dae ae ju traeligt va";
            }
            else
            {
                output = "haer talar vi rikssvenska";
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
