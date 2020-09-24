namespace Katas.Alejandra.Neolopan
{
    using System.Linq;

    /// <summary>
    /// Solve Katas exercise 2.
    /// </summary>
    public class RemoveDuplicateWords
    {
        /// <summary>
        /// Processing a text and split it and then get the unique strings.
        /// </summary>
        /// <param name="text">Text with several duplicated words.</param>
        /// <returns>It should return a string with unique words.</returns>
        public static string RemoveDuplicateWordsMethod(string text)
        {
            return string.Join(" ", text.Split(" ").Distinct().ToArray());
        }
    }
}
