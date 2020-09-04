using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Rodrigo.Espinoza
{
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
            if (collection.Length == 0 || collection == null) {
                return 0;
            }

            var groups = collection.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();
            return largest.Count();
        }
    }
}
