using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_B_AnagramCount
{
    public class CalculatePossibilities
    {
        // Alfabetets längd (Små och stora bokstäver)
        int maxChars = 52;

        // Funktion som hjälper till att få fram fakultet
        private BigInteger Factorial(BigInteger n)
        {
            BigInteger fact = 1;
            for (BigInteger i = 2; i <= n; i++)
                fact = fact * i;

            return fact;
        }

        // Returnerar antalet möjliga anagram av str
        private BigInteger CountDistinctPermutations(String str)
        {
            BigInteger length = str.Length;
            BigInteger[] frequency = new BigInteger[maxChars];

            // Hittar frekvensen av alfabetets bokstäver i str och lagrar dem i en array
            for (BigInteger i = 0; i < length; i++)
            {
                char checkChar = str[(int)i];
                if (checkChar >= 'a') // Om det är små bokstäver 
                    frequency[str[(int)i] - 'a']++;
                else if (checkChar >= 'A') // Om det är stora bokstäver
                    frequency[str[(int)i] + 26 - 'A']++;
            }
            BigInteger fact = 1;
            for (BigInteger i = 0; i < maxChars; i++)
                fact = fact * Factorial(frequency[(int)i]);

            return Factorial(length) / fact;
        }

        // Gör uträkningar med hjälp av övriga metoder bereoende på input
        public void RunCalculations()
        {
            List<string> outputRes = new List<string>(); // Lista för att lagra output
            string line;

            while ((line = Console.ReadLine()) != null)
            {
                string res = CountDistinctPermutations(line).ToString();
                outputRes.Add(res);
            }
            foreach (string item in outputRes)
                Console.WriteLine(item); // Skriver ut resultatet som ligger lagrat i listan
        }
    }
}
