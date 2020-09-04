namespace Katas.Alex.Alcala
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines MostFrequentItem utility class.
    /// </summary>
    public class MostFrequentItem
    {
        /// <summary>
        /// MostFrequentItemCount.
        /// </summary>
        /// <param name="collection">Collect sequence.</param>
        /// <returns>Most frequent Item.</returns>
        public static int MostFrequentItemCount(int[] collection)
        {
            if (collection == null || collection.Length == 0)
            {
                return 0;
            }

            var newDict = new Dictionary<int, int>();
            foreach (var number in collection)
            {
                if (newDict.ContainsKey(number))
                {
                    newDict[number] += 1;
                }
                else
                {
                   newDict.Add(number, 1);
                }
            }

            return newDict.Values.Max();
        }
    }
}