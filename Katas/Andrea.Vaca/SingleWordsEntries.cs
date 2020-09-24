namespace Katas.Andrea.Vaca
{
    using System.Linq;

    /// <summary>
    /// Single Words Entries.
    /// </summary>
    public class SingleWordsEntries
    {
        /// <summary>
        /// Returns Single Words Entries.
        /// </summary>
        /// <param name="input">strings with many words.</param>
        /// <returns>only the single words.</returns>
        public static string GetSingleWordsEntries(string input)
        {
            string[] words = input.Split(' ');
            string result = string.Join(" ", words.Distinct());
            return result;
        }
    }
}
