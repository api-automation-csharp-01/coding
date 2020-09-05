namespace Katas.Emilio.Zambrana
{
    using System.Linq;

    /// <summary>
    /// Defines MOST class.
    /// </summary>
    public class MostFreqItems
    {
        /// <summary>
        /// MostFreqItems.
        /// </summary>
        /// <param name="input">Input sequence.</param>
        /// <returns>counter.</returns>
        public static string GetFreqitem(int[] input)
        {
           if (input.Length == 0)
            {
                return 0;
            }
            else if (input.Length == 1)
            {
                return 1;
            }

           int mostreqitem = input[0];
           int most = 0;
           for (int i = 1; i < input.Length; i++)
            {
                if (GetMostFItemCounter(mostreqitem, input) < GetMostFItemCounter(input[i], input))
                {
                    mostreqitem = input[i];
                    most = GetMostFItemCounter(input[i], input);
                }
            }

            return most;
        }
         /// <summary>
        /// Get Most Frequent Item Count.
        /// </summary>
        /// <param name="x">integer to compare.</param>
        /// <param name="input">Input sequence.</param>
        /// <returns>counter of the integer a.</returns>
        public static int GetMostFItemCounter(int x, int[] input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (x == input[i])
                {
                    counter++;
                }
            }

            return counter;
        }