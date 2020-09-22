namespace KatasTests.Antonio.Rojas
{
    using Katas.Antonio.Rojas;
    using NUnit.Framework;

    /// <summary>
    /// Defines remove duplicated words test.
    /// </summary>
    [TestFixture]
    public class RemoveDupWordsTest
    {
        /// <summary>
        /// Tests remove duplicated words with basic input.
        /// </summary>
        [Test]
        public void TestRemoveDupWordsCase01()
        {
            string input = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";
            string output = RemoveDupWords.RemoveDuplicatedWords(input);
            Assert.AreEqual("alpha beta gamma delta", output);
        }

        /// <summary>
        /// Tests remove duplicated words with basic input.
        /// </summary>
        [Test]
        public void TestRemoveDupWordsCase02()
        {
            string input = "alpha beta gamma";
            string output = RemoveDupWords.RemoveDuplicatedWords(input);
            Assert.AreEqual("alpha beta gamma", output);
        }
    }
}
