namespace KatasTests.Alex.Alcala
{
    using Katas.Alex.Alcala;
    using NUnit.Framework;

    /// <summary>
    /// Defines RemoveDuplicateWords test.
    /// </summary>
    [TestFixture]
    public class RemoveDuplicateWordsTest
    {
        /// <summary>
        /// Tests RemoveDuplicateWords with an output of only single first words entries.
        /// </summary>
        [Test]
        public void TestRemoveDuplicateWords01()
        {
            string words = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";
            string output = RemoveDuplicateWords.RemoveDuplicateWord(words);
            string expected = "alpha beta gamma delta";
            Assert.AreEqual(expected, output);
        }
    }
}