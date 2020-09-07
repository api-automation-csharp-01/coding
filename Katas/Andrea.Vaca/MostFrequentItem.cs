namespace Katas.Andrea.Vaca
{
    /// <summary>
    /// Most Frequent Item class.
    /// </summary>
    public class MostFrequentItem
    {
        /// <summary>
        /// Get Most Frequent Item.
        /// </summary>
        /// <param name="input">Input sequence.</param>
        /// <returns>count.</returns>
        public static int GetMostFrequentItem(int[] input)
        {
            if (input.Length == 0)
            {
                return 0;
            }

            if (input.Length == 1)
            {
                return 1;
            }

            int frequent = input[0];
            int max = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (GetMostFrequentItemCount(frequent, input) < GetMostFrequentItemCount(input[i], input))
                {
                    frequent = input[i];
                    max = GetMostFrequentItemCount(input[i], input);
                }
            }

            return max;
        }

        /// <summary>
        /// Get Most Frequent Item Count.
        /// </summary>
        /// <param name="a">integer to compare.</param>
        /// <param name="input">Input sequence.</param>
        /// <returns>count of the integer a.</returns>
        public static int GetMostFrequentItemCount(int a, int[] input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (a == input[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
