namespace Katas.Daniela.Ticona
{
    using System.Linq;

    /// <summary>
    /// Defines RemoveDuplicate utility class.
    /// </summary>
    public class RemoveDuplicate
    {
        /// <summary>
        /// Get Most Frequent Item.
        /// </summary>
        /// <param name="s"">Input string.</param>
        /// <returns>String without duplicates words.</returns>
        public static string RemoveDuplicateWords(string s)
        {
            return string.Join(" ", s.Split(' ').Distinct());
        }
    }
}