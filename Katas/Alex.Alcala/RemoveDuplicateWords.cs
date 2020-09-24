namespace Katas.Alex.Alcala
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines RemoveDuplicateWords utility class.
    /// </summary>
    public class RemoveDuplicateWords
    {
        /// <summary>
        /// RemoveDuplicateWords.
        /// </summary>
        /// <param name="words">A string of words.</param>
        /// <returns>Only single first words entries.</returns>
        public static string RemoveDuplicateWord(string words)
        {
            string[] wordsOnly = words.Split(' ');
            List<string> unique = new List<string>();

            foreach (var item in wordsOnly)
            {
                if (!unique.Contains(item))
                {
                    unique.Add(item);
                }
            }

            return string.Join(" ", unique);
        }
    }
}