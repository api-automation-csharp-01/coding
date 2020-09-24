namespace Katas.Alejandra.Neolopan
{
    using System.Linq;

    /// <summary>
    /// Solve Katas exercise 1.
    /// </summary>
    public class MostFrequentItem
    {
        /// <summary>
        /// Count max of repetition.
        /// </summary>
        /// <param name="test"> an array of integers. </param>
        /// <returns>integer.</returns>
        public static int MostFrequentItemCount(int[] test)
        {
            if (test.Length > 0)
            {
                var result = test.GroupBy(x => x).Select(x => x.Count());
                return result.Max();
            }

            return 0;
        }
    }
}
