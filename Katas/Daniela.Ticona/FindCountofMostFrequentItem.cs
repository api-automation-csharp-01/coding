namespace Katas.Daniela.Ticona
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines FindCountofMostFrequentItem utility class.
    /// </summary>
    public class FindCountofMostFrequentItem
    {
        /// <summary>
        /// Get Most Frequent Item.
        /// </summary>
        /// <param name="collection">Input sequence.</param>
        /// <returns>occurrences.</returns>
        public static int MostFrequentItemCount(int[] collection)
        {
            var counts = new Dictionary<int, int>();
            foreach (int number in collection)
            {
                int count;
                counts.TryGetValue(number, out count);
                count++;
                counts[number] = count;
            }

            int mostCommonNumber = 0, occurrences = 0;
            foreach (var pair in counts)
            {
                if (pair.Value > occurrences)
                {
                    occurrences = pair.Value;
                    mostCommonNumber = pair.Key;
                }
            }

            return occurrences;
        }
    }
}