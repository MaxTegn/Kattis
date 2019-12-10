using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_A_Dice
{
    public class DiceProbability
    {
        int dice1, dice2;
        int[] frequencyArray;

        // Anrop av de metoder som krävs för programmet
        public void GetMostProbableSums()
        {
            ReadInput();
            CalculateFrequency();
            PrintResult();
        }

        // Läser input från användare, tar emot två int-värden som delas upp med ett mellanslag.
        public void ReadInput()
        {
            string input = Console.ReadLine();
            string[] values = input.Split(' ');
            dice1 = int.Parse(values[0]);
            dice2 = int.Parse(values[1]);
        }

        // Räknar ut frekvensen av olika möjligheter för att se vilka värden som är mest sannolika
        public void CalculateFrequency()
        {
            int highestOutcome = (dice1 + dice2); // Den högsta möjliga summan tärningar kan få.

            frequencyArray = new int[highestOutcome]; // Skapar en array som kommer hålla reda på frekvensen av alla möjligheter

            for (int i = 1; i <= dice1; i++)
            {
                for (int j = 1; j <= dice2; j++)
                {
                    frequencyArray[(i + j) - 1] += 1;
                }
            }
        }

        //Skriver ut resultat i konsolen.
        public void PrintResult()
        {
            int maxValue = frequencyArray.Max();

            for (int i = 0; i < frequencyArray.Length; i++)
            {
                if (frequencyArray[i] >= maxValue)
                {
                    Console.WriteLine(i + 1);
                }
            }
        }
    }
}
