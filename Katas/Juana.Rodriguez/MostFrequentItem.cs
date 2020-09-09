namespace Katas.Juana.Rodriguez
{
    using System.Linq;

    /// <summary>
    /// Defines Intersector utility class.
    /// </summary>
    public class MostFrequentItem
    {

        /// <summary>
        /// Get most frecuent item.
        /// </summary>
        /// <param name="input">Input sequence.</param>
        /// <returns>most frecuent item int.</returns>
        public static int GetMostFrecuent(int[] input)
        {
            var groups = input.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();
            return largest.Count();
        }
    }
}
