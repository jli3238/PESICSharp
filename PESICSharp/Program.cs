using System;
using System.Linq;

namespace PESICSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomizeAString rAS = new RandomizeAString();
            while (true)
            {
                Console.WriteLine("Please enter a string: ");
                string inputString = Console.ReadLine();
                string outputStringFromRandomizeBySystemRandomFYShuffle = rAS.RandomizeBySystemRandomFYShuffle(inputString);
                Console.WriteLine("Output randomized string by SystemRandomFYShuffle call is: " + outputStringFromRandomizeBySystemRandomFYShuffle);
                string outputStringFromRandomizeBySystemRandomSort = rAS.RandomizeBySystemRandomSort(inputString);
                Console.WriteLine("Output randomized string by SystemRandomSort call is: " + outputStringFromRandomizeBySystemRandomSort);
            }
        }
    }

    public class RandomizeAString
    {
        public string RandomizeBySystemRandomFYShuffle(string inputString)
        {
            Random RNG = new Random();
            Char[] chars = inputString.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; --i)
            {
                int j = RNG.Next(0, i + 1);
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }
            return new string(chars);
        }

        public string RandomizeBySystemRandomSort(string inputString)
        {
            Random RNG = new Random();
            char[] charList = inputString.ToCharArray();
            Array.Sort(Enumerable.Range(0, charList.Length).Select(x => RNG.Next()).ToArray(), charList);
            return new string(charList.ToArray());
        }

        // Comparison of the two implementations:
        // RandomizeBySystemRandomFYShuffle: It uses the standard Random provided in c# along with the Fisher-Yates Shuffle. 
        //                                       The standard RNG is not quite a perfect random and there is evidence that it could be better. 
        //                                       The Fisher-Yates Shuffle, however, is optimal in being an efficient uniform shuffle (i.e. all 
        //                                       permutations have an equal probability). The time complexity is O(n), assuming random number 
        //                                       generating is of O(1).
        // RandomizeBySystemRandomSort: This one also uses Random. It assigns each element in the array with a random element in a toset 
        //                                  as a "key". As the key is part of a toset, we sort it to create an alternative order. 
        //                                  This is also uniformly random, but the time complexity is O(n log(n)), assuming random number 
        //                                  generating is of less than O(log(n)).
    }
}
