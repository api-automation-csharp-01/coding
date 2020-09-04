namespace Katas.Antonio.Rojas
{
    using System;
    using System.Linq;

    /// <summary>
    /// Defines FrequentItem utility class.
    /// </summary>
    public class FrequentItem
    {
        /// <summary>
        /// Gets most frequest number.
        /// </summary>
        /// <param name="input">Input array.</param>
        /// <returns>Most frequest number count.</returns>
        public static int MostFrequentItemCount(int[] input)
        {
            if (input.Length == 0)
            {
                return 0;
            }

            var groups = input.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();
            return largest.Count();
        }
    }
}
