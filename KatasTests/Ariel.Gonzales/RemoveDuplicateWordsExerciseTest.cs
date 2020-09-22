namespace KatasTests.Ariel.Gonzales
{
    using Katas.Ariel.Gonzales;
    using NUnit.Framework;

    /// <summary>
    /// Define Remove Duplicate Words in an string text tests.
    /// </summary>
    [TestFixture]
    public class RemoveDuplicateWordsExerciseTest
    {
        /// <summary>
        /// Tests RemoveDuplicateWords with string text as input.
        /// </summary>
        [Test]
        public void RemoveDuplicateWords_StringInput_ReturnString()
        {
            string input = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";
            string output = RemoveDuplicateWordsExercise.RemoveDuplicateWords(input);
            string expectedOutput = "alpha beta gamma delta";
            Assert.AreEqual(expectedOutput, output);
        }

        /// <summary>
        /// Tests RemoveDuplicateWords with string text with no differences as input.
        /// </summary>
        [Test]
        public void RemoveDuplicateWords_StringInput_ReturnSameString()
        {
            string input = "alpha beta gamma";
            string output = RemoveDuplicateWordsExercise.RemoveDuplicateWords(input);
            string expectedOutput = "alpha beta gamma";
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
