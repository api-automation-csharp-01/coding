namespace Katas.Antonio.Rojas
{
    using System.Linq;

    /// <summary>
    /// Defines RemoveDupWords utility class.
    /// </summary>
    public class RemoveDupWords
    {
        /// <summary>
        /// Gets string without duplicated words.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>String without duplicated words.</returns>
        public static string RemoveDuplicatedWords(string input)
        {
            string output;
            string[] arrayString = input.Split(' ');
            var wordsuinque =
            from str in arrayString
            select str;
            output = string.Join(" ", wordsuinque.Distinct().ToArray());
            return output;
        }
    }
}
