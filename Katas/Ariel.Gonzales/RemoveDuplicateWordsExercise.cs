namespace Katas.Ariel.Gonzales
{
    using System.Linq;

    /// <summary>
    /// Define Remove Duplicate Words in an string text.
    /// </summary>
    public static class RemoveDuplicateWordsExercise
    {
        /// <summary>
        /// Return string with unique text.
        /// </summary>
        /// <param name="text">Input string.</param>
        /// <returns>String with unique text.</returns>
        public static string RemoveDuplicateWords(string text)
        {
            var singularTexts = text.Split(" ").Distinct().ToList();
            return string.Join(" ", singularTexts);
        }
    }
}
