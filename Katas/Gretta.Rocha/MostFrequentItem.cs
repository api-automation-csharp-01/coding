namespace Katas.Gretta.Rocha
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Define MostFrequentItem utility class.
    /// </summary>
    public class MostFrequentItem
    {
        /// <summary>
        /// Get counter of most frequent item of array.
        /// </summary>
        /// <param name="input">Input sequence.</param>
        /// <returns>counte int.</returns>
        public static int GetMostFrequentItemCount(int[] input)
        {
            int counter = 0;
            int longestOccurance = 0;
            int mostFrequentNumber = 0;

            for (int i = 0; i < input.Length; i++)
            {
                counter = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == input[i])
                    {
                        counter++;
                    }
                }

                if (counter > longestOccurance)
                {
                    longestOccurance = counter;
                    mostFrequentNumber = input[i];
                }
            }
            return longestOccurance;
        }
    }
}
