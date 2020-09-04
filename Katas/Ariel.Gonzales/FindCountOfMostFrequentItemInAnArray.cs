namespace Katas.Ariel.Gonzales
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Define Find Count of Most Frequent Item in an Array.
    /// </summary>
    public class FindCountOfMostFrequentItemInAnArray
    {
        /// <summary>
        /// Return the most frequency item Qty.
        /// </summary>
        /// <param name="collection">Input array.</param>
        /// <returns>Max Qty.</returns>
        public static int MostFrequentItemCount(int[] collection)
        {
            IDictionary<int, int> register = new Dictionary<int, int>();
            if (collection.Length == 0)
            {
                return 0;
            }

            foreach (int num in collection)
            {
                register[num] = register.ContainsKey(num) ? ++register[num] : 1;
            }

            return register.Values.Max();
        }
    }
}