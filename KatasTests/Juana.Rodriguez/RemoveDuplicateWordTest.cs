namespace KatasTests.Juana.Rodriguez
{
    using Katas.Juana.Rodriguez;
    using NUnit.Framework;

    /// <summary>
    /// Defines remove duplicate word test.
    /// </summary>
    [TestFixture]
    public class RemoveDuplicateWordTest
    {
        /// <summary>
        /// Tests remove duplicate word with basic input.
        /// </summary>
        [Test]
        public void TestRemoveDuplicateWord01()
        {
            string[] input = new string[] { "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta" };
            string output = RemoveDuplicateWord.GetRemoveDuplicateWord(input);
            Assert.AreEqual("alpha beta gamma delta", output);
        }

        /// <summary>
        /// Tests remove duplicate word with basic input.
        /// </summary>
        [Test]
        public void TestRemoveDuplicateWord02()
        {
            string[] input = new string[] { "alpha beta gamma" };
            string output = RemoveDuplicateWord.GetRemoveDuplicateWord(input);
            Assert.AreEqual("alpha beta gamma", output);
        }

        /// <summary>
        /// Tests remove duplicate word with basic input.
        /// </summary>
        [Test]
        public void TestRemoveDuplicateWord03()
        {
            string[] input = new string[] { "a z a c z a a a z" };
            string output = RemoveDuplicateWord.GetRemoveDuplicateWord(input);
            Assert.AreEqual("a z c", output);
        }

        /// <summary>
        /// Tests remove duplicate word with basic input.
        /// </summary>
        [Test]
        public void TestRemoveDuplicateWord04()
        {
            string[] input = new string[] { "m" };
            string output = RemoveDuplicateWord.GetRemoveDuplicateWord(input);
            Assert.AreEqual("m", output);
        }
    }
}
