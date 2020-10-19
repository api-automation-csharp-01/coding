namespace Katas.Alexsis.Martinez
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Solve Katas exercise 7: Remove Duplicate words in a string.
    /// </summary>
    public class RemoveDuplicateWords
    {
        /// <summary>
        /// Solve Katas exercise 7: Remove Duplicate words in a string.
        /// </summary>
        /// <returns>
        /// returns the string without duplicate words
        /// </returns>
        public static string RemoveDuplicateString(string word)
        {
            var result = string.Join(" ", word.Split(" ").Distinct());
            return result;
        }
    }
}
