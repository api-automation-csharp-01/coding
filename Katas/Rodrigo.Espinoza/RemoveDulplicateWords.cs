namespace Katas.Rodrigo.Espinoza
{
    using System.Linq;

    /// <summary>
    /// Remove all duplicate words, leaving only single (first) words entries.
    /// </summary>
    public class RemoveDulplicateWords
    {
        /// <summary>
        /// Return the most frequency item Qty.
        /// </summary>
        /// <param name="duplicateWords">String.</param>
        /// <returns>Return only single words entries.</returns>
        public static string RemoveDuplicateWords(string duplicateWords)
    {
        return string.Join(" ", duplicateWords.Split(' ').Distinct());
    }
}
}
