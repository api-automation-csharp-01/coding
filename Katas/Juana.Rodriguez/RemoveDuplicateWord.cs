namespace Katas.Juana.Rodriguez
{
    using System.Linq;

    /// <summary>
    /// Defines RemoveDuplicateWord utility class.
    /// </summary>
    public class RemoveDuplicateWord
    {
        /// <summary>
        /// Get Remove Duplicate Word.
        /// </summary>
        /// <param name="input">Input sequence.</param>
        /// <returns>duplicated word.</returns>
        public static string GetRemoveDuplicateWord(string[] input)
        {
            string[] text = input[0].Split(' ');
            return string.Join(" ", text.Distinct());
        }
    }
}
