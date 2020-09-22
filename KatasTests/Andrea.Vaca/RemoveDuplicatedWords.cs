namespace KatasTests.Andrea.Vaca
{
    using Katas.Andrea.Vaca;
    using NUnit.Framework;

    /// <summary>
    /// Remove Duplicate Words.
    /// </summary>
    [TestFixture]
    public sealed class RemoveDuplicatedWords
    {
        /// <summary>
        /// Remove duplicated words given the a string with values duplicated.
        /// </summary>
        [Test]
        public void TestRemoveDuplicatedWords01()
        {
            string input = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma delta";
            string output = SingleWordsEntries.GetSingleWordsEntries(input);
            string expected = "alpha beta gamma delta";
            Assert.AreEqual(expected: expected, actual: output);
        }

        /// <summary>
        /// Remove duplicated words given the a string with values not duplicated.
        /// </summary>
        [Test]
        public void TestRemoveDuplicatedWords02()
        {
            string input = "alpha beta gamma";
            string output = SingleWordsEntries.GetSingleWordsEntries(input);
            string expected = "alpha beta gamma";
            Assert.AreEqual(expected: expected, actual: output);
        }

        /// <summary>
        /// Remove duplicate words given a string with only one value.
        /// </summary>
        [Test]
        public void TestRemoveDuplicatedWords03()
        {
            string input = " ";
            string output = SingleWordsEntries.GetSingleWordsEntries(input);
            string expected = string.Empty;
            Assert.AreEqual(expected: expected, actual: output);
        }

        /// <summary>
        /// Remove duplicate words given a string with only one value.
        /// </summary>
        [Test]
        public void TestRemoveDuplicatedWords04()
        {
            string input = "gamma";
            string output = SingleWordsEntries.GetSingleWordsEntries(input);
            string expected = "gamma";
            Assert.AreEqual(expected: expected, actual: output);
        }

        /// <summary>
        /// Remove duplicate words given an empty string.
        /// </summary>
        [Test]
        public void TestRemoveDuplicatedWords05()
        {
            string input = string.Empty;
            string output = SingleWordsEntries.GetSingleWordsEntries(input);
            string expected = string.Empty;
            Assert.AreEqual(expected: expected, actual: output);
        }
    }
}
