namespace Katas.Edmundo.Cossio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Defines Most Frequent Item Count class.
    /// </summary>
    public class MostFrequentItem
    {
        /// <summary>
        /// Gets the Count of Most Frequent Item in an Array
        /// </summary>
        /// <param name="elements">Array elements.</param>
        /// <returns>result.</returns>
        public static int MostFrequentItemCount(int[] elements)
        {
            var list = elements.GroupBy(val => val);
            var result = list.OrderByDescending(val => val.Count()).First();
            return result.Count();
        }
    }
}
