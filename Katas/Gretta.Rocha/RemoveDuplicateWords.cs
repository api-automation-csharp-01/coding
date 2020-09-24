namespace Katas.Gretta.Rocha
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>Define RemoveDuplicatedWords utility class.</summary>
    public class RemoveDuplicateWords
    {
        /// <summary>Define RemoveDuplicated function.</summary>
        /// <returns> Return a string that contain unique words.</returns>
        /// <param name="cadena">Contain the original string with words.</param>
        public static string RemoveDuplicated(string cadena)
        {
            return string.Join(" ", cadena.Split(' ').Distinct());
        }
    }
}
