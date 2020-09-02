namespace Katas.Marcos.Lara
{
    using System.Linq;

    /// <summary>
    /// Defines Intersector utility class.
    /// </summary>
    public class Intersector
    {
        /// <summary>
        /// Gets instersection.
        /// </summary>
        /// <param name="input">Input sequence.</param>
        /// <returns>Intersection string.</returns>
        public static string GetIntersection(string[] input)
        {
            string[] sequenceOne = input[0].Split(", ");
            string[] sequenceTwo = input[1].Split(", ");
            return string.Join(",", sequenceOne.Intersect(sequenceTwo));
        }
    }
}
